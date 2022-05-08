using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stopki_html
{
    static class Program
    {
        /*
         * 
         Zmienne pobrane z formularza s¹ wczytywane do zmiennych globalnych. 
         *
         */
        internal static string imie;
        internal static string nazwisko;
        internal static string dzial;
        internal static string stanowisko;
        internal static string emailEND;




        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);


            //Generacja EMAIL'a
            string email_generated = imie[0].ToString().ToLower(); //pobranie pierwszego znaku imienia i transformacja na ma³¹ literê
            email_generated = email_generated + "." + nazwisko.ToLower(); //dodanie kropki i przepisywanie nazwiska malymi literami
            email_generated = email_generated + "@" + emailEND.ToLower(); //dodanie ma³py i koñcówki adersu np. @cinkciarz.pl
            //

            //Wczytanie wzoru stopki, stopki w miejsce pustych pól powinny mieæ wpisane nazwy imiex,naziwskox,dzialx,stanowiskox,emailx
            string html = File.ReadAllText(@"C:\testowy\wzor.html");

            //W tym miejscu bêd¹ warunki na wczytanie konkretnego wzoru stopki
            //dobrze by³oby mieæ je na dysku sieciowym
            if (dzial == "IT Support")
            {
                //string html = File.ReadAllText(@"C:\testowy\wzor.html");
            }


            //Zamiana danych ze wzoru stopki z danymi wpisanymi w formularzu 
            html = html.Replace("imiex", imie);
            html = html.Replace("nazwiskox", nazwisko);
            html = html.Replace("dzialx", dzial);
            html = html.Replace("stanowiskox", stanowisko);
            html = html.Replace("emailx", email_generated);

            //Zapisanie nowej stopki pod wskazany adres 
            File.WriteAllText(@"C:\testowy\MyTest.html", html);











        }
    }
}
