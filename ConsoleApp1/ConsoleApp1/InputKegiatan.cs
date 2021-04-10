using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class InputKegiatan
    {
        private string jenis;
        private string deskripsi;
        private int durasi;
        private int SkalaPrioritas;
        private int TanggalBerakhir;
        private int PukulBerakhir;


        public string Jenis { get => jenis; set => jenis = value; }
        public string Deskripsi { get => deskripsi; set => deskripsi = value; }     
        public int Durasi { get => durasi; set => durasi = value; }
        public int SkalaPrioritas1 { get => SkalaPrioritas; set => SkalaPrioritas = value; }
        public int TanggalBerakhir1 { get => TanggalBerakhir; set => TanggalBerakhir = value; }
        public int PukulBerakhir1 { get => PukulBerakhir; set => PukulBerakhir = value; }
    }
}
