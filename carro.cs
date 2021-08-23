using System;
class Carrrro
{
    string marca;
    string modelo;
    string cor;
    int ano;
    string placa;
    
        static void Main(string[] args)
        {
            Carrrro Corsa = new Carrrro();
            Carrrro HB20 = new Carrrro();
            Carrrro Celta = new Carrrro();
            Carrrro Volvo = new Carrrro();
            Corsa.marca = "Chevrolet";
            Corsa.modelo = "Corsa";
            Corsa.cor = "Vermelho";
            Corsa.ano = 2010;
            Corsa.placa = "ABL2342";
            HB20.marca = "Hyundai";
            HB20.modelo = "HB20";
            HB20.cor = "Cinza";
            HB20.ano = 2015;
            HB20.placa = "OMG2089";
            Celta.marca = "Chevrolet";
            Celta.modelo = "Celta";
            Celta.cor = "Azul";
            Celta.ano = 2007;
            Celta.placa = "LLK7689";
            Volvo.marca = "Volvo";
            Volvo.modelo = "Volvo";
            Volvo.cor = "Laranja";
            Volvo.ano = 2019;
            Volvo.placa = "OU2999";
            Console.WriteLine("O carro que tem a cor {0} é o {1} ", Celta.cor, Celta.modelo);
            Console.WriteLine("O carro que tem a placa {0} é o {1} ", Volvo.placa, Volvo.modelo);
            Console.WriteLine("O carro que tem a cor {0} é o mesmo que tem a placa ", HB20.cor, HB20.placa);


        }
    }