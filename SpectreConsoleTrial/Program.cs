using System;
using Spectre.Console;

namespace SpectreConsoleTrial
{
    class Program
    {
        static void Main(string[] args)
        {
            AnsiConsole.MarkupLine("[underline red]Hello[/] World!");
            AnsiConsole.MarkupLine("[underline green]Hello[/] ");
            AnsiConsole.MarkupLine("[bold]World[/]");
            AnsiConsole.Markup("Hello :globe_showing_europe_africa:!");
            AnsiConsole.Markup("[red]Foo[/] ");
            AnsiConsole.Markup("[#ff0000]Bar[/] ");
            AnsiConsole.Markup("[rgb(255,0,0)]Baz[/] ");
        }
    }
}
