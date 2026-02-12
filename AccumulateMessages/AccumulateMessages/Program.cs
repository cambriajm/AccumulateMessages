namespace AccumulateMessages
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(AccumulateMessage());
            AccumulateMessage();

            //pause
            Console.Read();
        }
    static string AccumulateMessage()
        {
            Console.WriteLine("Enter your message, press q to quit");
            string userInput = "";
            Console.ReadLine();
            return (userInput) ;
        //pause
        Console.Read();
        }
    }
}
