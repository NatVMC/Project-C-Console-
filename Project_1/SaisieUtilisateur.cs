using System;
using Microsoft.VisualBasic.FileIO;

namespace Project_1
{
	public class SaisieUtilisateur
	{
       



         public void ReturnMenuAvecChoix()

        {
            Console.WriteLine("(Pour returner au Menu principal tapez sur une touche du clavier) \n");
            string decision = Console.ReadLine();

            


            if (decision == "")

            {
                ReturnMenu();

            }



            MenuPrincipal noveauMenuPrincipal = new MenuPrincipal();
            noveauMenuPrincipal.Menu_1();
            
        }


        public void ReturnMenu()

        {
            MenuPrincipal noveauMenuPrincipal = new MenuPrincipal();
            noveauMenuPrincipal.Menu_1();

        }


	}
}

