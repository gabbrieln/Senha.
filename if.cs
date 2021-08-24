using System;
class Classificacao{
    static void Main(){
        double idade = 0;
        Console.WriteLine("Digite sua idade");
        idade = Convert.ToDouble(Console.ReadLine());
        if (idade >= 3 && idade < 12){
            Console.WriteLine("Que interessante, você é uma criança!");
        }else if (idade == 12 || idade == 13){
            Console.WriteLine("Uau, você é um pré-adolescente, que legal!");
        }else if (idade >= 14 && idade <= 19){
            Console.Write("Você já é um adolescente, meus parabéns");
        }else if (idade >= 20 && idade <= 55){
            Console.WriteLine("Você já é um adulto, meus parabéns!");
        }else if(idade > 55){
            Console.WriteLine("Você já é um idoso, meus parabéns!");
        }else{
            Console.WriteLine("Por favor, insira um número maior ou igual a 3");
        }
    }
}