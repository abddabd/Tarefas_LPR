using System;
class HelloWorld {
  static void Main() {
      
    int[] nums = new int[10];
    short vezEncont = 0;
    
    for (int i = 0; i <= 9; i++) {
        Console.WriteLine($"Digite o {i + 1}o numero: ");
        nums[i] = int.Parse(Console.ReadLine());
    }
    Console.WriteLine("Digite o valor que deseja encontrar: ");
    int tofind = int.Parse(Console.ReadLine());
    Console.WriteLine($"{tofind} pode ser encontrado na(s) posicao(oes): ");
    for (int i = 0; i <= 9; i++) {
        if (nums[i] == tofind) {
            Console.Write($"{i+1} ");
            vezEncont++;
        }
    }
    if (vezEncont == 0) {
        Console.Write("Nenhuma");
    } else {
        Console.WriteLine($", ele esta presente em {vezEncont} espacos diferentes");
    }
  }
}