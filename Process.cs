
namespace CPU_ProcessScheduling
{
    public struct Process
    {
        public int ArrivalT { get; set; }
        public int BurstT { get; set; }
        public int WaitingT { get; set; }

        public int TurnaroundT { get; set; }

        public static double waitTSum = 0;
        public static double turnAroundTimeSum = 0;

        public Process(int at, int bt)
        {
            ArrivalT = at;
            BurstT = bt;
            WaitingT = 0;
            TurnaroundT = 0;
            
        }

        public static void AvgWTTAT(Process[] Inputs)
        {
            waitTSum = 0;
            turnAroundTimeSum = 0;
            double len = Inputs.Length;
            for (int i = 0; i < len; i++)
            {
                waitTSum += Inputs[i].WaitingT;
                turnAroundTimeSum += Inputs[i].TurnaroundT = Inputs[i].WaitingT + Inputs[i].BurstT;
                Console.WriteLine($"Process {i+1} - Waiting time: {Inputs[i].WaitingT}, Turnaround Time: {Inputs[i].TurnaroundT}");
            }

            Console.WriteLine($"Average Waiting Time: {(waitTSum / len)} ");
            Console.WriteLine($"Average Turnaround Time: {(turnAroundTimeSum / len)} ");
            Console.WriteLine();
            Console.WriteLine("============================================================================================");


        }



    }
}
