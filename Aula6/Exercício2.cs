/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
            Random numAleatorio = new Random();
            int valorInteiro = numAleatorio.Next(1, 101);

            int tentativas = 0;
            int chute;

            do
            {
                Console.Write("Digite um número de 1 a 100: ");
                chute = int.Parse(Console.ReadLine());
                tentativas++;

                if (chute < valorInteiro)
                {
                    Console.WriteLine("chutou baixo");
                }
                else if (chute > valorInteiro)
                {
                    Console.WriteLine("chutou alto");
                }
                else
                {
                    Console.WriteLine($"Acertou \r\nForam necessárias {tentativas} tentativas.");
                }
            } while (chute != valorInteiro);
  }
}