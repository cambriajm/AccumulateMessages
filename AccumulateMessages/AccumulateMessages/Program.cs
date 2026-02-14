namespace AccumulateMessages
//Cambria Morgan
//RCET 2265
//Spring 2026
//AccumulateMessage
//https://github.com/cambriajm/ConvertAndValidate.git
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your message, " +
                "press q to quit and see your list");

                string userInput = "";
                string list = "";
                string message = list + userInput;
            do
            {
                userInput = Console.ReadLine();
                if(true)
                {
                    if(userInput == null)
                        {
                        
                        Console.WriteLine(userInput);
                         
                        }
                    else
                        {
                        list = list + "\n" + userInput;
                        
                        }
                    message = list;
                    

                }
                 
                Console.WriteLine(message);
                
            } while (userInput != "Q" && userInput != "q");

            Console.Clear();
            Console.WriteLine($"The list of messages: \n{message}");
            Console.WriteLine("Woah. ByeBye.");
            //pause
            Console.Read();
        }
    }
}
