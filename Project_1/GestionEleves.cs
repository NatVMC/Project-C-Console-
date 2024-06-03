using System;

using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace Project_1
{
    public class GestionEleves
    {




        public List<Eleve> ListEleves { get; set; }

        
        

        public int NombreEleves { get; set; }


        public List<Cours> ListCours { get; set; }

        public Eleve eleve { get; set; }



   


        public GestionEleves()
        {
            ListEleves = new List<Eleve>();


            for (int index = 0; index < ListEleves.Count; index ++)
            {


            }


            Eleve eleve1 = new Eleve( "Campos", "Natacha", "04/03/1991");


            ListEleves.Add(eleve1);


            Eleve eleve2 = new Eleve("Campos", "Miguel", "05/08/1990");

            ListEleves.Add(eleve2);

        }



        

       

     
        

        public  void CreerNoveauEleve()
        {
            Console.Clear();
            Console.WriteLine((" ").PadRight(100, '*'));
            Console.WriteLine("");
            Console.WriteLine("Vouillez saisir le nom de Élève:");
            string nomEleve = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("Vouillez saisir le prénom de Élève:");
            string prenomEleve = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("Vouillez saisir la date de naissance de Élève (en format jj/mm/aa):");
            string dateNaissanceEleve = Console.ReadLine();
            Console.WriteLine("");

            Eleve nouveauEleve = new Eleve(nomEleve, prenomEleve, dateNaissanceEleve);


            ListEleves.Add(nouveauEleve);

         



        }



        public void AjouterNoteEtApreciation()

        { 
            

            

            Console.WriteLine("Vouillez saisir le nom de Élève:");
            string nomEleve = Console.ReadLine();

            ListEleves.FirstOrDefault(ListEleves => ListEleves.Nom.ToLower() == nomEleve.ToLower());

            if (ListEleves == null)
            {
                Console.WriteLine("Éleve inexistant");
            }

            else
            {

                Console.WriteLine("Vouillez saisir le Cours :");

                string nomCours = Console.ReadLine();

                //ListCours.FirstOrDefault(ListCours => ListCours.Nom.ToLower() == nomCours.ToLower());

               // if (ListCours == null)
                //{

                    //Console.WriteLine("Cours inexistant");
                //}

                //else
                //{
                    Console.WriteLine("");


                    Console.WriteLine("Vouillez saisir la note:");
                    string note = Console.ReadLine();

                    double noteChoisie = Convert.ToDouble(note);

                Console.WriteLine("");

                Console.WriteLine("Vouillez écrire une appréciation(facultatif):");
                    string appreciation = Console.ReadLine();


                    Notes notes = new Notes( noteChoisie, appreciation);






                //}

            }




         
            
         
           

            






          



        }
















        public  void  Identifiant()
        {
            for (int identifiant = 0; identifiant < NombreEleves; identifiant++)
            {
                Eleve eleves1 = ListEleves[identifiant];

                Console.WriteLine(identifiant);
            }
        }



        public void ConsulterEleve()
        {

            Console.WriteLine("Vouillez saisir le nom de Élève à consulter:");
            string nomEleve = Console.ReadLine();

          
        }


    }
}

