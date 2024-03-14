using System.Net.NetworkInformation;

public class KodeBuah
{
    public enum Buah
    {
        Apel,
        Aprikot,
        Alpukat,
        Pisang,
        Paprika,
        Blackberry,
        Ceri,
        Kelapa,
        Jagung,
        Kurma,
        Durian,
        Anggur,
        Melon,
        Semangka
    }

    public static string GetKodeBuah(Buah buah)
    {
        string[] KodeSetiapBuah = { "A00", "B00", "C00", "D00", "E00", "F00", "H00", "I00", "J00", "K00", "L00", "M00", "N00", "O00" };

        return KodeSetiapBuah[(int)buah];
    }

    public static void Main(string[] args)
    {
        Buah buah1 = Buah.Apel;
        Console.WriteLine("Buah " + buah1 + " dengan Kode Buah " + GetKodeBuah(buah1));
        Buah buah2 = Buah.Aprikot;
        Console.WriteLine("Buah " + buah2 + " dengan Kode Buah " + GetKodeBuah(buah2));
        Buah buah3 = Buah.Alpukat;
        Console.WriteLine("Buah " + buah3 + " dengan Kode Buah " + GetKodeBuah(buah3));
        Buah buah4 = Buah.Pisang;
        Console.WriteLine("Buah " + buah4 + " dengan Kode Buah " + GetKodeBuah(buah4));
        Buah buah5 = Buah.Paprika;
        Console.WriteLine("Buah " + buah5 + " dengan Kode Buah " + GetKodeBuah(buah5));
        Buah buah6 = Buah.Blackberry;
        Console.WriteLine("Buah " + buah6 + " dengan Kode Buah " + GetKodeBuah(buah6));
        Buah buah7 = Buah.Ceri;
        Console.WriteLine("Buah " + buah7 + " dengan Kode Buah " + GetKodeBuah(buah7));
        Buah buah8 = Buah.Kelapa;
        Console.WriteLine("Buah " + buah8 + " dengan Kode Buah " + GetKodeBuah(buah8));
        Buah buah9 = Buah.Jagung;
        Console.WriteLine("Buah " + buah9 + " dengan Kode Buah " + GetKodeBuah(buah9));
        Buah buah10 = Buah.Kurma;
        Console.WriteLine("Buah " + buah10 + " dengan Kode Buah " + GetKodeBuah(buah10));
        Buah buah11 = Buah.Durian;
        Console.WriteLine("Buah " + buah11 + " dengan Kode Buah " + GetKodeBuah(buah11));
        Buah buah12 = Buah.Anggur;
        Console.WriteLine("Buah " + buah12 + " dengan Kode Buah " + GetKodeBuah(buah12));
        Buah buah13 = Buah.Melon;
        Console.WriteLine("Buah " + buah13 + " dengan Kode Buah " + GetKodeBuah(buah13));
        Buah buah14 = Buah.Semangka;
        Console.WriteLine("Buah " + buah14 + " dengan Kode Buah " + GetKodeBuah(buah14));
    }
}

