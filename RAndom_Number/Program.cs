

Random rnd = new Random();

int myRandomNum;

int sum = 0;

for (int i = 0; i < 10; i++)
{
   myRandomNum = rnd.Next(0, 100); // 0 - 10

    Console.WriteLine($"My random Number is: {myRandomNum}");
    sum = sum + myRandomNum;
}

Console.WriteLine($"Total = {sum}");
