using System;

namespace CircularQueues
{
    class Program
    {
        int FRONT, REAR, max = 5;
        int[] queue_array = new int[5];
        public Program()
        {
            // Initializing the value of the variables REAR and FRONT to -1 ti inndicate that the queue is initially empty
            FRONT = -1;
            REAR = -1;
        }
        public void insert(int element)
        {
            // this statement checks for the overflow condition
            if ((FRONT == 0 && REAR == max - 1) || (FRONT == REAR +1))
            {
                Console.WriteLine("\nQueue overflow\n");
                return;
            }
            // this following statement checks whether the queue is empty.
            // If the queue is empty, then the value of the REAR and FRONT variables is set to 0
            if (FRONT == -1)
            {
                FRONT = 0;
                REAR = 0;
            }
            else 
        }
    }
}