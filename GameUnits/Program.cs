namespace GameUnits
{
    public class Program
    {
        private static void Main()
        {
            Unit newUnit = new SettlerUnit();
            Console.WriteLine($"{newUnit.Health} , {newUnit.Move()}, {newUnit.Cost}");
        }
    }
}