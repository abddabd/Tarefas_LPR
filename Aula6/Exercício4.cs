/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
    Console.Write("Digite um número: ");
    
            int numero = int.Parse(Console.ReadLine());
            int quadrado = numero * numero;
            int soma = 0;
            
            while (quadrado > 0)
            {
                soma += quadrado % 10;
                quadrado = quadrado / 10;
            }

            Console.WriteLine($"A soma dos dígitos de {numero * numero} é {soma}");
  }
}