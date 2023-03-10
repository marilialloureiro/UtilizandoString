using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    //Desenvolva um programa que a entrada seja uma lista de frutas de modo que as frutas
    //devem estar escritas em minusculo e separados por virgula, para cada fruta DIFERENTE
    //na entrada adicione num objeto lista o nome da fruta com o primeiro caracter Maisculo
    //e o restante minusculo, e apos isso utilizando a lista imprima cada uma das strings na lista.

    //OPÇÃO 1 DE RESOLUÇÃO - TESTE
    /* 
     * public static void Main()
     * {
     *     string entrada = "maca,banana,abacaxi";
           string[] itensFrutas = entrada.Split(",");

     List<string> frutas = new List<string>(itensFrutas);

             Console.WriteLine(frutas[0]);
             Console.WriteLine(frutas[1]);
             Console.WriteLine(frutas[2]);
     * 
     * }*/

    public class Exercicio3
    {
        public static void Main()
        {
            //Criando Lista
            List<string> listaFrutas = new List<string>();
            string entrada;
            Console.WriteLine("Entre com a lista conforme solicitado no texto: ");

            //Exemplo entrada: "banana; maça; laranja"
            entrada = Console.ReadLine();

            //Pega Array de palavras separados por ";"
            string[] strArray = entrada.Split(',');

            //Para cada palavra no array
            foreach (string str in strArray)
            {
                //Faz uma copia da string em Lower Case
                string fruta = str.ToLower();

                //Copia a primeira letra da strinf em UpperCase
                string primeiraLetra = fruta.Substring(0, 1).ToUpper();

                //fruta recebe PrimeiraLetra maiuscula e restante minuscula
                fruta = primeiraLetra + fruta.Substring(1, fruta.Length - 1);

                //se a fruta ainda não existir na lista, adiciona
                if (!listaFrutas.Contains(str))
                    listaFrutas.Add(str);

            }
            Console.WriteLine("Resposta: " + Environment.NewLine);
            //Exibir lista de frutas
            foreach (string fruta in listaFrutas)
                Console.WriteLine(fruta);
        }

    }
}


