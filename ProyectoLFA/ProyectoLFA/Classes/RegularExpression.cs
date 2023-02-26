using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLFA.Classes
{
    //Gets, save and build a simple regular expression
    class RegularExpression : CharSET
    {
        //Constructor
        public RegularExpression(string exp)
        {
            exp = simplifyExpression(exp);
        }

        private string simplifyExpression(string expression)
        {
            expression = expression.Replace(MinusLetter, MinusLetterSimple);
            expression = expression.Replace(MayusLetter, MayusLetterSimple);
            expression = expression.Replace(NumsLetter, NumsLetterSimple);
            expression = expression.Replace(SymbolLetter, SymbolLetterSimple);

            return expression;
        }
        public string ValidateString(string text)
        {

            string message = "";

            message = message.Replace(MayusLetterSimple, MayusLetter);
            message = message.Replace(MinusLetterSimple, MinusLetter);
            message = message.Replace(NumsLetterSimple, NumsLetter);
            message = message.Replace(SymbolLetterSimple, SymbolLetter);

            return message;
        }
    }
}
