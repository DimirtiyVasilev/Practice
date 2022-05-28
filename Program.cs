class Program
{
    static double IshFunc(double x)
    {

       // return (Math.Cos(x+7))/Math.Pow(x,3);
       return Math.Sqrt(Math.Pow(x, 3)+7)/Math.Pow(x,2);
    }
    static double LeftTreg(double up,double down,double h)
    {
        double resh = 0;
        double ud = Math.Round(up - down, 2);
        double n = Math.Ceiling(ud / h);
        double per = ud / n;
        for (double i=down;i<up;i+=h)
        {
            resh+=IshFunc(i);
        }
    }
    static double RightTreg(double up, double down, double h)
    {
        double resh = 0;
        double ud = Math.Round(up - down, 2);
        double n = Math.Ceiling(ud / h);
        double per = ud / n;
        for (double i = down+h; i <= up; i += h)
        {
            resh += IshFunc(i);
        }
        return resh * per;
    }
    static double CenterTreg(double up, double down)
    {
        double c = (up + down) / 2;
        double h1 = up - down;
        double promezh=IshFunc(c);
        return h1 * promezh;
    }
    static double Trapec(double up, double down, double h)
    {
        double resh = 0;
        double ud = Math.Round(up - down, 2);
        double n = Math.Ceiling(ud / h);
        double per = ud / n;
        for (double i = down+h; i < up; i += h)
        {
            resh += IshFunc(i);
        }
        return per*(((IshFunc(down) + IshFunc(up)) / 2) + resh);
    }
    static void Main(string[] args)
    {
        double up=2.0;
        double down=0.2;
        double h = 0.3;
        double leftt = LeftTreg(up, down, h);
        double rightt = RightTreg(up, down, h);
        double centert = CenterTreg(up, down);
        double trapect = Trapec(up, down, h);
        Console.WriteLine("Левый прямоугольник:" + leftt);
        Console.WriteLine("Правый прямоугольник:" + rightt);
        Console.WriteLine("Средние прямоугольники:" + centert);
        Console.WriteLine("Трапеция:" + trapect);
    }
}