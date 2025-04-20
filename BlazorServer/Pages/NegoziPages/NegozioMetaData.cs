using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using BlazorServer.Models;
using SmartDynamicBlazor.Attributes;
using BlazorServer.Pages.ProdottiPages;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorServer.Pages.NegoziPages
{
    public class NegozioMetaDataLista
    {
        [Display(AutoGenerateField = false, AutoGenerateFilter = false)]
        public int IdNegozio { get; set; }

        [Display(Name = "Nome negozio")]
        [Filter(Name = "Nome negozio", FilterCondition = FilterConditions.Contains)]
        public string Nome { get; set; }

        [Display(AutoGenerateField = false, AutoGenerateFilter = false)]
        public byte[] Immagine { get; set; }

        public string Indirizzo { get; set; }

        [Display(Name = "Direttore")]
        [Filter(Name = "Direttore")]
        [DropDownList(typeof(Dipendente), nameof(Dipendente.IdDipendente), null, new string[] { nameof(Dipendente.Nome), " ", nameof(Dipendente.Cognome) })]
        public int IdDirettore { get; set; }

        [Display(Name = "Responsabile")]
        [Filter(Name = "Responsabile")]
        [DropDownList(typeof(Dipendente), nameof(Dipendente.IdDipendente), null, new string[] { nameof(Dipendente.Nome), " ", nameof(Dipendente.Cognome) })]
        public int IdResponsabile { get; set; }

    }

    public class NegozioMetaDataDettaglio
    {
        [Display(AutoGenerateField = false, AutoGenerateFilter = false)]
        public int IdNegozio { get; set; }

        [Display(Name = "Nome negozio")]
        public string Nome { get; set; }

        [Display(AutoGenerateField = false)]
        public byte[] Immagine { get; set; }

        public string Indirizzo { get; set; }

        [Display(Name = "Direttore")]
        [AutoComplete(typeof(Dipendente), nameof(Dipendente.IdDipendente), null, new string[] { nameof(Dipendente.Nome), " ", nameof(Dipendente.Cognome) },
            FilterWhere = nameof(Dipendente.IdRuolo) + " == 4 and " + nameof(Dipendente.IdNegozio) + " == null")]
        public int IdDirettore { get; set; }

        [Display(Name = "Responsabile")]
        [AutoComplete(typeof(Dipendente), nameof(Dipendente.IdDipendente), null, new string[] { nameof(Dipendente.Nome), " ", nameof(Dipendente.Cognome) },
            FilterWhere = nameof(Dipendente.IdRuolo) + " == 5 and " + nameof(Dipendente.IdNegozio) + " == null")]
        public int IdResponsabile { get; set; }

        [Display(Name = "Prodotti presenti nel negozio")]
        [RelationalModal(typeof(RelazioneNegozioProdotto), nameof(Prodotto.Nome),TEntityRelationLevel2 = typeof(Prodotto), View = RelationResultView.Grid,
            MetaDataGridView = typeof(ListaProdottoMetaData), AllowRelationEdit = true, RelationEditMetaData = typeof(DettaglioProdottoMetaData),
            MetaDataModalList = typeof(ProdottoMetaDataLista))]
        public virtual ICollection<RelazioneNegozioProdotto> RelazioneNegozioProdotto { get; set; }

    }
    public class DettaglioProdottoMetaData
    {
        [Display(AutoGenerateField = false)]
        public int IdRelazione { get; set; }

        [ReadOnly(true)]
        [Display(Name = "Negozio")]
        [AutoComplete(typeof(Negozio), nameof(Negozio.IdNegozio), nameof(Negozio.Nome))]
        public int IdNegozio { get; set; }

        [ReadOnly(true)]
        [Display(Name = "Prodotto")]
        [AutoComplete(typeof(Prodotto), nameof(Prodotto.IdProdotto), nameof(Prodotto.Nome))]
        public int IdProdotto { get; set; }

        public int Quantità { get; set; }

        public decimal Prezzo { get; set; }
    }

    public class ListaProdottoMetaData
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

        [Display(Order = 4, AutoGenerateFilter = false, Name = "Prezzo base")]
        public string PrezzoConEuro { get; set; }

    }

}
