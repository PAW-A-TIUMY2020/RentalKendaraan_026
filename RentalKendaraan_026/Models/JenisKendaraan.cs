using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_026.Models
{
    public partial class JenisKendaraan
    {
        public int IdJenisKendaraan { get; set; }

        [Required(ErrorMessage = "Nama Jenis Kendaraan wajib diisi")]]
        public string NamaJenisKendaraan { get; set; }
    }
}
