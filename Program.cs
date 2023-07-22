namespace Averagely
{
    class Program
    {
        static void Main()
        {
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

            if(math > 30){
                math = 30;
            }
            else if (math < 0)
            {
                math = 0;
            }
            if(physics > 30){
                physics = 30;
            }
            else if (physics < 0)
            {
                physics = 0;
            }
            if(english > 30){
                english = 30;
            }
            else if (english < 0)
            {
                english = 0;
            }
            if(chemistry > 30){
                chemistry = 30;
            }
            else if (chemistry < 0)
            {
                chemistry = 0;
            }
            if(algebra > 30){
                algebra = 30;
            }
            else if (algebra < 0)
            {
                algebra = 0;
            }


            int ball = math + physics + english + chemistry + algebra ;
            Console.WriteLine($"your total score {ball / 5}");
        }

    }

}




