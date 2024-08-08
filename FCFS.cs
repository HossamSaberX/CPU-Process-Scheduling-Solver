
namespace CPU_ProcessScheduling
{
    public static class FCFS
    {

        public static void FCFSSchedule(Process[] Inputs)
        {
            Console.WriteLine ("<<<<<<<<<<<<<<<<<<<<FCFS>>>>>>>>>>>>>>>>>>>>");

            int len = Inputs.Length;
            int[] start = new int[len];

            if (Inputs[0].ArrivalT != 0) start[0] = Inputs[0].ArrivalT;
            else start[0] = 0;

            Inputs[0].WaitingT = 0;

            for (int i = 1; i < len; i++)
            {
                start[i] = start[i - 1] + Inputs[i - 1].BurstT;
                Inputs[i].WaitingT = start[i] - Inputs[i].ArrivalT;
            }

            Process.AvgWTTAT(Inputs);

        }

    }
}
