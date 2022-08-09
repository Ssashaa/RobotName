namespace RobotName;

public class RobotNameGenerator
{
    private static readonly HashSet<string> UsedNames = new();

    public string GenerateName()
    {
        string NewName()
        {
            Guid guid = Guid.NewGuid();
            var letters = guid.ToString().Where(x => Char.IsLetter(x)).Take(2);
            var numbers = guid.ToString().Where(x => Char.IsDigit(x)).Take(3);

            return String.Join("", letters.Concat(numbers)).ToUpper();
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
