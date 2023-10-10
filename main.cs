using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Ecsedi Tamás C# beadandó pótlása");
    //1. feladat
    Console.WriteLine ("Adjon meg egy egész számot: ");
    string szamBekeres = Console.ReadLine();
    int N = Convert.ToInt32(szamBekeres);
    //2. feladat
    int[] Tomb = new int[N];
    //3. feladat
    Random Szamok=new Random();
    for (int i=0;i<10;i++)
    {
      Tomb[N]=Szamok.Next(100);
    }
  }
}