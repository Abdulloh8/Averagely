namespace Averagely
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("tick the number of correct answers from 0 to 5");

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

            int ball = (math + physics + english + chemistry + algebra) / 5;
            //Console.WriteLine($"your total score {ball / 5}");

            string resualt = ball switch
            {
                1 => "your resualt very bad",
                2 => "your resualt very bad",
                3 => "your resualt  bad",
                4 => "your resualt good",
                5 => "your resualt very good",
                _ => "Error resualt"
            };

            Console.WriteLine(resualt); 
        }
    }
}




