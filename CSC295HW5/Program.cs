namespace CSC295HW5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, this is my CSC295 Homework # 5.");
            Console.WriteLine("I am working on 'Implementing a Stack to Check for Balanced Parentheses.'");

            // Test case 1: Balanced parentheses
            string expression1 = "{[()]}";
            bool result1 = ParenthesisChecker.IsBalanced(expression1);
            Console.WriteLine($"Test Case 1 - Expression: {expression1}, Expected: True, Actual: {result1}");

            // Test case 2: Unbalanced parentheses
            string expression2 = "{[(])}";
            bool result2 = ParenthesisChecker.IsBalanced(expression2);
            Console.WriteLine($"Test Case 2 - Expression: {expression2}, Expected: False, Actual: {result2}");

            // Test case 3: Missing closing bracket
            string expression3 = "{[()]}{";
            bool result3 = ParenthesisChecker.IsBalanced(expression3);
            Console.WriteLine($"Test Case 3 - Expression: {expression3}, Expected: False, Actual: {result3}");

            // Test case 4: No parentheses at all
            string expression4 = "abc";
            bool result4 = ParenthesisChecker.IsBalanced(expression4);
            Console.WriteLine($"Test Case 4 - Expression: {expression4}, Expected: True, Actual: {result4}");
        }
    }
}
