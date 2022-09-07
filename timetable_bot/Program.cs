namespace timetable_bot;

class Program{
    public static void Main(){
        DotEnv.Load(".env");
        
        var token = Environment.GetEnvironmentVariable("TOKEN");

        if(token == null){
            Console.WriteLine("Token not specified. Bot can't start");

            return;
        }
        
        Console.WriteLine(token);
    }
}