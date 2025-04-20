using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;
using BlazorServer.Models;
using Microsoft.EntityFrameworkCore;
using SmartDynamicBlazor.Attributes;

namespace BlazorServer.Pages.ClientiPages
{
    public class ClienteMetaDataLista
    {
        [Display(AutoGenerateField = false, AutoGenerateFilter = false)]
        public int IdCliente { get; set; }

        [Display(Order = 1)]
        public string Username { get; set; }

        [Display(AutoGenerateFilter = false, Order = 2)]
        public string Password { get; set; }

        [Filter(IsAdvanced = true)]
        [Display(Order = 5)]
        public decimal SoldiDisponibili { get; set; }

        [Display(Order = 3)]
        public string Nome { get; set; }

        [Display(Order = 4)]
        public string Cognome { get; set; }

        [Filter(IsAdvanced = true)]
        [Display(Order = 6)]
        public string CodiceFiscale { get; set; }

        [Filter(IsAdvanced = true)]
        [Display(Order = 7)]
        public string Cap { get; set; }

        [Filter(IsAdvanced = true)]
        [Display(Order = 8)]
        public string Città { get; set; }

        [Filter(IsAdvanced = true)]
        [Display(Order = 9)]
        public string Indirizzo { get; set; }

    }

    public class ClienteMetaDataDettaglio
    {
        [Display(AutoGenerateField = false, AutoGenerateFilter = false)]
        public int IdCliente { get; set; }

        public string Username { get; set; }

        [Display(AutoGenerateFilter = false)]
        public string Password { get; set; }

        [Filter(IsAdvanced = true)]
        public decimal SoldiDisponibili { get; set; }

        public string Nome { get; set; }

        public string Cognome { get; set; }

        [Filter(IsAdvanced = true)]
        public string CodiceFiscale { get; set; }

        [Filter(IsAdvanced = true)]
        public string Cap { get; set; }

        [Filter(IsAdvanced = true)]
        public string Città { get; set; }

        [Filter(IsAdvanced = true)]
        public string Indirizzo { get; set; }

    }

}
