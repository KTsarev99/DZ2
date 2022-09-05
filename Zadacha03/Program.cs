Console.WriteLine("введите число, обозначающее номер дня недели");
int num1 = Convert.ToInt32(Console.ReadLine());
    
if(num1<=5 && num1>0)
{
    Console.WriteLine("нет");
}
else if(num1>5  && num1<=7 )
{
    Console.WriteLine("да");
}
