using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace feladat3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Írja be hogy hány számot akar bekérni! ");
            string nstr = Console.ReadLine();
            int n;
            if (!int.TryParse(nstr, out n))
            {
                Console.WriteLine("Hibás adat!");
                return;
            }
            int[] tomb = new int[n];
            Console.Write("írjon be " + n + " számot! ");
            for (int i = 0; i < n; i++)
            {
                tomb[i] = int.Parse(Console.ReadLine());
            }
            int maxin = 0;
            int minin = 0;
            for (int i = 0; i < n; i++)
            {
                if (tomb[maxin] < tomb[i])
                {
                    maxin = i;
                }
                else
                {
                    minin = i;
                }
            }
            Console.WriteLine("Legnagyobb beírt szám: " + tomb[maxin].ToString());
            Console.WriteLine("Legkissebb beírt szám: " + tomb[minin].ToString());
            Console.ReadKey();
        }
    }
}
