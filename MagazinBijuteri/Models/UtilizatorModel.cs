using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace MagazinBijuteri.Models
{
    public class UtilizatorModel
    {
        [Key]
        public int Id { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; } 
        public string Parola { get; set; }
    }

    public class UtilizatorDbContext : DbContext
    { 
        public DbSet<UtilizatorModel> Utilizatori { get; set; }
    }

}