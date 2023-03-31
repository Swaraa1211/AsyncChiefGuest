namespace AsyncChiefGuest
{
    internal class Async
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("BIG EVENT IS GONNA START !!!");
            ChiefGuest();
            Stage();
            Catering_Transport();
            await Task.Delay(10000);
            Console.WriteLine("END OF THE EVENT !!!");
            Console.ReadLine(); 
        }

        public static async void ChiefGuest()
        {
            Console.WriteLine("1. Picked chief from airport\nChief Guest is on the way\n ");
            await Task.Delay(4000);
            Console.WriteLine("5. Chief guest speech reviewed by PA\nDone Right\n ");
            await Task.Delay(3000);
            Console.WriteLine("7. Prize distribution is said to happen\nArragements have been done accordingly\n ");
            await Task.Delay(1000);
            Console.WriteLine("8. Chief Guest speech\nAttention Here!!\n ");
            await Task.Delay(1000);
            Console.WriteLine("9. Prizes distributed\nCongrats!!\n ");

        }
        public static async void Stage()
        {
            await Task.Delay(1000);
            Console.WriteLine("2. Venue checked for security features!\nMic Testing Check Check!!\n ");
            await Task.Delay(5000);
            Console.WriteLine("6. Stage has been decorated\nPerfect Stage for the EVE\n ");
        }
        public static async void Catering_Transport()
        {
            await Task.Delay(2000);
            Console.WriteLine("3. Transport teampicked the food raw materials\nDropped Right\n ");
            await Task.Delay(1000);
            Console.WriteLine("4. Catering team started preparing food\nBusy Bees are on Work\n ");
            await Task.Delay(6000);
            Console.WriteLine("10. Food has been provided to all participants\nSuccess;-)\n ");
            
        }

    }
}