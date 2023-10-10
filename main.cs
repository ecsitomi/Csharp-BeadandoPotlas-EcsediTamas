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
    //5. feladat
    Console.WriteLine("Adjon meg 5 db szót");
    string[] Szavak = new string[5];
    for (int i=0;i<5;i++)
    {
      Szavak[i]=Console.ReadLine();
    }
    Console.WriteLine("Legrövidebb szó");
    string Legrovidebb = Szavak[0];
    for (int i=0;i<5;i++)
    {
      if (Legrovidebb.Length>Szavak[i].Length)
        Legrovidebb=Szavak[i];
    }
    Console.WriteLine(Legrovidebb);
    Console.WriteLine("Leghosszabb szó");
    string Leghosszabb = Szavak[0];
    for (int i=0;i<5;i++)
    {
      if (Leghosszabb.Length<Szavak[0].Length)
        Leghosszabb=Szavak[i];
    }
    Console.WriteLine(Leghosszabb);
    Console.WriteLine("Egyforma szavak");
    bool VanE = false;
    for (int i=0;i<5;i++)
    {
      for (int j=i+1;j<5;j++)
      {
        if (Szavak[i]==Szavak[j])
          Console.WriteLine(Szavak[i]);
          VanE = true;
      }
    }
    if (VanE==false)
      Console.WriteLine("Nincsenek egyforma szavak.");
    //6. feladat
    Console.WriteLine("a/b + c/d");
    Console.WriteLine("a:");
    string tortA = Console.ReadLine();
    int A = Convert.ToInt32(tortA);
    Console.WriteLine("b:");
    string tortB = Console.ReadLine();
    int B = Convert.ToInt32(tortB);
    Console.WriteLine("c:");
    string tortC = Console.ReadLine();
    int C = Convert.ToInt32(tortC);
    Console.WriteLine("D:");
    string tortD = Console.ReadLine();
    int D = Convert.ToInt32(tortD);
    int ujA = A*D;
    int ujBD = B*D;
    int ujC = C*B;
    int eredmenyFent = ujA+ujC;
    Console.WriteLine($"A tört = {eredmenyFent}/{ujBD}");
    double eredmeny = eredmenyFent/ujBD;
    Console.WriteLine($"Vagyis: {eredmeny}");
    //Nincs kisebb nevezőre hozva a tört
    
    
    
    
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