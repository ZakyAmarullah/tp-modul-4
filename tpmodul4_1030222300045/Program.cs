using System;

public class KodePos
{
    public static string getKodepos(string daerah)
    {
        string[,] dataKodepos =
        {
            {"Batununggal", "40266"},
            {"Kujangsari", "40287"},
            {"Mengger", "40267"},
            {"Wates", "40256"},
            {"Cijaura", "40287"},
            {"Jatisari", "40286"},
            {"Margasari", "40286"},
            {"Sekejati", "40286"},
            {"Kebonwaru", "40272"},
            {"Maleer", "40274"},
            {"Samoja", "40273"}
        };

        for (int i = 0; i < dataKodepos.GetLength(0); i++)
        {
            if (dataKodepos[i, 0].Equals(daerah, StringComparison.OrdinalIgnoreCase))
            {
                return dataKodepos[i, 1];
            };
        };
        return "Kodepos tidak ditemukan";
    }
};
