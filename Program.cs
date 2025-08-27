using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matheus_2ds
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            Pessoa atleta;
            atleta=new Pessoa();
            atleta.pedirpeso(); //aciono o metudo que criei em pessoa (classe)
            atleta.pediraltura();
            atleta.inaltpes();
            atleta.calculadora();
            atleta.mostraimc();
            
           
        }
    }
}
