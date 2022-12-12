﻿using System;

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
            {
                // If REAR is at the last position of the array, then the value of
                // REAR is set to 0 that corresponds to the first position of the array
                if (REAR == max -1)
                    REAR = 0;
                else
                    // If REAR os mpot at the last posotion, the its valur is incremented by one
                    REAR = REAR + 1;
            }
            // once the position of REAR is determined, the element is added at its proper place
            queue_array[REAR] = element;
        }
        public void remove()
        {
            // Checks wheather the queue is empty
            if (FRONT == -1)
            {
                Console.WriteLine("Queue underflow\n");
                return ;
            }
            Console.WriteLine("\nThe Element deleted fromt he queue is: " + queue_array[FRONT]
                + "\n");
            // Check if the queue has one lement
            if (FRONT == REAR)
            {
                FRONT = -1;
                REAR = -1;
            }
            else
            {
                // if the element to be deleted is at the last position of the arrray, then the value
                // of FRONT is set to 0 i.e to the first element of the array
                FRONT = 
            }
        }
    }
}