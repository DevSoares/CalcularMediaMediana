using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularMediaMediana
{
    class Program
    {
        private static float CalcularMedia(List<float> list)
        {
            float fTemp = 0;
            foreach (float s in list)
            {
                fTemp = fTemp + s;
            }
            fTemp = fTemp / list.Count;
            return fTemp;
        }

        private static void ValorConceito(float valor)
        {
            if (valor >= 9.0)
            {
                Console.WriteLine("Conceito A");
            }
            if(valor>=7.5 && valor < 9.0){
                Console.WriteLine("Conceito B");
            }
            if(valor >= 6.0 && valor < 7.5)
            {
                Console.WriteLine("Conceito C");
            }
            if (valor >= 4.0 && valor < 6.0)
            {
                Console.WriteLine("Conceito D");
            }
            if (valor < 4.0)
            {
                Console.WriteLine("Conceito E");
            }
        }

        private static void CalcularMediana(List<float> list)
        {
            float fTemp = 0;
            int medTemp = 0, medTempB = 0;
            list.Sort();
            if (list.Count % 2 == 1) {
                medTemp = list.Count;
                medTemp = medTemp/ 2;
                if (list.Count > 3) {
                    medTemp = medTemp;
                    Console.WriteLine(value: "Mediana = " + list[medTemp]);
                }
                if (list.Count == 3)
                {
                    Console.WriteLine("Entrou no equal 3");
                    Console.WriteLine("Mediana = " + list[1]);
                }                               
            }
            else
            {
                medTemp = list.Count;
                medTemp = medTemp / 2;
                medTempB = medTemp - 1;

                if (list.Count == 2)
                {
                    fTemp = list[0] + list[1];
                    fTemp = fTemp / 2;
                    Console.WriteLine(value: "Mediana = " + fTemp);
                }
                else
                {
                    fTemp = list[medTemp] + list[medTempB];
                    fTemp = fTemp / 2;
                    Console.WriteLine(value: "Mediana = " + fTemp);
                }                
            }         
        }

        static void Main(string[] args)
        {
            List<float> valores = new List<float>();
            string trava = "a", trava2 = "a";
            float valor;
            while (trava2 != "s")
            { 
                while (trava != "n")
                {
                Console.WriteLine("insira um valor na lista");
                valor = float.Parse(Console.ReadLine());
                valores.Add(valor);
                Console.WriteLine("Continuar ?");
                trava = Console.ReadLine();
                }

                Console.WriteLine("Média = " + CalcularMedia(valores));
                CalcularMediana(valores);
                ValorConceito(CalcularMedia(valores));
                Console.WriteLine("Sair ?");
                trava2 = Console.ReadLine();
            }
        }
    }
}
