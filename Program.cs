using Projetos_dotnet_POO.Models;
using Projetos_dotnet_POO.Interfaces;

ICalculadora calc = new Calculadora();
Console.WriteLine(calc.Multiplicar(3,4));



// Aluno aluno = new Aluno("Eduardo");
// aluno.Apresentar();

// Corrente c = new Corrente();
// c.Creditar(500);
// c.ExibirSaldo();



// Notas: Polimorfismo em tempo de compilação: metodos com mesmo nome, 
//        mas qtdade de parametros diferentes
//        Polimorfismo em tempo de execução: Herança 


// Aluno aluno = new Aluno();
// aluno.Nome = "Paulo";
// aluno.Idade = 23;
// aluno.Nota = 9.6;
// aluno.Apresentar();

// Professor professor = new Professor();
// professor.Nome = "Buta";
// professor.Idade = 30;
// professor.Salario = 1280.90M;
// professor.Apresentar();







// ContaCorrente conta1 = new ContaCorrente(123,100);
// conta1.Sacar(56);
// conta1.ExibirSaldo();




// Pessoa p1 = new Pessoa();
// p1.Nome = "Paulo";
// p1.Idade = 23;

// p1.Apresentar();