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
    for (int i=0;i<N;i++)
    {
      Tomb[N]=Szamok.Next(101);
    }
    //4. feladat
    Console.WriteLine("Páros számok");
    foreach (var szam in Tomb)
    {
      if (szam%2==0)
        Console.WriteLine(szam);
    }
    Console.WriteLine("Páratlan számok");
    foreach (var szam in Tomb)
    {
      if (szam%2!=0)
        Console.WriteLine(szam);
    }
    Console.WriteLine("Prím számok");
    foreach (var szam in Tomb)
    {
      if (IsPrime(szam))
        Console.WriteLine(szam);
    }
    Console.WriteLine("Átlag");
    int Osszeg=0;
    foreach (var szam in Tomb)
    {
      Osszeg+=szam;
    }
    double Atlag = Osszeg / N;
    Console.WriteLine(Atlag);
    Console.WriteLine("Legkisebb szám");
    int Legkisebb = 100;
    foreach (var szam in Tomb)
    {
      if (szam<Legkisebb)
        Legkisebb=szam;
    }
    Console.WriteLine(Legkisebb);
    Console.WriteLine("Legnagyobb szám");
    int Legnagyobb=0;
    foreach (var szam in Tomb)
    {
      if (szam<Legnagyobb)
        Legnagyobb=szam;
    }
    Console.WriteLine(Legnagyobb);
  }

  //Prím szám kereső metódus
  //Loptam :(
  static bool IsPrime(int number) {
    if (number < 2) return false;
    if (number == 2) return true;
    if (number % 2 == 0) return false;

    for (int i = 3; i <= Math.Sqrt(number); i += 2) {
      if (number % i == 0) return false;
    }
    return true;
  }
}