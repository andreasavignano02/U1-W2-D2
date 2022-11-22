using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace U1_W1_D2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //istanziamneto della lista di compiti
            Compiti c1 = new Compiti();
            c1.compiti = "Ferramenta";

            

            //istanziamento della persona
            CV p1 = new CV();
            
            //instanziamento d'informazioniPersonali
            InformazioniPersonali info = new InformazioniPersonali();
            info.name = "Andrea";
            info.surname = "Savignano";
            info.mobile = "3448469289";
            info.email = "example@example.com";
            p1.InformazioniPersonali = info;

            // istanziamento degli studi
            Studi studio = new Studi();
            studio.qualifica = "studente";
            studio.istituto = "liceo superiore Da Procida";
            studio.tipo = "Scientifico";
            studio.dataInizio = new DateTime(2015, 08, 15);
            studio.dataFine = new DateTime(2022, 06, 15);


            //istanziamento degli impieghi
            Impiego imp = new Impiego();
            imp.azienda = "";
            imp.jobtype = "";
            imp.dataInizio = new DateTime(2002, 07, 17);
            imp.dataFine = DateTime.Now;
            imp.description = "ciaone";
            imp.compiti.Add(c1);
          

            Console.WriteLine
                (
                    $"CV di Andrea Savignano " +
                    $" inizio informazioni personali " +
                    $"Nome : {p1.InformazioniPersonali.name} " +
                    $"Cognome : {p1.InformazioniPersonali.surname} " +
                    $"telefono : {p1.InformazioniPersonali.mobile} " +
                    $"email : {p1.InformazioniPersonali.email} " +
                    $"compiti : {p1.Impieghi.compiti}"
                    
                );


            Console.ReadLine();
        }
        
        
        
        
        //classe generale :
        public class CV
        {
            public InformazioniPersonali InformazioniPersonali { get; set; }
            public Studi StudiEffetuati { get; set; }
            public Impiego Impieghi { get; set; }
        }

        // classe informazionipersonali:
        public class InformazioniPersonali
        {
            public string name { get; set; }
            public string surname { get; set; }
            public string mobile { get; set; }
            public string email { get; set; }

        }
        //classe studi da inserire nella classe generale
        public class Studi
        {
            public string qualifica { get; set; }
            public string istituto { get; set;}
            public string tipo { get; set; }
            public DateTime dataInizio { get; set; }
            public DateTime dataFine { get; set;}
        }
       

        // classe esperienza da inserire nella proprietà d'impiego
        public class Impiego
        {
            public string azienda { get; set; }
            public string jobtype { get; set; }
            public DateTime dataInizio { get; set; }
            public DateTime dataFine { get; set;}
            public string description { get; set; }
            public List<Compiti> compiti  { get; set; } = new List<Compiti>();
        }
        public class Compiti
        {
            public string compiti { get; set; }
        }
    }
}
