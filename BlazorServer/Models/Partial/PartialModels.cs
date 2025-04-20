namespace BlazorServer.Models
{
    public partial class Prodotto
    {
        public string PrezzoConEuro { get => Math.Round(Prezzo, 2) + "€"; } 
    }
}
