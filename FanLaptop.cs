using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODUL4
{
    internal class FanLaptop
    {
        private enum State { Quiet, Balanced, Performance, Turbo}
        private State currentState;

        public FanLaptop()
        {
            currentState = State.Quiet;
            Console.WriteLine("Fan dalam mode quiet");
        }

        public void UbahKeBalanced()
        {
            if (currentState == State.Quiet)
            {
                currentState = State.Balanced;
                Console.WriteLine("Fan meningkat ke mode balanced");
            }
            else if(currentState == State.Balanced)
            {
                Console.WriteLine("Fan sudah dalam mode balanced");
            }
            else if(currentState == State.Performance)
            {
                currentState = State.Balanced;
                Console.WriteLine("Fan menurun ke mode balanced");
            }
            else
            {
                Console.WriteLine("");
            }
        }

        public void UbahKeTurbo()
        {
            if (currentState == State.Quiet)
            {
                currentState = State.Turbo;
                Console.WriteLine("Fan meningkat ke mode turbo");
            }
            else if (currentState == State.Turbo)
            {
                Console.WriteLine("Fan sudah dalam mode turbo");
            }
            else if (currentState == State.Performance)
            {
                currentState = State.Turbo;
                Console.WriteLine("Fan meningkat ke mode turbo");
            }
        }

        public void UbahKeQuiet()
        {
            if (currentState == State.Turbo)
            {
                currentState = State.Quiet;
                Console.WriteLine("Fan menurun ke mode quiet");
            }
            else if (currentState == State.Quiet)
            {
                Console.WriteLine("Fan sudah dalam mode quiet");
            }
            else if (currentState == State.Balanced)
            {
                currentState = State.Quiet;
                Console.WriteLine("Fan menurun ke mode quiet");
            }
        }

        public void UbahKePerformance()
        {
            if (currentState == State.Turbo)
            {
                currentState = State.Performance;
                Console.WriteLine("Fan menurun ke mode performance");
            }
            else if (currentState == State.Performance) 
            {
                Console.WriteLine("Fan sudah dalam mode performance");
            }
            else if (currentState == State.Balanced)
            {
                currentState = State.Performance;
                Console.WriteLine("Fan meningkat ke mode performance");
            }
        }
    }
}
