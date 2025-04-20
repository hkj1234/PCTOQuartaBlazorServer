using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;
using BlazorServer.Models;
using Microsoft.EntityFrameworkCore;
using SmartDynamicBlazor.Attributes;
using BlazorServer.Pages.NegoziPages;
using System.ComponentModel;
using Microsoft.CodeAnalysis.CSharp;

namespace BlazorServer.Pages.LuoghiProdotti
{
    public class LuoghiProdottiMetaDataLista
    {
        [Display(AutoGenerateFilter = false, AutoGenerateField = false)]
        public int IdRelazione { get; set; }

        [Display(Name = "Nome Negozio", Order = 2)]
        [AutoComplete(typeof(Negozio), nameof(Negozio.IdNegozio), nameof(Negozio.Nome))]
        [DisplayGroup(nameof(Negozio.IdNegozio), "hello")]
        public int[] IdNegozio { get; set; }

        [Display(Name = "Nome Prodotto", Order = 1)]
        [AutoComplete(typeof(Prodotto), nameof(Prodotto.IdProdotto), nameof(Prodotto.Nome))]
        [DisplayGroup(nameof(Prodotto.IdProdotto), "hello")]
        public int IdProdotto { get; set; }

        [Display(AutoGenerateFilter = false, AutoGenerateField = false)]
        public int Quantità { get; set; }

        [Display(AutoGenerateFilter = false, AutoGenerateField = false)]
        public decimal Prezzo { get; set; }

    }
}
