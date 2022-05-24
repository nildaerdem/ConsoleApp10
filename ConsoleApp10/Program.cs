namespace ExampleOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            string temp = "";
            string not = "";
            //not start
            do
            {
                temp = Console.ReadLine();
            } while (temp != "start");

            //not write 
            do
            {
                temp = Console.ReadLine();
                if (temp != "stop")
                    not += temp + "\n";

            } while (temp != "stop");

            //not save
            var currentDate = DateTime.Now.ToString("dd.MM.yyyy ");

            not = "Captain’s log\nStardate <" + currentDate + ">\n\n" + not + "\n" + name;

            File.WriteAllText(currentDate + ".txt", not);

            Console.ReadKey();
        }
    }
}