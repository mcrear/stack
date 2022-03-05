using System;
using System.Collections;
using System.Collections.Generic;

namespace StackExample
{
    class Program
    {
        static void Main(string[] args)
        {
            bool tryAgain = true;
            while (tryAgain)
            {
                bool isSuccuss = true;
                Console.WriteLine("Örnek parantez dizisini aralarına virgül koyarak ekleyiniz. Örn. '{,(,{,[,},}'");
                string data = Console.ReadLine();

                Stack<string> stk = new Stack<string>();


                string[] dataArray = data.Split(',');
                foreach (var item in dataArray)
                {

                    switch (item)
                    {
                        case "{":
                        case "(":
                        case "[":
                            {
                                stk.Push(item);
                                break;
                            }
                        case "]":
                            {
                                if (stk != null && stk.Count > 0)
                                    isSuccuss = stk.Pop() != "[" ? false : isSuccuss;
                                else isSuccuss = false;
                                break;
                            }
                        case ")":
                            {
                                if (stk != null && stk.Count > 0)
                                    isSuccuss = stk.Pop() != "(" ? false : isSuccuss;
                                else isSuccuss = false;
                                break;
                            }
                        case "}":
                            {
                                if (stk != null && stk.Count > 0)
                                    isSuccuss = stk.Pop() != "{" ? false : isSuccuss;
                                else isSuccuss = false;
                                break;
                            }
                        default:
                            break;
                    }

                }

                isSuccuss = stk.Count == 0 ? isSuccuss : false;

                Console.WriteLine(isSuccuss);

                Console.WriteLine("\n Tekrar dene? e/h");
                string again = Console.ReadLine();

                tryAgain = again.ToLower() == "e";
            }


            Console.ReadKey();
        }
    }
}
