using System;
using System.ComponentModel.Design;

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

public class DoorMachine
{
    enum State { Terkunci, Terbuka, Keluar};
    public void Door()
    {
        State state = State.Terkunci;
        String[] status = { "Terkunci", "Tebuka", "Keluar" };
        while (state != State.Keluar)
        {
            Console.WriteLine("\n" + "Pintu " + status[(int)state] + "\n");
            Console.WriteLine("Masukkan perintah (ketik 'Keluar' untuk kembali ke menu) : ");
            String command = Console.ReadLine();

            switch (state)
            {
                case State.Terkunci:
                    if (command == "Terbuka")
                    {
                        state = State.Terbuka;
                    }
                    else if(command == "Keluar")
                    {
                        Program.Main();
                    }
                    break;
                case State.Terbuka:
                    if (command == "Terkunci")
                    {
                        state = State.Terkunci;
                    }
                    else if(command == "Keluar")
                    {
                        Program.Main();
                    }
                    break;
            }   
        }
    }
}

public class Program
{
    public static void Main()
    {
        Console.WriteLine("1. Program kodepos");
        Console.WriteLine("2. Program Door Machine");
        Console.WriteLine("0. Exit");
        Console.Write("Masukkan pilihan Anda: ");

        String masuk = Console.ReadLine();
        while (masuk != "0")
        {
            if (masuk == "1")
            {
                KodePos kode = new KodePos();
                Console.Write("Masukkan nama Kelurahan (ketik 'Kembali' untuk balik ke menu) : ");
                string Kelurahan = Console.ReadLine() ?? "";

                if (Kelurahan != "Kembali")
                {
                    string Kode = KodePos.getKodepos(Kelurahan);
                    Console.WriteLine($"Kodepos {Kelurahan} : {Kode}");
                }
                else
                {
                    Main();
                }
            }
            else if(masuk == "2")
            {
                DoorMachine door = new DoorMachine();
                door.Door();
            }
            else if(masuk == "0")
            {
                break;
            }
        }
    }
}
