using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_TEST.Services.Interfaces
{
    public interface ITestService
    {
        int MaxRecursive(int[] list);
        int RecursiveModule(int dividendo, int divisor);
        List<string> RecursiveChairString(string input);

        List<string> RecursiveChairSubString(string input);
    }
}
