using CommandDotNet;
using ConsoleTables;

namespace HarryPotterCharacters
{
    internal static class ConsoleExtensions
    {
        internal static void WriteTable<T>(this IConsole console, IEnumerable<T> values)
        {
            var table = ConsoleTable.From(values);
            console.Write(table);
        }
    }
}