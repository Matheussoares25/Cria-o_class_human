using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matheus_2ds
{
    internal class Pessoa
    {
        public double peso;
        public double altura;
        public double imc;

        public void pedirpeso()// crio metodos para ser puxado pelo program
        {
            Console.WriteLine("Informe seu peso");
            peso = double.Parse(Console.ReadLine());
        }

        public void pediraltura()
        {
            Console.WriteLine("infome sua altura");
            altura = double.Parse(Console.ReadLine());
        }

        public void inaltpes()
        {
            Console.WriteLine("seu peso é {0}", peso);
            Console.WriteLine("e sua altura é {0}",altura);
        }

        public void calculadora()
        {
            imc = peso / (altura * altura);
            Console.WriteLine("{0}", imc);
        }

        public void mostraimc()
        {
            if (imc < 18.5)
            {
                Console.WriteLine("Magreza");

            }
            else if (imc >= 18.5 && imc <= 24.9)
            {
                Console.WriteLine("normal");
            }
            else if (imc >= 25 && imc <= 29.9)
            {
                Console.WriteLine("Sobrepeso");
            }
            else if (imc >= 30 && imc <= 34.9)
            {
                Console.WriteLine("Obesidade |");
            }
            else if (imc >= 35 && imc <= 39.9)
            {
                Console.WriteLine("Obesidade ||");
            }
            else if (imc >= 40)
            {
                Console.WriteLine("Obesidade |||");
            }
        }
    }
}
