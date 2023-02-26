using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ProyectoLFA.Classes
{
    public class GrammarFormat
    {
        //Regular expression to evaluate SETS
        private static string SETS
            = " *[A-Z]+ *= *((('([A-Z]|[a-z]|[0-9]|[Simbolo])+')|(CHR\\([0-9]+\\)))( *. *. *(('([A-Z]|[a-z]|[0-9]|[Simbolo])+')|(CHR\\([0-9]+\\))))?)+ *" +
              "( *\\+ *((('([A-Z]|[a-z]|[0-9]|[Simbolo])+')|(CHR\\([0-9]+\\)))( *. *. *(('([A-Z]|[a-z]|[0-9]|[Simbolo])+')|(CHR\\([0-9]+\\))))?))* *#";
        private static string TOKENS
            = "( *TOKEN *[0-9]+ *= *((([A-Z]+)|('([Simbolo]|[A-Z]|[a-z]|[0-9]) *' *)|(\\(+( *([A-Z]|[Simbolo]) *)+\\))| |\\?|\\(|\\)|\\||\\*|\\+|({ *[A-Z]+\\(\\) *}))|( *\\( *((([A-Z]+)|('([Simbolo]|[A-Z]|[a-z]|[0-9]) *' *)|(\\(( *([A-Z]|[Simbolo]) *)+\\))| |\\?|\\(|\\)|\\||\\*|\\+|({ *[A-Z]+\\(\\) *})))+ *\\)+ *))+ *)+#";
        private static string ACTIONSERRORS
            = "( *ACTIONS +RESERVADAS *\\( *\\) *{( *[0-9]+ *= *'([A-Z]|[a-z]|[0-9]|[Simbolo])+')+ *} *([A-Z]+ *\\( *\\) *{( *[0-9]+ *= *'([A-Z]|[a-z]|[0-9]|[Simbolo])+')+ *})*)( *[A-Z]+ *= *[0-9]+)+ *#";

        public static string AnalyseFile(string data, ref int line)
        {
            //It helps changing jumps for spaces and remove all them with "TRIMSTART" and "TRIMEND"
            data = data.Replace('\r', ' ');
            data = data.Replace('\t', ' ');

            data = data.TrimStart();
            data = data.TrimEnd();

            RegularExpression regularSET = new RegularExpression(SETS);
            RegularExpression regularTOKEN = new RegularExpression(TOKENS);
            RegularExpression regularAE = new RegularExpression(ACTIONSERRORS);

            string mensaje = "";
            string actions = "";

            bool first = true;
            bool setExists = false;
            bool tokenExists = false;
            bool actionExists = false;

            int tokenCount = 0;
            int setCount = 0;

            string[] lines = data.Split('\n');
            int count = 0;

            foreach (var item in lines)
            {
                count++;
                if (!string.IsNullOrWhiteSpace(item) && !string.IsNullOrEmpty(item))
                {
                    if (first)
                    {
                        first = false;
                        if (item.Contains("SETS"))
                        {
                            setExists = true;
                        }
                        else if (item.Contains("TOKENS"))
                        {
                            tokenExists = true;
                        }
                        else
                        {
                            line = 1;
                            return "Error en linea 1: Se esperaba SETS o TOKENS";
                        }
                    }
                    else if (setExists)
                    {
                        if (item.Contains("TOKENS"))
                        {
                            if (setCount < 1)
                            {
                                line = count;
                                return "Error: Se esperaba almenos un SET";
                            }
                            setExists = false;
                            tokenExists = true;
                        }
                        else
                        {
                            if (item.Contains("Error"))
                            {
                                line = count;
                                return $"Error en linea: {count}";
                            }
                            if (!closedParenthesis(item))
                            {
                                line = count;
                                return $"Error en linea: {count} \nSe esperaba ()";
                            }
                            setCount++;
                        }
                    }
                    else if (tokenExists)
                    {
                        if (item.Contains("ACTIONS"))
                        {
                            if (tokenCount < 1)
                            {
                                line = count;
                                return "Error: Se esperaba almenos un TOKEN";
                            }
                            actions = "ACTIONS";
                            tokenExists = false;
                            actionExists = true;
                        }
                        else
                        {
                            if (item.Contains("Error"))
                            {
                                line = count;
                                return $"Error en linea: {count}";
                            }
                            tokenCount++;
                        }
                    }
                    else if (actionExists)
                    {
                        actions += " " + item;
                    }
                }
            }
            line = count;
            return mensaje;
        }

        //This method evaluates if there are sufficient parenthesis lo close the amount of open parenthesis
        private static bool  closedParenthesis (string expression)
        {
            if (expression.Contains('(') || expression.Contains(')'))
            {
                int openPerenthesis = 0;
                int closePerenthesis = 0;

                //Delete spaces
                expression = expression.Replace(" ", "");

                for (int i = 0; i < expression.Length; i++)
                {
                    if (expression[i] == '\'')
                    {
                        i += 2;
                    }
                    else if (expression[i] == '(')
                    {
                        openPerenthesis++;
                    }
                    else if (expression[i] == ')')
                    {
                        closePerenthesis++;
                    }
                }

                if (openPerenthesis == closePerenthesis)
                {
                    return true;
                }

                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
