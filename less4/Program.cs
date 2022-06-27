Console.WriteLine("number 1= ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("number 2= ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("number 3= ");
int c = Convert.ToInt32(Console.ReadLine());
if(a>b && a>c)
{
    Console.WriteLine("Number 1 -> max");
}
else
{
    if(b>c)
    {
        Console.WriteLine("Number 2 -> max");
    }
    else
    {
        Console.WriteLine("Number 3 -> max");
    }
}