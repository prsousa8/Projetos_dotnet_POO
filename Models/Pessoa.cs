using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projetos_dotnet_POO.Models
{
    public class Pessoa
    {
        public Pessoa(string nome){
            Nome = nome;
        }
        public string Nome { get; set; }
        public int Idade { get; set; }

        public virtual void Apresentar(){ //virtual --> Esse metodo pode ser sobrescrito
            Console.WriteLine($"Olá, meu nome é {Nome}");
        }
    }
}