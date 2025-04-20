using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;
using BlazorServer.Models;
using Microsoft.EntityFrameworkCore;
using SmartDynamicBlazor.Attributes;
using BlazorServer.Pages.NegoziPages;
using System.ComponentModel;
using Microsoft.CodeAnalysis.CSharp;

namespace BlazorServer.Pages.DipendentiPages
{
    public class DipendenteMetaDataLista
    {
        [Display(AutoGenerateField = false, AutoGenerateFilter = false)]
        public int IdDipendente { get; set; }

        [Filter(IsAdvanced = true)]
        public string Username { get; set; }

        [Display(AutoGenerateField = false, AutoGenerateFilter = false)]
        public string Password { get; set; }

        [Display(Name = "negozio")]
        [DropDownList(typeof(Negozio), nameof(Negozio.IdNegozio), nameof(Negozio.Nome) )]
        public int? IdNegozio { get; set; }

        public string Nome { get; set; }

        public string Cognome { get; set; }

        [Filter(IsAdvanced = true)]
        public string CodiceFiscale { get; set; }

        [Display(Name = "ruolo")]
        [DropDownList(typeof(Ruolo), nameof(Ruolo.IdRuolo), nameof(Ruolo.Nome))]
        public int? IdRuolo { get; set; }
    }

    public class DipendenteMetaDataDettaglioDati
    {
        [Display(AutoGenerateField = false, AutoGenerateFilter = false)]
        public int IdDipendente { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Nome { get; set; }

        public string Cognome { get; set; }

        public string CodiceFiscale { get; set; }

        [Display(Name = "ruolo")]
        [AutoComplete(typeof(Ruolo), nameof(Ruolo.IdRuolo), nameof(Ruolo.Nome), MinCharacterToAutoComplete = 0)]
        public int? IdRuolo { get; set; }

    }
    public class DipendenteMetaDataDettaglioNegozioLavoratore
    {
        [Display(Name = "negozio")]
        [AutoComplete(typeof(Negozio), nameof(Negozio.IdNegozio), nameof(Negozio.Nome))]
        public int? IdNegozio { get; set; }
    }
    public class DipendenteMetaDataDettaglioNegozioResponsabile
    {
        [Display(Name = "negozi")]
        [RelationalModal(typeof(Negozio), nameof(Negozio.Nome), View = RelationResultView.Grid,
            MetaDataGridView = typeof(NegozioMetaDataLista), MetaDataModalList = typeof(NegozioMetaDataLista))]
        [ReadOnly(true)]
        public virtual ICollection<Negozio> NegozioIdResponsabileNavigation { get; set; }
    }
    public class DipendenteMetaDataDettaglioNegozioDirettore
    {
        [Display(Name = "negozi")]
        [RelationalModal(typeof(Negozio), nameof(Negozio.Nome), View = RelationResultView.Grid,
            MetaDataGridView = typeof(NegozioMetaDataLista), MetaDataModalList = typeof(NegozioMetaDataLista))]
        [ReadOnly(true)]
        public virtual ICollection<Negozio> NegozioIdDirettoreNavigation { get; set; }
    }
}
