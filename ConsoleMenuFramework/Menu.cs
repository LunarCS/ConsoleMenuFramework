using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMenuFramework
{
    public class ChoiceMenu : IConsoleMenu
    {
        Dictionary<string, Action> _optionMenu = new Dictionary<string, Action>();
        string _consolePrompt;
        string _header = "=";
        string _footer = "=";
        string _lineSeperator = "";
        string _column = "||";
        public ConsoleColor TextColor { get; set; }
        public ConsoleColor BackgroundColor { get; set; }
        public Dictionary<string, Action> OptionMenu { get => _optionMenu; }
        public string Column { get => _column; set => _column = value; }
        public string LineSeperator { get => _lineSeperator; set => _lineSeperator = value; }
        public string Footer { get => _footer; set => _footer = value; }
        public string Header { get => _header; set => _header = value; }
        public string ConsolePrompt { get => _consolePrompt; set => _consolePrompt = value; }

        public ChoiceMenu(ConsoleColor textColor, ConsoleColor backgroundColor)
        {
            TextColor = textColor;
            BackgroundColor = backgroundColor;
        }
        public void AddMenuToStack()
        {
            MenuManager.AddMenuToStack(this);
        }
        public IConsoleMenu GetPreviousMenu()
        {
            return MenuManager.GetMenuFromStack();
        }
        public void PrintMenu()
        {
            ChangeToConsoleColor();
            //Console.Write(new string(Header, 2, ));
            Console.WriteLine(LineSeperator);
            Console.Write(Column + ConsolePrompt + Column);
            Console.WriteLine(LineSeperator);
            Console.Write(Header);
            Console.WriteLine("");
        }
        private void ChangeToConsoleColor()
        {
            Console.BackgroundColor = BackgroundColor;
            Console.ForegroundColor = TextColor;
        }
        public void AddFunctionChoice(string functionName, Action function)
        {
            _optionMenu.Add(functionName, function);
        }
        public void RemoveFunctionChoice(string functionName)
        {
            _optionMenu.Remove(functionName);
        }
    }
}
