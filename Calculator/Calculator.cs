using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public interface IAdder
    {
        int Add(int x, int y);
    }

    public class Calculator : IAdder
    {
        ILogger logger { get; }
        public Calculator(ILogger logger)
        {
            this.logger = logger;
        }
        public int Add(int x, int y)
        {
            return x + y;
        }
    }
}
