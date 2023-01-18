using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MagazinDeBijuteriiPROIECTFINAL.Models
{
    public class UtilizatorModel
    {
        public int Id { get; set; }
        [MaxLength(30)]
        public string Nume { get; set; }
        [MaxLength(30)]
        public string Prenume { get; set; }
        [MaxLength(30)]
        public string Username { get; set; }
        [MaxLength(30)]
        public string Parola { get; set; }
        public double Pret { get; set; }
    }

    public class UtilizatorDbContext : DbContext
    {
        DbSet<UtilizatorModel> Utilizatori { get; set; }
    }
}