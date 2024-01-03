using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projetos_dotnet_POO.Models
{
    public class Professor : Pessoa //Herança(: Pessoa) 
    {
        public Professor(string nome) : base(nome){ //Manda para o construtor da classe raiz(Pessoa)

        } 
        public decimal Salario { get; set; }

//override --> o metodo pode sobrescrever o metodo da classe raiz(Pessoa) 
//sealed --> o metodo não pode ser sobrescrito em uma classe filha(que herde Professor)
        public sealed override void Apresentar(){ 
            Console.WriteLine($"Ola, meu nome é {Nome} e ganho {Salario:C}");
        }
    }
}