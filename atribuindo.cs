using System;
class Pessoa1{
    static void Main(){
        int idade = 0;
        int qtdanos = 0;
        int ano = 2021;
        Console.WriteLine("Digite sua idade");
        idade = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Sua idade ano que vem será {0}", idade + 1);
        Console.WriteLine("Agora me diga daqui quantos anos você quer saber sua idade");
        qtdanos = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Sua idade daqui {0} anos será {1} no ano de {2}", qtdanos, idade + qtdanos, qtdanos  ano);
    }
}
