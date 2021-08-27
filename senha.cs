using System;
public class CriandoSenha{
    public int senha;
    public int senhaCriada;
    public void aberto(bool a){
        a = false;
    }
    public CriandoSenha(){
        senha = 0;
    }
}
public class Running{
    static void Main(){
        CriandoSenha a = new CriandoSenha();
        Console.WriteLine("Digite a senha que queira criar.");
        a.senhaCriada = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ótimo! Senha Criada!");
        Console.WriteLine("Agora, para abrir, digite a senha criada");
        a.senha = Convert.ToInt32(Console.ReadLine());
        while(a.senhaCriada != a.senha){
            Console.WriteLine("Senha inválida, tente novamente.");
            a.senha = Convert.ToInt32(Console.ReadLine());
            a.aberto(false);
            
            if (a.senhaCriada != a.senha){
            i++;
            if(i == 5 ){
                Console.WriteLine("Cuidado, você pode bloquear seu telefone caso tente mais vezes");
                }
            }
        }
        if(a.senha == a.senhaCriada){
            Console.WriteLine("Cofre aberto!");
            a.aberto(true);
        }
    }
}
