using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pagal pirkinių sąrašą pasirinkite norimus pirkinius. Paspauskite pirkinio numerį ir spauskite ENTER:\n" +
                "Pirkinių sąrašas: \n" +
                "1. Duona;\n" +
                "2. Pienas;\n" +
                "3. Dešra;\n" +
                "4. Sviestas;\n" +
                "5. Varškė;\n" +
                "6. Kiaušiniai;\n" +
                "7. Alus;\n" +
                "8. Irasykite savo: \n" +
                "9. Pabaigti sąrašą ir apskaičiuoti: \n");
            double pirk = 0;
            double pirk2 = 0;
            double pirk3 = 0;
            double pirk4 = 0;
            double pirk5 = 0;
            double pirk6 = 0;
            double pirk7 = 0;
            double pirk8 = 0;
            string vari = "";
            string vari2 = "";
            string vari3 = "";
            string vari4 = "";
            string vari5 = "";
            string vari6 = "";
            string vari7 = "";
            string vari8 = "";
            for (int i = 0; i <= 55; i++)
            {
                Console.WriteLine("Pasirinkite pirkini: ");
                var pasirinkimas = Convert.ToInt32(Console.ReadLine());
                if (pasirinkimas == 1)
                {
                    vari = "Douna, ";
                    pirk = 1.2;
                }
                if (pasirinkimas == 2)
                {
                    vari2 = "Pienas, ";
                    pirk2 = 1.5;
                }
                if (pasirinkimas == 3)
                {
                    vari3 = "Dešra, ";
                    pirk3 = 4.2;
                }
                if (pasirinkimas == 4)
                {
                    vari4 = "Sviestas, ";
                    pirk4 = 0.9;
                }
                if (pasirinkimas == 5)
                {
                    vari5 = "Varškė, ";
                    pirk5 = 0.4;
                }
                if (pasirinkimas == 6)
                {
                    vari6 = "Kiaušiniai, ";
                    pirk6 = 1.0;
                }
                if (pasirinkimas == 7)
                {
                    vari7 = "Alus, ";
                    pirk7 = 1.8;
                }
                if (pasirinkimas == 8)
                {
                    Console.WriteLine("Įrašykite produkto pavadinima: ");
                    vari8 = Console.ReadLine();
                    Console.WriteLine("Įrašykite produkto kainą: ");
                    pirk8 = Convert.ToDouble(Console.ReadLine());
                }
                if (pasirinkimas == 9)
                {
                    i = 55;
                }
                if (pasirinkimas > 9 || pasirinkimas < 1)
                {
                    Console.WriteLine("Tokio produkto nėra, įveskite tinkamą pasirinkimą arba spauskite 8 ir patys įrašykite.");
                }

            }
            Console.WriteLine();
            double sum = pirk + pirk2 + pirk3 + pirk4 + pirk5 + pirk6 + pirk7 + pirk8;
            String variantai = vari + vari2 + vari3 + vari4 + vari5 + vari6 + vari7 + vari8;
            Console.WriteLine("Jūs pasirinkote " + variantai);
            Console.WriteLine("Jūsų pirkiniai jums kainuos: " + sum);
        }
    }
}
