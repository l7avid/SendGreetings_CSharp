namespace ChallengeMethods
{
    internal class Program
    {
        static void SendGreetings(string name)
        {
            Console.WriteLine($"Hello {name}, I love you!");
        }
        static void Main(string[] args)
        {
            string daugther = "Majo";
            string wife = "Lina";
            string husband = "David";
            SendGreetings(daugther);
            SendGreetings(wife);
            SendGreetings(husband);
        }
    }
}