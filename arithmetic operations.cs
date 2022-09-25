using System;
namespace gg;
class Programm
 {static void Main(string[] args)
    {
        Console.WriteLine("Vvedi chislo");
        int a = Convert.ToInt32(Console.ReadLine());

        int result = a - 48;
        if (result > 48)
        {
            result = (a - 48) * 3;
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine(result);
        }
        Console.ReadLine();

    }

}