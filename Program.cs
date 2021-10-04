using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    enum Brands
    {
        Maseratti,
        Opel,
        Holdan,
        VW,
        Rimac,
    }

    class Species
    {
        private float _atlagfogysz;
        private int _tankmerete;
        private int _aktualbenzmennyiseg;
        private string _Brand;
        private string _matrinya;
        private string _rndszm;
    }

    public float atlagf
    {
        get => _weight; set
        {
            if (value < 3F) throw new Exception("Error! : Átlag Fogyasztás nem elég magas!");
            if (value < 20F) throw new Exception("Error! : Átlag Fogyasztás nem elég Alacsony!");
        }
    }

    public int Tankmeret
    {
        get; =>  set
        {
            if (value < 20F) throw new Exception("Error! : Nem elég nagy a tank,nem fér bele ennyi. ");
            if (value < 20F) throw new Exception("Error! : Túl kevés nagy a Tank,tölts bele többet,még elfér. ");
        }
    }
}
public int aktualbenzmenniseg
{
    get; set
    {
        if (value < 0F) throw new Exception("Error! : Túl kevés a benzin a kúton!");
        if (value < 0F) throw new Exception("Error! : Túl sok a benzin a kúton!");
    }
}
public string Matrinya;
    {
        if (value< true)
    }



class Program
{
    static void Main(string[] args)
    {
        static List<autok> to = new List<autok>();
        static void Main()
        {
            Randomaut();
            LegtKM();
            Legtaut();
        }
        public Aut(float atlagfogyasztas, int tankmerete, int aktbenya, string matrinya, string rndszm,);
        {
            Tankmeret = tankmerete;
            Atlagf = atlagfogyasztas;
            Aktbenzin = aktualisbenzinmennyiseg;
            Brand = marka;
            Matrinya = matrica;
            rndszm = rendszam;
        }

        public static void LegtKM
    {
        int legtKM = 0;
    for (int i = 1; i<O.Count; i++)
			{
        if (O[i].Aktualbenzmennyiseg && O[tl].
        for (int j = 0; j<i; j++)
        if(tomb[j]> tomb[j + 1])
			{
        int tmb = tomb[j];
    tomb[j] = tomb[j + 1];
        tomb[j + 1] = tmb;
			}
legt = i;

    Console.WriteLine($"A legtöbb Km et megtet {LegtKM}. index} :{O[legtKM].Marka}");

    static Random rnd = new Random();


       }
    }
 }

private static void Autok();
{
for (int i = 0; i< 30 ; i++)
			{
    O.Add(new Autok
             (Marka: rnd.Next(1, 5) / 2F,
                    : rnd.Next(401),
                    Atlagf: rnd.Next(10, 401),
                    Autok: rnd.Next(100) < 10,
      


        }
    }
}