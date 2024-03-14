using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Insira o primeiro número");
    int num1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Insira o segundo número");
    int num2 = int.Parse(Console.ReadLine());
    
    if ((num1%num2)==0){
        Console.WriteLine($"{num1} é múltiplo de {num2}");
    } else if ((num2%num1)==0) {
        Console.WriteLine($"{num2} é múltiplo de {num1}");
    } else {
        Console.WriteLine("Os números não são múltiplos");
    }
  }
}