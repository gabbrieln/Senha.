using System;
public class creatingPassword{
    public int password;
    public int createdPassword;
    public void open(bool a){
        a = false;
    }
    public creatingPassword(){
        password = 0;
    }
}
public class Running{
    static void Main(){
        creatingPassword a = new creatingPassword();
        Console.WriteLine("Type the password that you want to create.");
        a.createdPassword = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Great! Your password was created");
        Console.WriteLine("Now, to open, type the password that you created");
        a.password = Convert.ToInt32(Console.ReadLine());
        while(a.createdPassword != a.password){
            Console.WriteLine("Unable password, try again.");
            a.password = Convert.ToInt32(Console.ReadLine());
            a.open(false);
            
            if (a.createdPassword != a.password){
            i++;
            if(i == 5 ){
                Console.WriteLine("Be careful, you can block the device if you keep trying many time.");
                }
            }
        }
        if(a.password == a.createdPassword){
            Console.WriteLine("Vault opened!");
            a.open(true);
        }
    }
}
