namespace AsyncChiefGuest
{
    internal class Async
    {
        static async Task Main(string[] args)
        {
            ChiefGuest();
            Stage();
            Catering_Transport();

            Console.ReadLine(); 
        }

        public static async void ChiefGuest()
        {
            Console.WriteLine("1. Picked chief from airport");
            await Task.Delay(4000);
            Console.WriteLine("5. Chief guest speech reviewed by PA");
            await Task.Delay(3000);
            Console.WriteLine("7. Prize distribution is said to happen");
            await Task.Delay(1000);
            Console.WriteLine("8. Chief Guest speech");
            await Task.Delay(1000);
            Console.WriteLine("9. Prizes distributed");

        }
        public static async void Stage()
        {
            await Task.Delay(1000);
            Console.WriteLine("2. Venue checked for security features!");
            await Task.Delay(5000);
            Console.WriteLine("6. Stage has been decorated");
        }
        public static async void Catering_Transport()
        {
            await Task.Delay(2000);
            Console.WriteLine("3. transport teampicked the food raw materials");
            await Task.Delay(1000);
            Console.WriteLine("4. Catering team started preparing food");
            await Task.Delay(10000);
            Console.WriteLine("10. Food has been provided to all participants");
            
        }

    }
}