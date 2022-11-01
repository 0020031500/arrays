int num = 0;
string food = "";
string[] foods = new string[5];

while (num < 5)
{
    Console.WriteLine("Enter a food");
    food = Console.ReadLine();
    foods[num] = food;
    num++;
    Console.Clear();
}

Console.Clear();

Console.WriteLine("_______________________________");
Console.WriteLine("Foods:");
for (int i = 0; i < foods.Length; i++)
{
    string foodName = foods[i];
    int foodNum = i + 1;
    Console.WriteLine("| " + foodNum + ". " + foodName + " |");
}
Console.WriteLine("_______________________________");

Console.WriteLine("Enter a number  to find a food");
string input = Console.ReadLine();
while (input != "exit")
{
    int index = int.Parse(input);
    if (index > 5) Console.WriteLine("Invalid number");
    else Console.WriteLine(foods[index-1]);
    Console.WriteLine("Enter a number to find a food");
    input = Console.ReadLine();
}
