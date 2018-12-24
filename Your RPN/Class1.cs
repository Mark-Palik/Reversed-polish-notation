using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Your_RPN
{
    class Class1
    {
        public static string revPolNat(string Expr) {  //Перевод в обратную польскую запись
            string current = "";
            Stack<char> stack = new Stack<char> ();
            int priority;
            for (int i = 0; i < Expr.Length; i++)
            {
                priority = getP(Expr[i]);
                if (priority == 0) current += Expr[i];
                if (priority == 1) stack.Push(Expr[i]);

                if (priority > 1) {
                    current += ' ';
                    while (stack.Count != 0) {
                        if (getP(stack.Peek()) >= priority) current += stack.Pop();
                        else break;
                    }
                    stack.Push(Expr[i]);
                }
                if (priority == -1) {
                    current += ' ';
                    while (getP(stack.Peek()) != 1) current += stack.Pop();
                    stack.Pop();
                }
            }
            while (stack.Count != 0) current += stack.Pop();
            return current;
        }
        public static double polNattoAnr(string rpn) {
            string operand = "";
            Stack<double> stack = new Stack<double>();

            for (int i = 0; i < rpn.Length; i++) {
                if (rpn[i] == ' ') continue;

                if (getP(rpn[i]) == 0) {
                    while (rpn[i] != ' ' && getP(rpn[i]) == 0)
                    {
                        operand += rpn[i++];
                        if (i == rpn.Length) break;
                    }
                    stack.Push(Double.Parse(operand));
                    operand = "";
                }

                if (getP(rpn[i]) > 1) {
                    double a = stack.Pop(), b = stack.Pop();
                    if (rpn[i] == '+') stack.Push(b + a);
                    if (rpn[i] == '-') stack.Push(b - a);
                    if (rpn[i] == '*') stack.Push(b * a);
                    if (rpn[i] == '/') stack.Push(b / a);
                }

            }

            return stack.Pop();
        }
        private static int getP(char token) {
            if (token == '*' || token == '/') return 3;
            else if (token == '+' || token == '-') return 2;
            else if (token == '(') return 1;
            else if (token == ')') return -1;
            else return 0;


        }
    }
}
