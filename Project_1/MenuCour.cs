using System;
using static System.Collections.Specialized.BitVector32;

namespace Project_1
{
	public class MenuCours

	{
        

        public Cours cours { get; set; }

        
        


        GestionCours gestion = new GestionCours();

        SaisieUtilisateur choixUtilisateur = new SaisieUtilisateur();

        Lister Lister = new Lister();

        GestionEleves GestionEleves = new GestionEleves(); //je ne doit pas faire ça mas il fallait pour etre plus rapid




            public void Menu_3()
        {

            Console.Clear();
            Console.WriteLine(("").PadRight(100, '*'));
            Console.WriteLine("");
            Console.WriteLine("* Choisissez une des options en tappant son numero correspondent :\n" +
             "* 1 - Lister les cours existants\n" +
             "* 2 - Ajouter un nouveau cours au programme\n" +
             "* 3 - Supprimer un cours par son identifiant\n" +
             "* 4 - Revenir au menu principal\n");
            Console.WriteLine(("").PadRight(100, '*'));

            string option = Console.ReadLine();

            int saisirUtilisateur = Convert.ToInt32(option);



            if (saisirUtilisateur == 1)
            {
                Console.Clear();
                Console.WriteLine(("").PadRight(100, '*'));
                Console.WriteLine("");

                

                Lister.ListerCours(gestion);
                Console.WriteLine("");

                Console.WriteLine("");

                Console.WriteLine(("").PadRight(100, '*'));


                choixUtilisateur.ReturnMenuAvecChoix();
           

            }
            if (saisirUtilisateur == 2)
            {

                Console.Clear();
                Console.WriteLine(("").PadRight(100, '*'));
                Console.WriteLine("");


                gestion.CreerNouveauCours();

                Console.WriteLine("Cours ajouté avec succées!");



                Console.WriteLine("");

                Console.WriteLine(("").PadRight(100, '*'));

                choixUtilisateur.ReturnMenuAvecChoix();



            }
            if (saisirUtilisateur == 3)
            {
                Console.WriteLine("");
            }
         
            if (saisirUtilisateur == 4)
            {

                choixUtilisateur.ReturnMenu();


            }

        }

    }
}

