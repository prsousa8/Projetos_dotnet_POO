using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projetos_dotnet_POO.Models
{
    public class ContaCorrente
    {

        public ContaCorrente(int numeroConta, decimal saldoInicial){
            NumeroConta = numeroConta;
            saldo = saldoInicial;
        }
        public int NumeroConta { get; set; }

        private decimal saldo; //Encapsulamento

        public void Sacar(decimal valor){
            if(saldo >= valor){
             saldo-=valor;
             Console.WriteLine("Saque efetuado com sucesso.");
            }else{
                Console.WriteLine("Saldo insuficiente.");
            }
        }

        public void ExibirSaldo(){
            Console.WriteLine($"Seu saldo é {saldo:C}");
        }
    }
}