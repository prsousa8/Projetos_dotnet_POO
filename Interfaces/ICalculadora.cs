using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projetos_dotnet_POO.Interfaces
{
    public interface ICalculadora
    {
        //Implementação obrigatoria nas classes filhas
        int Somar(int num1, int num2); 
        int Subtrair(int num1, int num2);
        int Multiplicar(int num1, int num2);
        //Implementação não obrigatoria nas classes filhas
        int Dividir(int num1, int num2){
            return num1 / num2;
        }
    }
}