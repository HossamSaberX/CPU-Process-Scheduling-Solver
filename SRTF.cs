namespace CPU_ProcessScheduling
{
    public static class SRTF
    {
        public static void SRTFSchedule(Process[] Inputs)
        {
            Console.WriteLine("<<<<<<<<<<<<<<<<<<<<SRTF>>>>>>>>>>>>>>>>>>>>");
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

                    time++;
                    Copy[smallest].BurstT--;
                    
                    if (Copy[smallest].BurstT == 0)
                    {
                        //Copy[smallest].TurnaroundT = time - Copy[smallest].ArrivalT;
                        Inputs[smallest].WaitingT = time - Inputs[smallest].ArrivalT - Inputs[smallest].BurstT;
                        
                    }

                }
            }

            Process.AvgWTTAT(Inputs);

        }
    }
}
