using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMenuFramework
{
    public static class MenuManager
    {
        static Stack<IConsoleMenu> menuStack = new Stack<IConsoleMenu>();

        public static void AddMenuToStack(IConsoleMenu menu)
        {
            menuStack.Push(menu);
        }
        public static IConsoleMenu GetMenuFromStack()
        {
            return menuStack.Pop();
        }

    }
}
