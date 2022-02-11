using System;

namespace testealura
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double valorInvestido = 1000;
            int totalMeses;
            

            Console.WriteLine("Quantos meses de investimento você quer saber ?");
            totalMeses = Convert.ToInt32(Console.ReadLine());


            for (int cont = 1; cont <= totalMeses; cont ++ )
                {
               
                valorInvestido = valorInvestido + valorInvestido * 0.0036;
                Console.WriteLine("Após " + cont + " , você tera : R$ " + valorInvestido);
                  
                }





            
        }
    }
}
