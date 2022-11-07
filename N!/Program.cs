int ProdFromTo(int arg1)
{
    int prod = 1;
    
    for(int i = 1; i<=Math.Abs(arg1); i++)
    {
        prod = prod * i;
    }
    return prod; 
}

Console.WriteLine("This program assepts number and show product of numbers between 1 and your number");
Console.Write("Enter your number: ");
int number = Convert.ToInt32(Console.ReadLine());

int product = ProdFromTo(number);
Console.WriteLine(product);

///
