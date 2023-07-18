Console.WriteLine("tick the number of correct answers from 0 to 30");
firt:
Console.Write("Math : ");
int math = Convert.ToInt32(Console.ReadLine());
if(!(math >= 0 && math <=30))
{
   goto firt;
}
second:
Console.Write("physics : ");
int physics = Convert.ToInt32(Console.ReadLine());
if(!(physics >= 0 && physics <=30))
{
   goto second;
}
third:
Console.Write("English language : ");
int english = Convert.ToInt32(Console.ReadLine());
if(!(english >= 0 && english <=30))
{
   goto third;
}
fourth:
Console.Write("chemistry : ");
int chemistry = Convert.ToInt32(Console.ReadLine());
if(!(chemistry >= 0 && chemistry <=30))
{
   goto fourth;
}
fifth:
Console.Write("algebra : ");
int algebra = Convert.ToInt32(Console.ReadLine());
if(!(algebra >= 0 && algebra <=30))
{
   goto fifth;
}
Console.WriteLine($"your total score {math + physics + english + chemistry + algebra}");

