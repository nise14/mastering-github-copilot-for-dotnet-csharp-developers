namespace Skills;

public class Members
{
    public string Name { get; set; }
    public string Role { get; set; }
    public int Age { get; set; }

    public Members(string name, string role, int age)
    {
        Name = name;
        Role = role;
        Age = age;
    }
}