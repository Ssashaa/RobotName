namespace RobotName;

public class RobotNameGenerator
{
    private static readonly HashSet<string> UsedNames = new();

    public string GenerateName()
    {
        string NewName()
        {
            string guid = Guid.NewGuid().ToString();
            return string
                .Join("", guid.Where(x => Char.IsLetter(x)).Take(2)
                .Concat(guid.Where(x => Char.IsDigit(x)).Take(3)))
                .ToUpper();
        }
        while (true)
        {
            var name = NewName();
            if (UsedNames.Add(name))
            {
                return name;
            }
        }
    }
}
