using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterTypes
{
    class Program
    {
        static void Main(string[] args)
        {

            // Valuetyp:"Operations on one variable will NOT affect the value on the other variable.
            int i = 0;
            SimplemMethod(i);
            Console.WriteLine("Värdet utan ref: "+ i);
            Console.ReadLine();

            //RefTyp: "Operations on one variable will affect the value on the other variable
            RefSimplemMethod(ref i);
            Console.WriteLine("Värdet med ref: " + i);
            Console.ReadLine();

            // OutParameter
            int total= 0;
            int product = 0;
            CalculateOut(10, 20, out total, out product);
            Console.WriteLine("Summan är {0} och produkten är {1}",total, product);
            Console.ReadLine();

            // Params
        }
        // Valuetyp:"Operations on one variable will NOT affect the value on the other variable.
        public static void SimplemMethod(int j)
        {
            j = 101;
        }
       
        //RefTyp: "Operations on one variable will affect the value on the other variable
        public static void RefSimplemMethod(ref int j)
        {
            j = 101;
        }
        
        // OutParameter: Samma metod returnerar behandlar två utparametrar. Notera "Void". 
        public static void CalculateOut(int firstNumber, int lastNumber, out int sum, out int product)
        {
            sum = firstNumber + lastNumber;
            product = firstNumber * lastNumber;
        }

        // Params
        public static void ParamsMethod(int [] numbers)
        {
            Console.WriteLine("Det finns {0} i arrayen");
        }

    }
}
