
namespace CPU_ProcessScheduling
{
    public static class SJF
    {
        public static void SJFSchedule(Process[] Inputs)
        {
            Console.WriteLine("<<<<<<<<<<<<<<<<<<<<SJF>>>>>>>>>>>>>>>>>>>>");
            Process[] Copy = new Process[Inputs.Length];
            Inputs.CopyTo(Copy, 0);

            int len = Inputs.Length;
            int time = 0, smallest;
       
            for (int i = 0; i < len; i++)
            {
                while (Copy[i].BurstT > 0)
                {
                    smallest = i;
                    for (int j = 0; j < len; j++)
                    {
                        if (Copy[j].ArrivalT <= time && Copy[j].BurstT > 0 && Copy[j].BurstT < Copy[smallest].BurstT)
                            smallest = j;
                    }

                    Inputs[smallest].WaitingT = time - Copy[smallest].ArrivalT;
                    time += Copy[smallest].BurstT;
                    Copy[smallest].BurstT = 0;

                }
            }

            Process.AvgWTTAT(Inputs);

        }

    }

}
