using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projetos_dotnet_POO.Models
{
    public abstract class Conta //Classe abstrata --> tem que ser herdada, e não usada diretamente
    {
        protected decimal saldo; //protected --> pode ser alterado pelas classes filhas

        public abstract void Creditar(decimal valor);//Obriga a implementar esse metodo nas classes filhas

        public void ExibirSaldo(){
            Console.WriteLine($"O seu saldo é {saldo:C}");
        }
    }
}