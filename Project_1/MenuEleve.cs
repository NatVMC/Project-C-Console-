using System;
namespace Project_1
{
	public class MenuEleve
	{

        GestionEleves gestion = new GestionEleves();

        Lister lister = new Lister();

        SaisieUtilisateur choixUtilisateur = new SaisieUtilisateur();



      








        public void Menu_2()
        {
            
            
                Console.Clear();
                Console.WriteLine(("").PadRight(100, '*'));
                Console.WriteLine("*");
                Console.WriteLine("* Choisissez une des options en tappant son numero correspondent :\n" +
                 "* 1 - Lister les élèves\n" +
                 "* 2 - Créer un nouvel élève\n" +
                 "* 3 - Consulter un élève existant\n" +
                 "* 4 - Ajouter une note et une appréciation pour un cours sur un élève existant\n" +
                 "* 5 - Revenir au menu principal\n");
                Console.WriteLine(("").PadRight(100, '*'));

                string option = Console.ReadLine();


                int saisirUtilisateur = Convert.ToInt32(option);



                if (saisirUtilisateur == 1)
                {
                    Console.Clear();
                    Console.WriteLine(("").PadRight(100, '*'));
                    Console.WriteLine("");

                    lister.ListerEleve(gestion);

                Console.WriteLine("");

                Console.WriteLine("");

                Console.WriteLine(("").PadRight(100, '*'));

                choixUtilisateur.ReturnMenuAvecChoix();


            }


                if (saisirUtilisateur == 2)
                {


                  gestion.CreerNoveauEleve();
                  Console.WriteLine("           ***********Élève ajouté avec succès***********");

                Console.WriteLine("");


                Console.WriteLine((" ").PadRight(100, '*'));

                choixUtilisateur.ReturnMenuAvecChoix();
            }




                if (saisirUtilisateur == 3)
                {

                    
                }
                if (saisirUtilisateur == 4)
                {



                Console.Clear();
                Console.WriteLine(("").PadRight(100, '*'));
                Console.WriteLine("");

                
                gestion.AjouterNoteEtApreciation();


                Console.WriteLine("");

                Console.WriteLine("");

                Console.WriteLine(("").PadRight(100, '*'));

                choixUtilisateur.ReturnMenuAvecChoix();



            }
                if (saisirUtilisateur == 5)
                {

                choixUtilisateur.ReturnMenu();


                }   



        }
    }
}

