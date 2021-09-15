using System;

namespace Soma2Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*________*");
            Console.WriteLine(@"Bem Vindo!
Esse programa exibe a soma de dois números inteiros à sua escolha.");
           
           Console.Write("Digite o primeiro número para continuar: ");
           string Numero1EmString = Console.ReadLine();
           
           Console.Write("Digite o segundo número para exibir o resultado da soma: ");
           string Numero2EmString = Console.ReadLine();
           
           double Numero1EmInt = Convert.ToDouble(Numero1EmString);
           double Numero2EmInt = Convert.ToDouble(Numero2EmString);
           double ResultadoSoma = (int)Numero1EmInt + (int)Numero2EmInt;
           
           Console.WriteLine($"Resultado: {ResultadoSoma}");
           
           /*Incrementando o exercício,
           caso não seja necessário, por favor desconsiderem */
           Console.ForegroundColor = ConsoleColor.Red;
           Console.Write("AGORA");
           Console.ResetColor();       
           Console.WriteLine(", se você desejar, somarei dois números decimais à sua escolha!");
           Console.Write("Caso queira continuar tecle \"Enter\", caso queira encerrar digite \"sair\": ");  
            
            for(;;)
            {
                string linha = Console.ReadLine();
                
                if((linha.ToUpper() == "SAIR"))
                
                    break;
                    
                    else
                    {
           Console.Write("Digite o primeiro número decimal: ");
           String Numero3EmString = Console.ReadLine();
           
           Console.Write("Digite o segundo número decimal para exibir o resultado da soma: ");
           string Numero4EmString = Console.ReadLine();
           
           double N1Double = Convert.ToDouble(Numero3EmString);
           double N2Double = Convert.ToDouble(Numero4EmString);
           double ResultadoSomaDouble = N1Double + N2Double;
           
           Console.WriteLine($"Resultado: {ResultadoSomaDouble}");
           Console.WriteLine("Obrigado pela sua colaboração!");
           break;
                    }
        }
    }
}
}
