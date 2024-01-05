using System;
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
            // Tipos Primitivos

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
            float numPonto = 25.6f;
            // numPonto = num;

            // int pegandoNum = int.Parse("100"); // Só espera string.

            // num = (int)numPonto; // Convertendo um float para inteiro.

            int inteiro = 0;
            Console.WriteLine(numPonto);
            Console.WriteLine(numPonto.ToString());
            // inteiro = int.Parse(numPonto.ToString()); // Estamos transformando o numPonto para string e depois no parse transformando para inteiro. Pórem da erro pois o valor está com um caracter especial.


        }
    }
}
