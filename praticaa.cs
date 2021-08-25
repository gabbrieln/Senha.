using System;
// class OP{
//     static void Main(){
//         int idade = 0;
//         int qtdanos = 0;
//         int ano = 2021;
//         Console.WriteLine("Digite sua idade");
//         idade = Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine("Sua idade ano que vem será {0}", idade + 1);
//         Console.WriteLine("Agora me diga daqui quantos anos você quer saber sua idade");
//         qtdanos = Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine("Sua idade daqui {0} anos será {1} no ano de {2}", qtdanos, idade + qtdanos, qtdanos + ano);
//     }
//}
// class wa{
//     static void Main(){
//         string a = "";
//         Console.WriteLine("Digite seu nome");
//         a = Console.ReadLine();
//         Console.WriteLine("Todos menos o primeiro caractere {0}", a.Substring(1));
//         Console.WriteLine("Os três primeiros caracteres {0}", a.Substring(0, 3));
//         Console.WriteLine("Os três últimos {0}", a.Substring(a.Length - 3, 3));
//         Console.WriteLine("Apenas o último {0}", a.Substring(a.Length - 1, 1));
//         Console.WriteLine("Apenas o terceiro elemento {0}", a.Substring(2, 1));
//     }
class Exxecution{
    static void Main(){
        int a, b, c;
        Console.WriteLine("Digite um número");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite outro número");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Agora me diga o que você quer fazer com esses números");
        Console.WriteLine("1 - Verificar se o primeiro número é maior do que o segundo");
        Console.WriteLine("2 - Verificar se o segundo número é maior do que o primeiro");
        Console.WriteLine("3 - Verificar se os dois números são iguais");
        c = Convert.ToInt32(Console.ReadLine());
        switch (c){
            case 1:
            if (a > b){
                Console.WriteLine("O primeiro número é maior do que o segundo");
            }else{
                Console.WriteLine("O primeiro número não é maior do que o segundo");
            }break;
            case 2:
            if (b > a){
                Console.WriteLine("O segundo número é maior do que o primeiro");
            }else{
                Console.WriteLine("O segundo número não é amor do que o primeiro");
            }break;
            case 3:
            if (a == b){
                Console.WriteLine("Os números são iguais");
            }else{
                Console.WriteLine("Os números NÃO são iguais");
            }break;
            default:
            Console.WriteLine("Opção inválida");
            break;
        }
    }
}