namespace Averagely
{
    class Program
    {
        static void Main()
        {
            try
            {
                while(true)
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
                    Console.WriteLine("Enter any character to continue");
                    Console.WriteLine("enter 1 to finish");
                    string finish = Console.ReadLine();
                    if(finish == "1")
                    {
                        break;
                    }

                }
                

            }
            catch(FormatException FormatException)
            {
                Console.WriteLine("this value is invalid");
            }
            catch(OverflowException OverflowException)
            {
                Console.WriteLine("this value does not match ");
            }
            catch(Exception exception)
            {
                Console.WriteLine("there is an error in the program");
            }
            
        }
    }
}




