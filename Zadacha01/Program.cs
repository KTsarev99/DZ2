Console.WriteLine("введите трёхзначное число");
int num1 = Convert.ToInt32(Console.ReadLine());

if(num1>=100 && num1<1000)
{
num1 = num1 /10 ;

num1 = num1 % 10 ;

Console.WriteLine(num1);
}
else
{
Console.WriteLine("введите трёхзначное число");
}