using System;



class XExpression
{
    static void Main()
    {
        string expressions = Console.ReadLine();
        decimal result = 0;
        decimal currentBreacketResult = 0;
        char currentOperator = '+';
        char currentBreackedOperator = '+';
        bool inBracket = false;
        foreach (char symbol in expressions)
        {
            if (symbol == '(')
            {
                inBracket = true;
                continue;
            }
            if (symbol == ')')
            {
                inBracket = false;
                switch (currentOperator)
                {
                    case '+': result += currentBreacketResult; break;
                    case '-': result -= currentBreacketResult; break;
                    case '*': result *= currentBreacketResult; break;
                    case '/': result /= currentBreacketResult; break;

                }
                currentBreacketResult = 0;
                currentBreackedOperator = '+';
            }
            if (symbol == '+' || symbol == '-' || symbol == '*' || symbol == '/')
            {
                if (inBracket)
                {
                    currentBreackedOperator = symbol;
                }
                else
                {
                    currentOperator = symbol;
                }
            }
            if (symbol >= '0' && symbol <= '9')
            {
                int currentNumber = symbol - '0';
                if (inBracket)
                {
                    switch (currentBreackedOperator)
                    {
                        case '+': currentBreacketResult += currentNumber; break;
                        case '-': currentBreacketResult -= currentNumber; break;
                        case '*': currentBreacketResult *= currentNumber; break;
                        case '/': currentBreacketResult /= currentNumber; break;

                    }
                }
                else
                {
                    switch (currentOperator)
                    {
                        case '+': result += currentNumber; break;
                        case '-': result -= currentNumber; break;
                        case '*': result *= currentNumber; break;
                        case '/': result /= currentNumber; break;

                    }
                }
            }
        }
        Console.WriteLine("{0:F2}", result);
    }
}
