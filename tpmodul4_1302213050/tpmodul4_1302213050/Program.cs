
using System;

public class KodePos
{
    private static readonly System.Collections.Generic.Dictionary<string, string> kodePosTable = new System.Collections.Generic.Dictionary<string, string>() {
        { "Batununggal", "40266" },
        { "A. Kujangsari", "40287" },
        { "Mengger", "40267" },
        { "Wates", "40256" },
        { "Cijaura", "40287" },
        { "Jatisari", "40286" },
        { "Margasari", "40286" },
        { "Sekejati", "40286" },
        { "Kebonwaru", "40272" },
        { "Maleer", "40274" },
        { "Samoja", "40273" }
    };

    public static string GetKodePos(string kelurahan)
    {
        if (kodePosTable.ContainsKey(kelurahan))
        {
            return kodePosTable[kelurahan];
        }
        return "Kode Pos tidak ditemukan.";
    }
}

class Program
{
    static void Main(string[] args)
    {
        string kodePos = KodePos.GetKodePos("Wates");
        Console.WriteLine(kodePos);

        kodePos = KodePos.GetKodePos("Samoja");
        Console.WriteLine(kodePos);

        kodePos = KodePos.GetKodePos("Bandung");
        Console.WriteLine(kodePos);
    }
}