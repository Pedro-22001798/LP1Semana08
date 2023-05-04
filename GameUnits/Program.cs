namespace GameUnits
{
    public class Program
    {
        private static void Main()
        {
            Unit settlerUnit = new SettlerUnit();
            Unit militaryUnit = new MilitaryUnit();

            settlerUnit.Move();
            militaryUnit.Move();

            Console.WriteLine($"SettlerUnit Health = {settlerUnit.Health}, Cost = {settlerUnit.Cost} and Moves = {settlerUnit.Move()}");
            Console.WriteLine($"MilitaryUnit Health = {militaryUnit.Health}, Cost = {militaryUnit.Cost} and Moves = {militaryUnit.Move()}");

        }
    }
}