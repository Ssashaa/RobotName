namespace RobotName;

public class RobotFactory
{
    private readonly RobotNameGenerator _robotNameGenerator;
    public RobotFactory(RobotNameGenerator robotNameGenerator)
    {
        _robotNameGenerator = robotNameGenerator;
    }

    public Robot CreateNewRobot()
    {
        return new Robot(_robotNameGenerator.GenerateName());
    }

    public Robot MaintenanceRobot(Robot robot)
    {
        return robot with { Name = _robotNameGenerator.GenerateName() };
    }
}
