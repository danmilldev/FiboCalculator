Console.WriteLine("How much Fibo Numbers do you wish?");
Console.Write("Amount: ");

int amount = Convert.ToInt32(Console.ReadLine());

List<int> fiboList = new List<int> { 0, 1, 1 };

for (int i = 2; i < amount; i++)
{
    fiboList.Add(fiboList[i] + fiboList[i - 1]);
}

Console.WriteLine("Fibo Numbers:");

foreach (var fibo in fiboList)
{
    Console.WriteLine(fibo);
}
