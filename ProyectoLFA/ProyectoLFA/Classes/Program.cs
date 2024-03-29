﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Scanner
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> Input = new Stack<char>();

            Inicio:

            Console.Write("\nEscriba la cadena para analizar: ");
            Input = getStack(Console.ReadLine());

            Console.Write("\nAnalizando");
            Thread.Sleep(300);
            Console.Write(".");
            Thread.Sleep(300);
            Console.Write(".");
            Thread.Sleep(800);
            Console.Write(".\n");

            try
            {
                AnalizarTexto(Input);
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e);
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nPresiona cualquier tecla para continuar.");
            Console.ReadKey();
            Console.Clear();
            goto Inicio;
        }

        static Stack<char> getStack(string input)
        {
            Stack<char> output = new Stack<char>();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                output.Push(input[i]);
            }

            return output;
        }

        static void Error()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nError: La cadena introducida no es valida");
        }

        static void Valido(ref string token)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n" + token + " » " + getTokenNumber(token));
            token = "";
        }

        static int getTokenNumber(string text)
        {
            char firstCharacterFromText = text[0];

            char lastCharacterFromText = text[0];

            if (text.Length > 1)
            {
                lastCharacterFromText = text[text.Length - 1];
            }

            Dictionary<int, List<char>> Character_Token_First = new Dictionary<int, List<char>>
            {
                </FirstPos>
            };

            Dictionary<List<char>, int> Character_Token_Last = new Dictionary<List<char>, int>
            {
                </LastPos>
            };

            Dictionary<string, int> ReservadasValues = new Dictionary<string, int>
            {
                </Reservadas>
            };
             
            List<int> TokensConReferencia = new List<int>
            {
                </Referencias>
            };
            
            foreach (var Pair in Character_Token_Last)
            {
                if (Pair.Key.Contains(lastCharacterFromText) && 
                    Character_Token_First[Pair.Value].Contains(firstCharacterFromText))
                {
                    if (TokensConReferencia.Contains(Pair.Value))
                    {
                        if (ReservadasValues.Keys.Contains(text.ToUpper()))
                        {
                            return ReservadasValues[text.ToUpper()];
                        }
                    }
                    return Pair.Value;
                }   
            }

            return 0;
        }

        static void AnalizarTexto(Stack<char> Input)
        {
            Inicio:

            int Estado = 0;
            string actualText = "";

            while (Input.Count > 0)
            {
                actualText = actualText.Trim();
                char actualChar = Input.Pop();

                if (actualChar != ' ' && actualChar != 0)
                {
                    switch(Estado)
                    {
                        </States>

                        case -1:
                            Valido:
                            if (actualText.Length > 0)
                            {
                                Valido(ref actualText);
                            }
                            Estado = 0;
                            Input.Push(actualChar);
                            actualChar = ' ';
                            break;
                        default:
                            Error:
                            Error();
                            return;
                    }

                    actualText += actualChar;

                }
                else
                {
                    goto CheckForAcceptedStates;       
                }
            }
            
            if (actualText.Length > 0)
            {
                goto CheckForAcceptedStates;    
            }

            return;

            CheckForAcceptedStates:
            if (!string.IsNullOrEmpty(actualText) && !string.IsNullOrWhiteSpace(actualText))
            {
                if (</Aceptacion>) 
                {
                    Valido(ref actualText);
                }
                else
                {
                    Error();
                }   
            }
            goto Inicio;
        }
    }
}

