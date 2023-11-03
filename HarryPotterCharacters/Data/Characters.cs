namespace HarryPotterCharacters.Data;

public class Character
{
    public required string Name { get; set; }
    public required string PortrayedBy { get; set; }
    public string? House { get; set; }
}

public static class Characters
{
    public static IEnumerable<Character> GetCharacters()
    {
        yield return new Character
        {
            Name = "Harry Potter",
            PortrayedBy = "Daniel Radcliffe",
            House = "Gryffindor"
        };
        yield return new Character
        {
            Name = "Hermione Granger",
            PortrayedBy = "Emma Watson",
            House = "Gryffindor"
        };
        yield return new Character
        {
            Name = "Ron Weasley",
            PortrayedBy = "Rupert Grint",
            House = "Gryffindor"
        };
        yield return new Character
        {
            Name = "Draco Malfoy",
            PortrayedBy = "Tom Felton",
            House = "Slytherin"
        };
    }
}