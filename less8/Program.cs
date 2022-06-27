Console.WriteLine("vvedite chislo N= ");
int N = Convert.ToInt32(Console.ReadLine());
string list=" ";
int count=2;
int test= count % 2;
while(count<=N)
{
    if (test==0)
    {
        Console.Write(list + " " + count++);
    }
    count++;
}
