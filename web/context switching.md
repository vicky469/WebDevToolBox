### Context Switching

Context switching is the process where the CPU (Central Processing Unit) stops executing one task (or process or thread) and starts executing another. It involves storing the state of the old task and loading the saved state for the new task.

However, context switching is not "free" in terms of system resources. Here's why:

CPU Time: During a context switch, the CPU is not doing any "useful" work from the perspective of the tasks. The CPU cycles are used to save and load task states, not to make progress on the tasks themselves.

Memory: Context switching involves memory operations. The state of a task (register values, program counter, etc.) has to be stored in memory before the switch and loaded from memory after the switch.

Cache Performance: Modern CPUs have cache memory that stores data for fast access. When a context switch occurs, the cache for the old task might no longer be relevant for the new task, leading to cache misses and slower performance.

System Stability: Frequent context switching can lead to "thrashing," where the system spends more time switching between tasks than doing actual work.
