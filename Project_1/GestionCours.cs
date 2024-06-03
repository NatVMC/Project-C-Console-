using System;
using System.Linq;
using System.Xml;
using Microsoft.VisualBasic.FileIO;
using System.Text.Json;
using Newtonsoft.Json;

namespace Project_1
{
	public class GestionCours
	{


        public List<Cours> ListDeCours { get; set; }

        
        
        




        public GestionCours()
        {
            ListDeCours = new List<Cours>();

            string CoursJson = JsonConvert.SerializeObject(ListDeCours, Newtonsoft.Json.Formatting.Indented);
            Console.WriteLine(ListDeCours);
            File.WriteAllText("monfichier.json", CoursJson);


            Cours cours1 = new Cours("Anglais");

            ListDeCours.Add(cours1);

            Cours cours2 = new Cours("Mathématique");

            ListDeCours.Add(cours2);


            
        }





        public void CreerNouveauCours()
        {
           

            Console.WriteLine("Entrez le Nom du nouveau cours:");
           string nomCours = Console.ReadLine();

          
            Cours cours1 = new Cours(nomCours);
            cours1.Nom = nomCours;

            ListDeCours.FirstOrDefault(ListDeCours => ListDeCours.Nom.ToLower() == nomCours.ToLower());


            if (ListDeCours==null)
            {

                ListDeCours.Add(cours1);

                
              

            }

          




        }





    }
}

