using System;
class Execution{
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
