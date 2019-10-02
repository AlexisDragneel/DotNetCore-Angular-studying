using API_TEST.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_TEST.Services
{
    public class TestService : ITestService
    {
        public int MaxRecursive(int[] list)
        {
            return RecursiveFinder(list, 0, list[0]);
        }

        public List<string> RecursiveChairString(string input)
        {
            return RecursiveBuildListString(input, 0, new List<string>());
        }

        public List<string> RecursiveChairSubString(string input)
        {

            return RecursiveBuildListSubString(input, 0, new List<string>());
        }

        public int RecursiveModule(int dividendo, int divisor)
        {
            if (dividendo < divisor)
            {
                return dividendo;
            }

            return RecursiveModule(dividendo - divisor, divisor);
        }


        private List<String> RecursiveBuildListSubString(string input, int index, List<string> list)
        {
            if (index >= input.Length)
            {
                list.Add(input.Substring(0, input.Length));
                return list;
            }
            string sub_string = input.Substring(0, index + 1);
            list.Add(sub_string);
            return RecursiveBuildListSubString(input.Remove(0, index + 1), index + 1, list);
        }

        private List<string> RecursiveBuildListString(string input, int index, List<string> list)
        {
            if (index >= input.Length)
            {
                return list;
            }

            list.Add(input.Substring(0, index + 1));
            return RecursiveBuildListString(input, index + 1, list);

        }

        private int RecursiveFinder(int[] list, int index, int maxValue)
        {
            if(index >= list.Length)
            {
                return maxValue;
            }
            maxValue = list[index] > maxValue ? list[index] : maxValue;
            return RecursiveFinder(list, index + 1, maxValue);
        }
        
    }
}
