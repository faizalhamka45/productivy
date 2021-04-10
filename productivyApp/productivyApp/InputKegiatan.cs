using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Spatial;
using System.ComponentModel.DataAnnotations.Schema;

namespace productivyApp
{
    public partial class InputKegiatan
    {
       [DatabaseGenerated(DatabaseGeneratedOption.None)]
       public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string jenis { get; set; }

        [Required]
        [StringLength(50)]
        public string nama_kegiatan { get; set; }

        public DateTime tanggal_dikerjakan { get; set; }

        public TimeSpan? jam_dimulai { get; set; }

        public TimeSpan? jam_berakhir { get; set; }

        [StringLength(10)]
        public string sequence { get; set; }

        [StringLength(50)]
        public string deskripsi { get; set; }

    }
}
