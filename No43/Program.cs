// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5) 
// k1*x + b1 = k2*x + b2
// x(k1-k2) = b2 - b1
// x = (b2-b1)/(k1-k2)

int GetNumber (string msg)
{
    while(true)
    {
        Console.WriteLine(msg);
        string ValueFromConsole = Console.ReadLine();
        if(int.TryParse(ValueFromConsole, out int number))
        {
            return number;
        }
        else 
        {
         Console.WriteLine("Вы ввели не число. Попробуйте еще раз!");
        }
    }
}

double GetX(double k1, double k2, double b1, double b2)
{
    double x = (b2-b1)/(k1-k2);
    return x;
}

double GetY(double k1, double b1, double X)
{
    double y = k1*X + b1;
    return y;
}

string messagek1 = "Введите угловой коэффициент k1 первой прямой: ";
string messagek2 = "Введите угловой коэффициент k2 второй прямой: ";
string messageb1 = "Введите коэффициент b1 первой прямой: ";
string messageb2 = "Введите коэффициент b2 второй прямой: ";

double k1 = GetNumber(messagek1);
double k2 = GetNumber(messagek2);
double b1 = GetNumber(messageb1);
double b2 = GetNumber(messageb2);

Console.WriteLine($"b1 = {b1}, b2 = {b2}, k1 = {k1}, k2 = {k2}");
double X = GetX(k1, k2, b1, b2);
double Y = GetY(k1, b1, X);

Console.WriteLine($"Точка пересечения прямых А({X};{Y})");
