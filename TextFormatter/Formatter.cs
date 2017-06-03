using System;

namespace Formatter
{
    public class FormatterBase
    {
        public virtual string Format(string message)
        {
            return message;
        }
    }

    public class FormatterTimeStamp : FormatterBase
    {
        public override string Format(string message)
        {
            return string.Format("{0} - {1}", DateTime.Now.ToShortTimeString(), message);
        }
    }

    public class FormatterDateTimeStamp : FormatterBase
    {
        public override string Format(string message)
        {
            return string.Format("{0} {1} - {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), message);
        }
    }
}
