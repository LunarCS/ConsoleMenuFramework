using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMenuFramework
{
    public class Action<T> : IAction where T : Delegate
    {
        private T _function;
        private object[] _args;
        public Action(T function, params object[] args)
        {
            _function = function;
            _args = args;
        }
        public void Invoke()
        {
            _function.DynamicInvoke();
        }
    }
}
