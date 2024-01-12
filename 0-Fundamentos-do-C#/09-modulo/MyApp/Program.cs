using System;
using System.Text;
using System.Xml;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /* GUIDS
            var id = Guid.NewGuid();
            // Transformando um GUID em string
            id.ToString();
            Console.WriteLine(id);

            // Criando um GUID valido:
            id = new Guid("5870700f-4a47-488d-983d-79c346e4f56a"); // Caso não coloque um GUID valido e deixe vazio, será um hash zerado 000000000-0000....
            Console.WriteLine(id);
            */

            /* Interpolação de String 

            var price = 10.2;
            // var text = "O preço é " + price + " só na promoção"; // Transforma price em string, e conecta as demais strings

            // var text = string.Format("O preço é {0} só na promoção", price);

            var text = $@"O preço é {price} só na promoção, e estou ignorando comandos passados pelo usuario \n \s...."; // @ para ignorar comandos
            */

            /*Comparação de Strings 
            var text = "Testando";
            Console.WriteLine(text.CompareTo("Testando")); // Retorna 0 para True e 1 Para false
            Console.WriteLine(text.Contains("estando"));

            // Para ignorar o Case Sensitivy
            Console.WriteLine(text.Contains("Testando", StringComparison.OrdinalIgnoreCase));
            // Console.WriteLine(text.Contains(null)); // Retorna erro, comparação com objeto destintos
            */

            /* Comparação começo e no fim 

            var text = "Este texto é para teste";

            Console.WriteLine(text.StartsWith("Este tex"));
            Console.WriteLine(text.StartsWith("este"));
            Console.WriteLine(text.StartsWith("EsTe", StringComparison.OrdinalIgnoreCase));

            Console.WriteLine(text.EndsWith("teste"));
            Console.WriteLine(text.EndsWith("Teste"));
            Console.WriteLine(text.EndsWith("TeStE", StringComparison.OrdinalIgnoreCase));
            */

            /* Equals -> Serve para a maioria dos objetos
            var text = "Este texto é para teste";
            Console.WriteLine(text.Equals("Este texto é para teste"));
            Console.WriteLine(text.Equals("este texto é para teste"));
            Console.WriteLine(text.Equals("Este tExto é para teste", StringComparison.OrdinalIgnoreCase));

            Console.WriteLine(20.Equals(20));
            Console.WriteLine(123.32.Equals(123.32));
            */

            /* Indices 
            
            Console.WriteLine(text.IndexOf('e'));
            Console.WriteLine(text.LastIndexOf('e'));
            */

            /* Métodos Adicionais 

            var text = "Este texto é para teste";

            Console.WriteLine(text.ToLower());
            Console.WriteLine(text.ToUpper());
            Console.WriteLine(text.Insert(0, "Será que "));
            Console.WriteLine(text.Remove(0, 5));
            Console.WriteLine(text.Replace("Este", "Iss&"));
            Console.WriteLine(text.Length);
            */

            /*Manupulação de Strings
            var text = "  Este texto é para teste  ";
            var divisao = text.Split();

            Console.WriteLine(divisao[0]); // Separa toda string em pedaços separados pelo parametro
            Console.WriteLine(text.Substring(5, 5)); // começa no index 5 e pega os 5 proximos caracteres

            var removingSpaces = text.Trim();
            */

            /*StringBUilder*/
            var text = new StringBuilder();

            text.Append("TExto dawkodkwaodkoad" + Environment.NewLine);
            text.Append("TExto dawkodkwaodkoad" + Environment.NewLine);
            text.Append("TExto dawkodkwaodkoad" + Environment.NewLine);

            Console.WriteLine(text);



        }
    }
}