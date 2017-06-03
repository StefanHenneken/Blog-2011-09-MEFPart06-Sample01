using System;
using System.ComponentModel.Composition;
using Formatter;

namespace Logger
{
    [Export]
    public class ConsoleLogger
    {
        private FormatterBase formatter;

        [ImportingConstructor]
        public ConsoleLogger([Import(typeof(FormatterBase))]FormatterBase formatter)
        {
            this.formatter = formatter;
        }

        public void Log(string message)
        {
            string formattedString = this.formatter.Format(message);
            Console.WriteLine(formattedString);
        }
    }
}
