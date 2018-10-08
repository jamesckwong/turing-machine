using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turing_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "*101*";
            int cell = input.Length - 1;
            StringBuilder tape = new StringBuilder();
            tape.Append(input);
            string state = "START";
            char read;
            Console.WriteLine(input + " " + state);

            do
            {
                read = tape[cell];
                if (state == "START" && read == '*')
                {
                    tape[cell] = '*';
                    cell--;
                    state = "ADD";
                    Console.WriteLine(tape + " " + state);
                }
                else if (state == "ADD" && read == '0')
                {
                    tape[cell] = '1';
                    cell++;
                    state = "RETURN";
                    Console.WriteLine(tape + " " + state);
                }
                else if (state == "ADD" && read == '1')
                {
                    tape[cell] = '0';
                    cell--;
                    state = "CARRY";
                    Console.WriteLine(tape + " " + state);

                }
                else if (state == "ADD" && read == '*')
                {
                    tape[cell] = '*';
                    cell++;
                    state = "HALT";
                    Console.WriteLine(tape + " " + state);
                }
                else if (state == "CARRY" && read == '0')
                {
                    tape[cell] = '1';
                    cell++;
                    state = "RETURN";
                    Console.WriteLine(tape + " " + state);
                }
                else if (state == "CARRY" && read == '1')
                {
                    tape[cell] = '0';
                    cell--;
                    state = "CARRY";
                    Console.WriteLine(tape + " " + state);
                }
                else if (state == "CARRY" && read == '*')
                {
                    tape[cell] = '1';
                    cell--;
                    state = "OVERFLOW";
                    Console.WriteLine(tape + " " + state);
                }
                else if (state == "OVERFLOW" && read == '*')
                {
                    tape[cell] = '*';
                    cell++;
                    state = "RETURN";
                    Console.WriteLine(tape + " " + state);
                }
                else if (state == "RETURN" && read == '0')
                {
                    tape[cell] = '0';
                    cell++;
                    state = "RETURN";
                    Console.WriteLine(tape + " " + state);
                }
                else if (state == "RETURN" && read == '1')
                {
                    tape[cell] = '1';
                    cell++;
                    state = "RETURN";
                    Console.WriteLine(tape + " " + state);
                }
                else if (state == "RETURN" && read == '*')
                {
                    tape[cell] = '*';
                    state = "HALT";
                }
                

            } while (state != "HALT");

        }
    }
}
        

             




