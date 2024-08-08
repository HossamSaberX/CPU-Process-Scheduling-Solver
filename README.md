## Process Scheduling Program

This simple console application is based on First-Come, First-Serve (FCFS) and Shortest Job First (SJF) scheduling algorithms. It is currently under development to include more algorithms, and a Gantt chart feature is yet to be implemented.

### FCFS Algorithm

The core logic of the FCFS algorithm is straightforward. The first process always has a waiting time of 0. The waiting time of a process is calculated based on the burst time of the previous process and the waiting time of the previous process. The execution order follows the order of arrival.

### SJF Algorithm

The SJF algorithm relies on a condition-based while loop to sort incoming processes while other processes are still running. It ensures that the burst time of a process becomes zero, indicating its completion, before moving on to the next process. The algorithm prioritizes shorter burst times, aiming to minimize waiting times.

### SRTF Algorithm

The SRTF algorithm is a preemptive version of the SJF algorithm. It selects the process with the shortest remaining time for execution. If a new process arrives with a shorter burst time than the currently executing process, the SRTF algorithm will preempt the current process and switch to the new, shorter process.

### Object-Oriented Design

The program has been designed using an object-oriented approach to enhance reusability and simplicity. The key classes include:

1. `Process` class:
   - Represents a single process with properties like arrival time, burst time, waiting time, and turnaround time.
   - Includes a static `AvgWTTAT` method to calculate and display the average waiting time and turnaround time for an array of processes.

2. Scheduling Algorithm Classes:
   - Each scheduling algorithm (FCFS, SJF, SRTF) has its own class with a static `Schedule` method.
   - These methods take an array of `Process` objects, apply the respective scheduling algorithm, and update the waiting and turnaround times for each process.


### Usage Instructions

To use the Process Scheduling Program:

1. Clone the repository from the provided GitHub link.
2. Open the solution file in your Visual Studio.
3. Build the solution to ensure all dependencies are resolved.
4. Run the program, and follow the on-screen instructions to input process details and select the desired scheduling algorithm.
5. The program will display the results, including the waiting times and execution order for each process.

Feel free to explore the code, modify it, and implement additional scheduling algorithms or features as per your requirements.