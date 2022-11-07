Console.WriteLine("This program count quantity of digits in number.");
Console.Write("Enter your number: ");
int number = Convert.ToInt32(Console.ReadLine());
string strNumber = Math.Abs(number).ToString();
Console.WriteLine(strNumber.Length);

