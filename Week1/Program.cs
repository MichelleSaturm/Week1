using System;

namespace Week1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Variabili

            int age;
            age = 20;

            int n = 30;

            //Costanti
            const int m = 50;
            //const int f; //errore!!

            //Dichiarare Variabili consecutivamente sulla stessa linea
            int var1 = 1, var2 = 2, var3 = 3;

            //Tipo
            //age = "20" //Errore!! Non posso mettere una stringa su valore intero!
            string a = "30";
            int b = 20;
            //int s = a + b; //ERRORE!

            //String name = "Michela"; //usare alias string in minuscolo

            //Value Type
            //Interi
            byte c; // rappresentare numeri tra 0 e 255
            short d; // 16 bit
            int i; // 32 bit
            long l; //64 bit

            //Numeri a virgola mobile
            float f; // circa 6-9 cifre. suffisso f o F
            double pi = 3.14159265358; //pi greco. circa 15-17 cifre. suffisso d o D
            decimal dec = 123.456m; //circa 27-29 cifre
            decimal dec2 = 123.456M; //suffisso m o M per decimal
            decimal dec3 = 3_000.45m; //la _ sta per 3000

            //Booleani: true/false
            bool isSunny = true;
            bool isRed; //falso

            //Caratteri
            //occupa 16 bit -> UTF-16
            char character = 'A';
            Console.WriteLine(character); //come output avremo A

            char character2 = 'B';

            int characterSum = character + character2;
            Console.WriteLine(characterSum); //come output avremo un numero. perché i caratteri sono numeri

            character.GetHashCode(); //la A corrisponde a 65
            character2.GetHashCode(); //la B è 66. per questo la somma era 131

            //Leggere un chat inserito da un utente
            char ins;

            //Console.WriteLine("Per continuare premi Y");
            //ins = Console.ReadKey().KeyChar;

            //Console.WriteLine("okay! Hai scelto di continuare!");

            Console.WriteLine("Inserisci un carattere!");
            ins = Console.ReadKey().KeyChar;
            Console.WriteLine($"Hai scelto {ins}"); //con il dollaro posso inserire ins tra le graffe

            //Altri value types
            //DateTime -> Rappresenta un istante. Ed è un astratto.
            DateTime date = new DateTime(2020, 6, 4);
            DateTime now = DateTime.Now;

            Console.WriteLine(now);

            DateTime today = DateTime.Today;
            Console.WriteLine(today);

            //Enumerazioni
            GenderEnum w = GenderEnum.Female;
            Console.WriteLine(w);

            //Reference Type
            //Stringa
            string city = "Roma";

            //escape sequences
            //string color = "Color: ""Yellow""; //ERRORE
            string color = "\"yellow\"";
            Console.WriteLine($"Color: \t{color}"); //tabulazione. mantiene le colonne sempre della stessa grandezza



            //Object

        }
        enum GenderEnum
        {
            Male, //se non specifico niente il suo valore numerico è 0, Female sarà 1 e NotDeclared 2
            Female,
            NotDeclared

            // Male = 2, //qui sto dichiarando dei valori
            // Female = 4,
            // NotDeclared = 0
        }
    }
}
