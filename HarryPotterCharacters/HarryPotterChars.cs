using CommandDotNet;
using System.Linq;
using CommandDotNet.Rendering;
using HarryPotterCharacters.Data;

namespace HarryPotterCharacters;

public class HarryPotterChars
{
    [Subcommand]
    public Films Films { get; set; }

    [Command(Description = "Lists the individual wizards")]
    public void Wizards(IConsole console, string house = "")
    {
        var characters = Characters.GetCharacters()
            .Where(wizard => wizard.House.Contains(house));
        console.WriteTable(characters);
    }
}