Console.WriteLine("введите число");
int num1 = Convert.ToInt32(Console.ReadLine());

int count = 1;
if(num1<=99)
{
    Console.WriteLine("третьей цифры нет");

}
else
{

while(num1>1000)
{
    num1 = num1 / 10;
    count++;
    
}
num1 = num1 % 10;
Console.WriteLine($"третье число это - {num1}");
}
