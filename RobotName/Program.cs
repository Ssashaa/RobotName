namespace RobotName;

public class Program
{
    public static void Main()
    {
        RobotNameGenerator robotNameGenerator = new ();
        RobotFactory robotFactory = new(robotNameGenerator);

        var robots = Enumerable
            .Range(0, 10)
            .Select(_ => robotFactory.CreateNewRobot())
            .ToList();

        Console.ReadLine(); 
    }
}
