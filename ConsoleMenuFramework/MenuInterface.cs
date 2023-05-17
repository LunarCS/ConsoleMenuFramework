using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMenuFramework
{
    public interface IConsoleMenu
    {
        ConsoleColor TextColor { get; set; }
        ConsoleColor BackgroundColor { get; set; }
        string ConsolePrompt { get; set; }
        string LineSeperator { get; set; }
        string Column { get; set; }
        string Header { get; set; }
        string Footer { get; set; }
        void AddMenuToStack();
        IConsoleMenu GetPreviousMenu();
        void PrintMenu();
    }

    public interface IAction
    {
        void Invoke();
    }
}
