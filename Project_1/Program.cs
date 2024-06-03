using System.Text.Json;
using Newtonsoft.Json;

namespace Project_1;

class Program
{
    public static void Main(string[] args)
    {








        string contenueFichier = File.ReadAllText("monfichier.json");
        List<Cours> cours = JsonConvert.DeserializeObject<List<Cours>>(contenueFichier);

        string contenueFichier2 = File.ReadAllText("monfichier.json");
        List<Eleve> eleve = JsonConvert.DeserializeObject<List<Eleve>>(contenueFichier2);


        MenuPrincipal menu1 = new MenuPrincipal();
        menu1.Menu_1();


       

    }





}

