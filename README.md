# Process Scheduling Program

This simple console application is based on First-Come, First-Serve (FCFS) and Shortest Job First (SJF) scheduling algorithms. It is currently under development to include more algorithms, and a Gantt chart feature is yet to be implemented.

## FCFS Algorithm

The core logic of the FCFS algorithm is straightforward. First process always has a waiting time of 0. The waiting time of a process is calculated based on the burst time of the previous process and the waiting time of the previous process. The execution order follows the order of arrival.

## SJF Algorithm
The SJF algorithm relies on a condition-based while loop to sort incoming processes while other processes are still running. It ensures that the burst time of a process becomes zero, indicating its completion, before moving on to the next process. The algorithm prioritizes shorter burst times, aiming to minimize waiting times.

*Note: This program is a basic representation of scheduling algorithms and is expected to evolve with additional features and algorithms in future updates like SRTF, preemptive priority scheduling and also providing the gantt chart for the workflow.*
