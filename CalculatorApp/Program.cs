namespace CalculatorApp;
public class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }
    public int Subtract (int a, int b)
    {
        return a - b;
    }
    public int Multiply (int a, int b)
    {   
        return a * b;
    }
    public int Divide (int a, int b)
    {
        if (b == 0) //nếu b = 0 thì ném ra ngoại lệ
        {
            throw new DivideByZeroException("bố mày thích lỗi"); 
        }
        return a / b;
    }
    public int Modulus (int a, int b)
    {
        return a % b;
    }
}

class Program
{
    static void Main()
    {
        // Calculator calc = new Calculator();
        // Console.WriteLine("Addition: " + calc.Add(10, 5));
        // Console.WriteLine("Subtraction: " + calc.Subtract(10, 5));
        // Console.WriteLine("Multiplication: " + calc.Multiply(10, 5));
        // Console.WriteLine("Division: " + calc.Divide(10, 5));
        // Console.WriteLine("Modulus: " + calc.Modulus(10, 5));
    }
}