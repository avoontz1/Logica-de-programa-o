using System;

namespace Logica_de_programa_o
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aqui vai o código do nosso programa
            // C# é uma linguagem case sensitive ->

            //Declaramos a variavel
            float nota1, nota2, nota3, media;
            string nomeCompleto:

            //Entrada de dados
            Console.WriteLine("Dígite o nome do aluno")
            nomeCompleto = Console.ReadLine();

            Console.Write("Dígite a primeira nota: ");
            nota1 = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Dígite o segundo valor: ");
            nota2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Dígite a terceira nota: ");
            nota3 = float.Parse(Console.ReadLine());

            //Processamento
            media = (nota1+nota2+nota3)/3:

            //Exibir o resultado
            if(media>5){
                //Valor verdadeira
                Console.WriteLine("O Aluno "+nomeCompleto+" está aprovado com a média de: "+media);
            }else{
                //Valor Falso
                Console.WriteLine("O Aluno "+nomeCompleto+" está REPROVADO com a média de: "+media);
            }
            
            

        }
    }
}
