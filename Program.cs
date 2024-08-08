using CPU_ProcessScheduling;

internal class Program
{

    static void Main(string[] args)
    {

    
        while (true)
        {
            Console.Write("Number Of Processes: ");
            int x = int.Parse(Console.ReadLine());

            Process[] processes = new Process[x];
            //Process[] fcfs = new Process[x];
            //Process[] sjf = new Process[x];



            for (int i = 0; i < x; i++)
            {
                Console.Write($"Enter the arrival time of process {i + 1} -->> ");
                processes[i].ArrivalT = int.Parse(Console.ReadLine());
                Console.Write($"Enter the burst time of process {i + 1} -->> ");
                processes[i].BurstT = int.Parse(Console.ReadLine());
            }

            //processes.CopyTo(fcfs, 0);
            //processes.CopyTo(sjf, 0);

            Console.Write("Choose a scheduling algorithm:-\n1. FCFS\n2. SJF\n3. SRTF\n4. ALL\n");
            string Choice = Console.ReadLine().ToUpper();

            if (Choice == "1") FCFS.FCFSSchedule(processes);
            else if (Choice == "2") SJF.SJFSchedule(processes);
            else if (Choice == "3") SRTF.SRTFSchedule(processes);
            else if (Choice == "4")
            {
                FCFS.FCFSSchedule(processes);
                SJF.SJFSchedule(processes);
                SRTF.SRTFSchedule(processes);
            }

            else Console.WriteLine("Invalid scheduling algorithm choice. Please choose of the shown numbers");

            Console.WriteLine("==============Program Restarted==============");
            Console.WriteLine("============================================================================================");


        }
    }

}

