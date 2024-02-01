namespace ApiPapeterie.models
{
    public class Produit
    {
        public int id { get; set; }
        public string nom { get; set; }
        public string texture { get; set; }
        public float grammage { get; set; }
        public float prix { get; set; }
        public string? couleur { get; set; }
    }
}
