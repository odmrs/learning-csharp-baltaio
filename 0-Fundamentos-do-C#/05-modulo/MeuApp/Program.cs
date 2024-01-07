using System;
using System.Diagnostics;
using System.Net.Http.Headers;
using MeuApp.Teste;

namespace MeuApp
{
    // Classe principal do programa
    class Program
    {
        // Função principal do programa
        static void Main(string[] args)
        {
            /* Variaveis
            // Definindo variaveis com tipo e com a palavra reservada var
            // type name = value;
            // int idade = 19;
            // int idade = 19; // Inicializando, tornando o padrão
            // var idade = 19; // Mesma coisa para aqui, vamos focar em colocar os tipos de cada valor
            // var idade; // erro pois var necessita de uma inicialização, define assim que a variavel for iniciada.
            */
            /* Constantes
            const int IDADE_MINIMA = 16;
            */
            /* Tipos Primitivos

            // Byte

            // byte umByte = 127;

            // Inteiros

            // int numInt = -15;
            // uint positivoNum = 15;
            // short shortNum = 32000;
            // ushort ushortNum = 64000;
            // long longNum = 9000000;
            // ulong ulongNum = 9999999999999999;

            //  Números Reais

            // float salario = 2.500f; 
            // decimal salariozao = 2030210.232132m;
            // double salriozin = 2.000;

            // Bool

            // bool usuarioJaCadastrado = true;
            // bool usuariaNãoCadastrada = false;

            // Char

            // char homemOuMulher = 'H';
            // char mulherOuHomem = 'M';

            // String

            // string primeiraLetra = "A";
            // string nomeCompleto = "Marcos Vinícius";

            // Var

            // var idade = 25;

            // Console.WriteLine(idade);

            // int num = 25;
            // float numPonto = 25.6f;
            // // numPonto = num;

            // // int pegandoNum = int.Parse("100"); // Só espera string.

            // // num = (int)numPonto; // Convertendo um float para inteiro.

            // int inteiro = 0;
            // Console.WriteLine(numPonto);
            // Console.WriteLine(numPonto.ToString());
            // // inteiro = int.Parse(numPonto.ToString()); // Estamos transformando o numPonto para string e depois no parse transformando para inteiro. Pórem da erro pois o valor está com um caracter especial.

            */
            /* Operadores Aritméticos e de Atribuição

            // Temos -> + - / *, ordem da matématica! Para mudar, só usar parenteses
            // Console.WriteLine(22 / 4); // Pelo valor ser inteiro, e o resultado é um número real, o resultado será arredondado para cima!

            // Atribuição

            // int x = 5;

            // x += 5; // x será 10, isso funciona para todos os outros operadores aritmeticos

            // Console.WriteLine(x);

            // Comparação

            // Console.WriteLine(5 == 5); // Retorna apenas True ou False

            // Operadores Lógicos

            // bool condicao = (8 == 8) && (8 >= 8); // Retorna sempre um bool
            */
            /* Condicionais

            // If - Else if - Else
            // int idade = 89;

            // if (idade >= 18 && idade < 65)
            // {
            //     Console.WriteLine("Maior de idade");
            // }
            // else if (idade >= 65)
            // {
            //     Console.WriteLine("Idosão");
            // }
            // else
            // {
            //     Console.WriteLine("Menor de idade");
            // }

            // Switch
            string? name = null;
            switch (name)
            {
                case "Marcos": Console.WriteLine("Gostoso"); break;
                case "Bela": Console.WriteLine("Gostosa"); break;
                case null: Console.WriteLine("Digita alguma coisa né amigão"); break;
                default: Console.WriteLine("Saíiiii"); break;
            }

            */
            /* Laços de Repetição: For

            // For

            // for (int i = 5; i >= 0; i--)
            // {
            //     Console.WriteLine(i);
            // }

            // While
            // int value = 0;
            // while (value <= 5)
            // {
            //     Console.WriteLine(value);
            //     value++; // Caso não tenha incremento, vai gerar um loop
            // }

            // Do...While

            // int value = 0;

            // do
            // {
            //     Console.WriteLine(value); // vai executar pelo menos uma vez
            //     value++;
            // } while (value <= 5);
            */
            /* Funções e Métodos

            // Invocando uma função

            // SayName("Marcos");

            // Função com retorno
            // string name = ReturnName("Marcos", "Vinicius");
            // Console.WriteLine(ReturnName("Marcos", "Gostosos"));

            // Value Types e Reference Types

            // Value Types

            // int primeirValor = 10;
            // int segundoValor = primeirValor; // 10

            // primeirValor = 25;
            
            // Console.WriteLine("Primeiro Valor: " + primeirValor);
            // Console.WriteLine("Segundo Valor : " + segundoValor);

            // // Reference types 

            // var arr  = new string[2]; // Crianção de um array
            // arr[0] = "Item 1"; // atribuição ao primeiro index de um array
            // var arr2 = arr; // Não cria um copia, tudo que for alterado no primeiro array, será modificado nesse também

            // Console.WriteLine(arr[0] + " " + arr2[0]);

            // arr[0] = "Novo item";

            // Console.WriteLine(arr[0]  + " " +  arr2[0]);
            */

            // Structs

           // Definição

        //    struct NameProduct{
        //     // Propriedades
        //     public int Id; // Definição de uma propriedade
        //     public float Price;
        //     public string Title;

        //     // Métodos

        //     public float PriceInDolar(float dolar)
        //     {
        //         return Price * dolar;
        //     }
            
            // INtanciação de um tipo criado pela struct // Dentro da classe que irá utilizalo

            // var product = new Product();

            // Preenchimento das propriedades

            // product.Id = 1;
            // product.Title = "Mouse";
            // product.Price = 30.50f;

           }
        }   

        static void SayName(string name)
        {
            Console.WriteLine(name);
        }

        static string ReturnName(
            string first,
            string last,
            int? idade = null
        )
        {
            return first + " " + last;
        }
    }
}
