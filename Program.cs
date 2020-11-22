using System;

namespace Funcoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício sobre médias utilizando função (método)");//exibição da mensagem
            Console.WriteLine("-------------------------------------------------");

            //arrays criado para armazenar os dados dos alunos
            string[] nomes = new string [10];
            float[] nota1 = new float [10];
            float[] nota2 = new float [10];
            float[] nota3 = new float [10];
            float[] nota4 = new float [10];
            float[] medias = new float [10];

            int aprovados = 0; //variável para receber número de aprovados 
            int reprovados = 0; //variável para receber número de reprovados    

            float mediaGeral = 0; //variável para receber média geral da sala
            float soma = 0; //variável para receber a soma das médias dos alunos
                    
            for (var contador = 0; contador <10; contador++) //Estrutura de repetição do tipo for
            {
                Console.Write("Digite o nome do aluno: ");//exibição da mensagem
                nomes[contador] = Console.ReadLine();//entrada e armazenamento dos nomes 

                Console.Write("Digite a nota 1: ");//exibição da mensagem
                nota1[contador] = float.Parse(Console.ReadLine());//entrada e armazenamento da nota 1 

                Console.Write("Digite a nota 2: ");//exibição da mensagem
                nota2[contador] = float.Parse(Console.ReadLine());//entrada e armazenamento da nota 2

                Console.Write("Digite a nota 3: ");//exibição da mensagem
                nota3[contador] = float.Parse(Console.ReadLine());//entrada e armazenamento da nota 3

                Console.Write("Digite a nota 4: ");//exibição da mensagem
                nota4[contador] = float.Parse(Console.ReadLine());//entrada e armazenamento da nota 4

                
                medias[contador] = (nota1[contador] + nota2[contador] + nota3[contador] + nota4[contador])/4;//detalhar como é o cálculo da média de cada aluno
                Console.WriteLine("A média do aluno é: "+medias[contador]);//exibição da mensagem

                if(medias[contador] >=7) //condicional if (se a média for maior ou igual a 7,então: )
                {
                    Console.ForegroundColor = ConsoleColor.Blue;//mudança de cor na linha abaixo                   
                    Console.WriteLine($"{nomes[contador]} está APROVADO !");//exibição da mensagem
                    Console.ResetColor();//fechamento da mudança de cor da linha acima
                    aprovados = aprovados+1;//armazenar a quantidade de aprovados na variável "aprovados" , ler um a um
                
                  

                }
                else{ // se a condição acima(if) não for verdadeira , então: 
                    Console.ForegroundColor = ConsoleColor.Red;//mudança de cor na linha abaixo                  
                    Console.WriteLine($"{nomes[contador]} está REPROVADO !");//exibição da mensagem
                    Console.ResetColor();//fechamento da mudança de cor da linha acima
                    reprovados = reprovados+1;//armazenar a quantidade de aprovados na variável "aprovados", ler um a um
                }
                
                
            }
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Total de alunos aprovados: "+aprovados);//exibição da mensagem
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Total de alunos reprovados: "+reprovados);//exibição da mensagem
                Console.WriteLine("-------------------------------------");

                for (var i = 0; i < 10; i++)//estrutura de repetição do tipo for
                {
                    soma += medias[i]; // soma = total de medias 
                }

                mediaGeral = soma/10; // média geral é igual a soma dividido por 10
                Console.WriteLine("Média geral da sala: "+mediaGeral);//exibição da mensagem
                
        }

    }

}

    // 1 - Faça um programa que receba o nome e quatro notas de 10 alunos e armazene essas notas em vetores. Calcule e mostre:
	// A. A Média do aluno
	// B. A quantidade de Aprovados (Média >=7)
	// C. A quantidade de Reprovados (Méida < 7)
	// D. A Média geral dos 10 alunos.