
namespace first_project.models
{

public class Client
{
    public int Id { get; set; }
    public string Nom { get; set; }
    public string Prenom { get; set; }

    public Client(int id, string nom, string prenom)
    {
        Id = id;
        Nom = nom;
        Prenom = prenom;
    }

}}