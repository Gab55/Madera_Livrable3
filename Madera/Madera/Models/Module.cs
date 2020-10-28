﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace Madera.Models
{
    public class Module
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ID { get; set; }
        public int GammeID { get; set; }
        public int PlanID { get; set; }
        public string LibelleModule { get; set; }
        public decimal PrixHtModule { get; set; }
        public decimal DebutPointX { get; set; }
        public decimal FinPointX { get; set; }
        public decimal DdebutPointY { get; set; }
        public decimal FinPointY { get; set; }
        public int IdUtilisateurCreation { get; set; }
        public DateTime DateCreation { get; set; }
        public int IdUtilisateurModification { get; set; }
        public DateTime DateModification { get; set; }
        public DateTime DateArchivage { get; set; }

        public Gamme gamme;
        
    }
}
