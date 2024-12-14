using Delegates;

class Program
{
    public static void OnCarEngineEvent(string msg)
    {
        Console.WriteLine("\n Message From Car Object ");
        Console.WriteLine("=> {0}", msg);
        Console.WriteLine("*************************\n");
    }
    static void Main(string[] args)
    { // Cтворимо об'єкт Car
        Car c1 = new Car("SlugBug", 100, 10);
        c1.RegisterWithCarEngine(
        new Car.CarEngineHandler(OnCarEngineEvent));
        // Викличемо метод Accelerate (це ініціює події). 
        Console.WriteLine("***** Speeding up *****");
        for (int i = 0; i < 6; i++)
            c1.Accelerate(20);
    }
}