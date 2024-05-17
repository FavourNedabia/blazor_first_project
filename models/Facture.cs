
namespace first_project.models
{


public class Facture
{
    public int Id { get; set; }
    public Client Client { get; set; }
    public DateTime DateFacture { get; set; }
    public List<LigneCommand> LignesFacture { get; set; } = new List<LigneCommand>();
    public decimal MontantTotal { get; set; }

    public Facture(Client client, DateTime dateFacture)
    {
        Client = client;
        DateFacture = dateFacture;
    }

    public void AjouterLigneFacture(Produit produit, int quantité)
    {
        var ligneFacture = new LigneCommand(produit, quantité);
        LignesFacture.Add(ligneFacture);
        RecalculerMontantTotal();
    }

    private void RecalculerMontantTotal()
    {
        MontantTotal = 0;
        foreach (var ligneFacture in LignesFacture)
        {
            MontantTotal += ligneFacture.PrixTotal;
        }
    }
}}