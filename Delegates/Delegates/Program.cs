// See https://aka.ms/new-console-template for more information
using Delegates.Services;

delegate double BinaryNumericOperation(double n1, double n2); // Delegate

class Program
{
    static void Main(string[] args)
    {
        double a = 10;
        double b = 12;
        // BinaryNumericOperation op = CalculationService.Sum;
        BinaryNumericOperation op = CalculationServices.Sum;
        // double result = op(a, b); // Chamando espressão delegate
        double result = op.Invoke(a, b);
        Console.WriteLine(result);
    }
}