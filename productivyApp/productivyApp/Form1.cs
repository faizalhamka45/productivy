using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;
using System.Text.RegularExpressions;
using System.IO;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.Threading;

namespace productivyApp
{
    public partial class Form1 : Form
    {
        SqlConnection koneksi = new SqlConnection(@"Data Source=DESKTOP-RJ89BOH;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        static string[] Scopes = { CalendarService.Scope.CalendarReadonly };
        static string ApplicationName = "productivy";
        int Id { get; set; }
        internal enum Action { Edit, Insert}
        Action action;
        String repeat;
        SqlCommand cmd;
        DataGridView row;
        InputKegiatan inputkegiatan;
        TextBox tbjam_dimulai;
        TextBox tbjam_berakhir;
    
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(int id)
        {
            InitializeComponent();
            Id = id;
            action = Action.Insert;
        }

        public Form1(DataGridView row)
        {
            InitializeComponent();
            UbahMaskedToText();


        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value < DateTime.Today)
                MessageBox.Show("waktu sudah terlewat. Harap isikan tanggal dengan benar");
            else if (action == Action.Insert)
            {
                if (TambahData())
                    InsertGCalendar();
            }
            else
                EditData();
        }

        private void cbJenis_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rbYa_CheckedChanged(object sender, EventArgs e)
        {
            if (rbYa.Checked)
            {
                cbSequence.Enabled = true;
            }
            else
            {
                cbSequence.Text = "";
                cbSequence.Enabled = false;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void jamMulai_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void jamBerakhir_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void cbSequence_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbDeskripsi_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private bool TambahData()
        {
            using (ScheduleModel sm = new ScheduleModel())
            {
                inputkegiatan = new InputKegiatan
                {
                    Id = this.Id,
                    jenis = cbJenis.Text,
                    nama_kegiatan = cbNamaKegiatan.Text,
                    tanggal_dikerjakan = dateTimePicker1.Value,
                    deskripsi = tbDeskripsi.Text
                };
                try
                {
                    inputkegiatan.jam_dimulai = new TimeSpan(Convert.ToInt32(dateTimePicker1.Text.Remove(2)), Convert.ToInt32(dateTimePicker1.Text.Remove(0, 3)), 0);
                }
                catch
                {
                    if (MessageBox.Show("apakah Anda yakun tidak ingin memasukkan jam dimulai","Konfirmasi", MessageBoxButtons.YesNo) == DialogResult.No)
                        return false;
                }
                try
                {
                    sm.Schedule.Add(inputkegiatan);
                    sm.SaveChanges();
                }
                catch
                {
                    MessageBox.Show("Mohon maaf kegiatan gagal di tambhakan, silakan ulangi lagi","info");
                    return false;
                }
            }
            MessageBox.Show("kegiatan berhasil di tambahkan","info");
            return true;
        }
        private void EditData()
        {

        }

        private void UbahMaskedToText()
        {
            tbjam_dimulai = new TextBox();
            tbjam_dimulai.Location = tbjam_dimulai.Location;
            tbjam_dimulai.Size = tbjam_dimulai.Size;
            Controls.Remove(tbjam_dimulai);
            Controls.Add(tbjam_dimulai);
            tbjam_dimulai.Dispose();

            tbjam_berakhir = new TextBox();
            tbjam_berakhir.Location = tbjam_berakhir.Location;
            tbjam_berakhir.Size = tbjam_berakhir.Size;
            Controls.Remove(tbjam_berakhir);
            Controls.Add(tbjam_berakhir);
            tbjam_berakhir.Dispose();
        }

        private void InsertGCalendar()
        {
            UserCredential credential;

            using (var stream =
                new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
            {
                // The file token.json stores the user's access and refresh tokens, and is created
                // automatically when the authorization flow completes for the first time.
                string credPath = "token.json";
                try
                {
                   credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                   GoogleClientSecrets.Load(stream).Secrets,
                   Scopes,
                   "user",
                   CancellationToken.None,
                   new FileDataStore(credPath, true)).Result;
                }
                catch
                {
                    return;
                }
            }

            // Create Google Calendar API service.
            CalendarService service = new CalendarService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

            //membuat kegiatan baru
            bool IsAllDay = false;
            try
            {
                new TimeSpan(Convert.ToInt32(jamMulai.Text.Remove(2)), Convert.ToInt32(jamMulai.Text.Remove(0, 3)), 0);
            }
            catch
            {
                IsAllDay = true;
            }
            Event newEvent;
            if (!IsAllDay)
            {
                newEvent = new Event()
                {
                    Summary = cbJenis.Text + ": "+ cbNamaKegiatan + " " + jamMulai.Text + "-" + jamBerakhir.Text,
                    Start = new EventDateTime()
                    {
                        Date = dateTimePicker1.Value.ToString("yyyy-MM-dd"), //cara masukin intervalnya gimana :"
                        TimeZone = "Asia/Jakarta"
                    },
                    End = new EventDateTime()
                    { 
                        Date = dateTimePicker1.Value.ToString("yyyy-MM-dd"),
                        TimeZone = "Asia/Jakarta"
                    }
                };
            }
            else
            {
                newEvent = new Event()
                {
                    Summary = cbJenis.Text + " " + cbNamaKegiatan,
                    Start = new EventDateTime()
                    {
                        Date = dateTimePicker1.Value.ToString("yyyy-MM-dd"), 
                        TimeZone = "Asia/Jakarta"
                    },
                    End = new EventDateTime()
                    {
                        Date = dateTimePicker1.Value.ToString("yyyy-MM-dd"),
                        TimeZone = "Asia/Jakarta"
                    }
                };
            }
            if (tbDeskripsi.Text != "")
                newEvent.Description = tbDeskripsi.Text;

            string calendarId = "primary";
            try
            {
                EventsResource.InsertRequest request = service.Events.Insert(newEvent, calendarId);
                Event createEvent = request.Execute();
                MessageBox.Show("Google calendar terhubung");
            }
            catch(Exception e)
            {
                MessageBox.Show("Google calendar gagal terhubung" + e.Message, "pemberitahuan");
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
