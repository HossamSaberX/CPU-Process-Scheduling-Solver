using CPU_ProcessScheduling;

namespace CPU_ProcessScheduling
{
    class SJF
    {
        public static int[] wt;
        public static int[] tat;
        public static (double,double) avg_wt_tat(int[] at, int[] bt, int n)
        {
            int time = 0, smallest;
            double wtsum = 0, tatsum = 0;
             wt = new int[n];
            tat = new int[n];

            for (int i = 0; i < n; i++)
            {
                while (bt[i] > 0)
                {
                    smallest = i;
                    for (int j = 0; j < n; j++)
                    {
                        if (at[j] <= time && bt[j] > 0 && bt[j] < bt[smallest])
                            smallest = j;
                    }

                    wt[smallest] = time - at[smallest];
                    tat[smallest] = wt[smallest] + bt[smallest];

                    time += bt[smallest];
                    bt[smallest] = 0;
                }
            }

            for (int i = 0; i < n; i++)
            {
                wtsum += wt[i];
                tatsum += tat[i];
            }

            return (wtsum/n, tatsum/n);
        }

    }

}
    class FCFS
    {
        public static double sum = 0;
        public static int[] wt;
        public static int[] tat;

        public static (double, double) avgWT_TAT(int[] at, int[] bt, int length)
        {
            int[] start = new int[length];
            wt = new int[length];
            if (at[0]!=0) {start[0] = at[0];}
            else { start[0] = 0; }
            
            wt[0] = 0;
            for (int i = 1; i < length; i++)
            {
                start[i] = start[i - 1] + bt[i - 1];
                wt[i] = start[i] - at[i];
            }
            double sum = 0;

            for (int i = 0; i < length; i++)
            {
                sum += wt[i];
            }
            tat = new int[length];
            for (int i = 0; i < length; i++)
             {
            tat[i] = wt[i] + bt[i];
             }
            double sumtat = 0;
            for (int i = 0; i < length; i++)
            {
            sumtat += tat[i];
            }

            return (sum / length , sumtat/ length);
            }

    }
    internal class Program
    {

        static void Main(string[] args)
        {
        while (true)
        {
            Console.Write("Please, Enter the number of processes:");
            int x = int.Parse(Console.ReadLine());
            int[] at = new int[x];
            int[] bt = new int[x];

            for (int i = 0; i < x; i++)
            {
                Console.Write($"Enter the arrival time of process {i + 1} -->> ");
                at[i] = int.Parse(Console.ReadLine());
                Console.Write($"Enter the burst time of process {i + 1} -->> ");
                bt[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Choose a scheduling algorithm (FCFS or SJF): ");
            string algorithmChoice = Console.ReadLine().ToUpper();

            if (algorithmChoice == "FCFS")
            {
                var result = FCFS.avgWT_TAT(at, bt, x);

                for (int i = 0; i < x; i++)
                {
                    Console.WriteLine($"Waiting time of process {i + 1} = {FCFS.wt[i]}");
                }

                Console.WriteLine($"Your average Waiting Time is --->>> {result.Item1}");
                for (int i = 0; i < x; i++)
                {
                    Console.WriteLine($"Turn around time of process {i + 1} = {FCFS.tat[i]}");
                }
                Console.WriteLine($"Your average Turn Around Time is --->>> {result.Item2}");

            }
            else if (algorithmChoice == "SJF")
            {
                var result = SJF.avg_wt_tat(at, bt, x);

                for (int i = 0; i < x; i++)
                {
                    Console.WriteLine($"Waiting time of process {i + 1} = {SJF.wt[i]}");
                }

                Console.WriteLine($"Your average waiting time is --->>> {result.Item1}");
                for (int i = 0; i < x; i++)
                {
                    Console.WriteLine($"Waiting time of process {i + 1} = {SJF.tat[i]}");
                }
                Console.WriteLine($"Your average Turn Around Time is --->>> {result.Item2}");

            }
            else
            {
                Console.WriteLine("Invalid scheduling algorithm choice. Please choose either FCFS or SJF.");
            }
        }
    }
      
    }

