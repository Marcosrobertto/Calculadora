using System;

namespace CalculadoraSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            // Perguntar a operação
            Console.WriteLine("Qual a operação deseja realizar? \n Soma, Subtracao, Multiplicacao, Divisao");
            string operacao = Console.ReadLine().ToLower();

            // Pedir o 1° número
            Console.WriteLine("Digite o 1° número");
            float num1 = float.Parse(Console.ReadLine());

            // Pedir o 2° número
            Console.WriteLine("Digite o 2° número");
            float num2 = float.Parse(Console.ReadLine());

            // Fazer o cálculo
            // f = sufixo do float
            float resultado = 0;

            // if(operacao == "Soma"){
            //     resultado = num1 + num2;
            // }
            // else if(operacao == "Subtracao"){
            //     resultado = num1 - num2;
            // }
            // else if(operacao == "Multiplicao"){
            //     resultado = num1 * num2;
            // }
            // else if(operacao == "Divisao"){
            //     resultado = num1 / num2;
            // }
            // else{
            //     Console.WriteLine("Operação inválida");
            // }


            switch(operacao){

                case "soma":
                    resultado = num1 + num2;
                    break;
                case "subtracao":
                    resultado = num1 - num2;
                    break;
                case "multiplicacao":
                    resultado = num1 * num2;
                    break;
                case "divisao":
                    resultado = num1 / num2;
                    break;        
                default:
                    operacao = "invalida";
                    Console.WriteLine("Operação inválida! :( ");
                    break;
            
            }

            // Mostrar o resultado
            if(operacao != "invalida")
                Console.WriteLine($"Calculo : {num1} com {num2} = {resultado} ");
            // Concatenação
            // Console.WriteLine("Console : "+ num1 +" com "+ num2 +" = "+ resultado);

            // Interpolação
            


        }
    }
}
