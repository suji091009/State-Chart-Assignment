using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateChart_Assign
{
    class Program
    {
        static void Main(string[] args)
        {
            Controller ctrl = new Controller();
            while (!ctrl.IsFinalState())
            {
                string line = Console.ReadLine();
                switch (line[0])
                {
                    case 'a': ctrl.eventA(); break;
                    case 'b': ctrl.eventB(); break;
                    case 'c': ctrl.eventC(); break;
                    case 'd': ctrl.eventD(); break;
                    case 'e': ctrl.eventE(); break;
                    case 'f': ctrl.eventF(); break;
                    default:
                        Console.WriteLine("Input not an event: " + line);
                        break;
                }
                Console.WriteLine("STATUS: " + ctrl.ToString());
            }
        }
    }
    class Controller
    {
        private int stateOfA = 1;
        private int stateOfB = 4;
        private int stateOfC = 7;
        private int stateOfD = 9;
        private int stateOfE = 11;
        private int stateOfF = 13;
        private bool finalState = false;

        public Controller()
        {
            goState1();
            goState4();
        }

        override public string ToString()
        {
            return "state of A = " + stateOfA + "  state of B = " + stateOfB + "  state of C = " + stateOfC 
                + "  state of D = " + stateOfD + "  state of E = " + stateOfE + "  state of F = " + stateOfF;
        }

        private void goState1()
        {
            stateOfA = 1;
            Console.WriteLine("Entering State 1\n");
        }
        private void goState2()
        {
            stateOfA = 2;
            Console.WriteLine("Entering State 2\n");
        }
        private void goState3()
        {
            stateOfA = 3;
            Console.WriteLine("Entering State 3\n");
        }
        private void goState4()
        {
            stateOfB = 4;
            Console.WriteLine("Entering State 4\n");
        }
        private void goState5()
        {
            stateOfB = 5;
            Console.WriteLine("Entering State 5\n");
        }
        private void goState6()
        {
            stateOfC = 6;
            Console.WriteLine("Entering State 6\n");
        }
        private void goState7()
        {
            stateOfC = 7;
            Console.WriteLine("Entering State 7\n");
        }
        private void goState8()
        {
            stateOfD = 8;
            Console.WriteLine("Entering State 8\n");
        }
        private void goState9()
        {
            stateOfD = 9;
            Console.WriteLine("Entering State 9\n");
        }
        private void goState10()
        {
            stateOfE = 10;
            Console.WriteLine("Entering State 10\n");
        }
        private void goState11()
        {
            stateOfE = 11;
            Console.WriteLine("Entering State 11\n");
        }
        private void goState12()
        {
            stateOfF = 12;
            Console.WriteLine("Entering State 12\n");
        }
        private void goState13()
        {
            stateOfF = 13;
            Console.WriteLine("Entering State 13\n");
        }


        public bool IsFinalState()
        {
            return finalState;
        }

        public void eventA()
        {
            if (stateOfA == 1 && stateOfB == 5)
            {
                goState4();
            }
            else if (stateOfA == 2 && stateOfC == 6 && stateOfD == 9)
            {
                goState8();
            }
            else if (stateOfA == 2 && stateOfC == 6 && stateOfF == 12)
            {
                goState13();
            }
            else
            {
                Console.WriteLine("Event A ignored");
            }

        }
        public void eventB()
        {
            if (stateOfA == 1 && stateOfB == 4)
            {
                goState5();
            }
            else if (stateOfA == 2 && stateOfC == 6 && stateOfD == 8)
            {
                goState9();
            }
            else if (stateOfA == 2 && stateOfC == 7)
            {
                switch (stateOfB)
                {
                    case 4:
                        goState4();
                        break;
                    case 5:
                        goState5();
                        break;
                    default:
                        goState4();
                        break;
                }
            }
        }
        public void eventC()
        {
            if (stateOfA == 2 && stateOfC == 6 && stateOfE == 10)
            {
                goState11();
            }
            else if (stateOfA == 2 && stateOfC == 6 && stateOfE == 11)
            {
                goState10();
            }
            else if (stateOfA == 2 && stateOfC == 6 && stateOfF == 13)
            {
                goState12();
            }
            else
            {
                Console.WriteLine("Event C ignored");
            }
        }
        public void eventD()
        {
            if (stateOfA == 2 && stateOfC == 6)
            {
                goState7();
            }
            else if (stateOfA == 1)
            {
                goState3();
            }
            else
            {
                Console.WriteLine("Event D ignored");
            }
        }
        public void eventE()
        {
            if (stateOfA == 3)
            {
                goState1();
                goState5();
            }
            else if (stateOfA == 2 && stateOfC ==7)
            {
                goState6();
            }
            else
            {
                Console.WriteLine("Event E ignored");
            }
        }
        public void eventF()
        {
            if (stateOfA == 1)
            {
                goState2();
            }
            else
            {
                Console.WriteLine("Event F ignored");
            }

        }

    }
}
