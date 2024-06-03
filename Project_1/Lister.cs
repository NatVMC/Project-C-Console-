using System;
namespace Project_1
{
	public class Lister
	{

    
       
     

        public void ListerCours(GestionCours gestionCours)
        {
            List<Cours> ListDeCours = gestionCours.ListDeCours; 

            foreach ( Cours cours in ListDeCours)
            {
               

                Console.WriteLine(cours.Nom);

            }
        }



        public void ListerEleve(GestionEleves gestionEleves)
        {
            List<Eleve> listEleves = gestionEleves.ListEleves;

            foreach (Eleve eleve in listEleves)

            {
                Console.WriteLine(eleve.Nom+ " " + eleve.Prenom);

            }
        }
       
    }
}

