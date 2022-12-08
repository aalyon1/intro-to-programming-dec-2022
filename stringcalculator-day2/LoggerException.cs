using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator;

public class LoggerException : ApplicationException
{
    public LoggerException(string message): base(message)
    {

    }
}
