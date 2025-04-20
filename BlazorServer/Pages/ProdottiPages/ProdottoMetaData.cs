using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;
using BlazorServer.Models;
using Microsoft.EntityFrameworkCore;
using SmartDynamicBlazor.Attributes;

namespace BlazorServer.Pages.ProdottiPages
{
    public class ProdottoMetaDataLista
    {
        [Display(AutoGenerateFilter = false, AutoGenerateField = false)]
        public int IdProdotto { get; set; }
        
        [Display(Order = 1)]
        public string Nome { get; set; }


        [Display(AutoGenerateFilter = false, AutoGenerateField = false)]
        public byte[] Immagine { get; set; }

        [Display(Order = 2)]
        public string Caratteristiche { get; set; }

        [Display(Order = 3)]
        public string Marca { get; set; }

        [Display(Order = 4, AutoGenerateFilter = false, Name = "Prezzo")]
        public string PrezzoConEuro { get; set; }

    }

    public class ProdottoMetaDataDettaglio
    {
        [Display(AutoGenerateFilter = false, AutoGenerateField = false)]
        public int IdProdotto { get; set; }

        public string Nome { get; set; }


        [Display(AutoGenerateFilter = false, AutoGenerateField = false)]
        public byte[] Immagine { get; set; }

        [DisplayField(Rows = 2)]
        public string Caratteristiche { get; set; }

        public string Marca { get; set; }

        public decimal Prezzo { get; set; }

    }

}
