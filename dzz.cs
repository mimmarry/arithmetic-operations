using System;
class Programm
{
    static void Main(string[] args)
    {
        /*1/ 1 способ нахождения периметра квадрата(данная перменная)
         * int a = 5;
         int p = a * 4;
         Console.WriteLine(p);
        1/2 способ нахождения периметра квадрата(вводит значение пользователь)
        Console.WriteLine("Введите значение стороны квадрата");
        float s = Convert.ToSingle(Console.ReadLine());
        if (s > 0)
        {
            float P = s * 4;
            Console.WriteLine("\nПериметр квадрата  = {0} .\n", P);
        }
        else 
        {
            Console.WriteLine("Неверное значение");
        }*/
        /*2 Решить квадратное уравнение с рандомной пермеенной 
        Random random = new Random();
        double x = random.Next(-100, 100);
        double y = 7 * (Math.Pow(x, 2)) + 3 * x + 6;
        Console.WriteLine(y);*/

        /*Задание найти диаметр через окружность
         * int r;
        Console.WriteLine("Найдем значение диаметра окружности");
        Console.WriteLine("Введите значение радиуса окружности");
        string a = Console.ReadLine();
        bool result =  int.TryParse(a, out r);
        if (result == true)
        {
            Console.WriteLine("Диамetер вашей окружности = " + r * 2);
            
        }
        else 
        {
            Console.WriteLine("Введено неправильное значение,try again,please ");
        }*/
        Console.ReadKey();
       

    }
}
