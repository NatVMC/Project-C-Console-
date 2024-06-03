using System;
namespace Project_1
{
	public  class MenuPrincipal
	{

        MenuEleve menu2 = new MenuEleve();

        MenuCours menu3 = new MenuCours();

        bool sortir = false;


      

        public void Menu_1()
		{

       
            Console.Clear();

            Console.WriteLine((" ").PadRight(100, '*'));
            Console.WriteLine("");
            Console.WriteLine(" Choisissez une des option en tappant son numero correspondent :\n" +
             " 1 - Eleves\n" +
             " 2 - Cours\n");
            Console.WriteLine(("").PadRight(100, '*'));

            string option = Console.ReadLine();
            int saisirUtilisateur = Convert.ToInt32(option);

            if (saisirUtilisateur == 1)
            {

                menu2.Menu_2();
            }
            if (saisirUtilisateur == 2)
            {
                menu3.Menu_3();
            }

        
        }




    }
}

