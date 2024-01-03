using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projetos_dotnet_POO.Models
{
    public sealed class Aluno : Pessoa  //Herança(: Pessoa) sealed --> classe selada(uma classe não pode herdar de Professor) 
    {
        public Aluno(string nome) : base(nome){

        }
        public double Nota { get; set; }

        public override void Apresentar(){ //override --> o metodo pode sobrescrever o metodo da classe raiz(Pessoa)
            Console.WriteLine($"Ola, meu nome é {Nome} e minha nota é {Nota}");
        }
    }
}