namespace first_project.models
{


public class LigneCommand
{
    public int Id { get; set; }
    public Produit Produit { get; set; }
    public int Quantite { get; set; }
    public decimal PrixTotal { get; set; }

    public LigneCommand(Produit produit, int quantite)
    {
        Produit = produit;
        Quantite = quantite;
        PrixTotal = produit.Prix * quantite;
    }
}

}