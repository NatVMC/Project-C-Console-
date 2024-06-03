using System.Text.Json;


using System.Collections.Generic;




namespace Project_1
{
    public class Eleve
    {

        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string DateDeNaissance { get; set; }
        
        public List<Eleve> ListEleves { get; set; }
             
        public  GestionEleves gestion{ get; set; }


        


          

        


        public Eleve(string nom, string prenom, string dateDeNaissance)
        {


            Nom = nom;
            Prenom = prenom;
            DateDeNaissance = dateDeNaissance;

       
           
           
        }

       



        
          




    }
}

