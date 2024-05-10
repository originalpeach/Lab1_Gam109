using lab_3_thinh;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Program
{
    public static int Main(string[] args)
    {
        Calculator calculator = new Calculator(3, 7);
        int resultCong = calculator.Cong();
        Console.WriteLine("Cong: " + resultCong);
        System.Console.ReadKey();
        return 0;
    }
}
