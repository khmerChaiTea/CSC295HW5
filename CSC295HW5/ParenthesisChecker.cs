using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC295HW5
{
    public class ParenthesisChecker
    {
        public static bool isBalanced(string expression)
        {
            Stack stack = new Stack();

            foreach (char c in expression)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }
                else if (c == ')' || c == '}' || c == ']')
                {
                    if (stack.Count == 0)
                    {
                        return false;   // No mathing opening bracket
                    }

                    char last = (char)stack.Pop();

                    if ((c == ')' && last != '(') || (c == '}' && last != '{') || (c == ']' && last != '['))
                    {
                        return false; // Mismatched parentheses
                    }
                }
            }

            return stack.Count == 0; // True if no unmatched opening brackets
        }
    }
}
