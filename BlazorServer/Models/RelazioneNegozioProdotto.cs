﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorServer.Models
{
    public partial class RelazioneNegozioProdotto
    {
        public RelazioneNegozioProdotto()
        {
            Carello = new HashSet<Carello>();
        }

        [Key]
        [Column("idRelazione")]
        public int IdRelazione { get; set; }
        [Column("idNegozio")]
        public int IdNegozio { get; set; }
        [Column("idProdotto")]
        public int IdProdotto { get; set; }
        [Column("quantità")]
        public int Quantità { get; set; }
        [Column("prezzo", TypeName = "money")]
        public decimal Prezzo { get; set; }

        [ForeignKey("IdNegozio")]
        [InverseProperty("RelazioneNegozioProdotto")]
        public virtual Negozio IdNegozioNavigation { get; set; }
        [ForeignKey("IdProdotto")]
        [InverseProperty("RelazioneNegozioProdotto")]
        public virtual Prodotto IdProdottoNavigation { get; set; }
        [InverseProperty("IdRelazioneNegozioProdottoNavigation")]
        public virtual ICollection<Carello> Carello { get; set; }
    }
}