using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Insira um número");
    int num = int.Parse(Console.ReadLine());
    if ((num % 2) == 0) {
        Console.WriteLine("O número é par");
    } else {
        Console.WriteLine("O número é ímpar");
    }
  }
}