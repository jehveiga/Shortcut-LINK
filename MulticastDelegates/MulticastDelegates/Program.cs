// See https://aka.ms/new-console-template for more information

using MulticastDelegates.Services;

delegate void BinaryNumericOperation(double n1, double n2);

class Program
{
    static void Main(string[] args)
    {
        double a = 10;
        double b = 12;
        BinaryNumericOperation op = CalculationServices.ShowSum;
        op += CalculationServices.ShowMax;

        op(a, b);
    }


}


