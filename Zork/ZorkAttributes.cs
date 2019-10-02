using System;
using System.Collections.Generic;
using System.Text;

namespace Zork
{
    [AttributeUsage(AttributeTargets.Class)]
    public class CommandClassAttribute : Attribute
    {
        public string CommandName { get; }

        public IEnumerable<string> Verbs { get; }

        public CommandAttribute(string commandName, string verbs) :
            this(commandName, new string[] { verbs })
        {

        }

        public CommandAttribute(string commandName, string[] verbs)
        {
            CommandName = commandName;
            Verbs = verbs;
        }
        
    }
}
