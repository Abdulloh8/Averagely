Console.WriteLine("tick the number of correct answers from 0 to 30");

Console.Write("Math : ");
int math = Convert.ToInt32(Console.ReadLine());

Console.Write("physics : ");
int physics = Convert.ToInt32(Console.ReadLine());

Console.Write("English language : ");
int english = Convert.ToInt32(Console.ReadLine());

Console.Write("chemistry : ");
int chemistry = Convert.ToInt32(Console.ReadLine());

Console.Write("algebra : ");
int algebra = Convert.ToInt32(Console.ReadLine());
int ball = math + physics + english + chemistry + algebra ;
Console.WriteLine($"your total score {ball / 5}");

