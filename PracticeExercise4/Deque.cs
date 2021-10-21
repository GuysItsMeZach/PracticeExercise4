using System;
using System.Collections.Generic;
namespace PracticeExercise4
{
    public class Deque<T> 
    {
        public LinkedList<T> linkedList = new LinkedList<T>();

        public Deque()
        {

        }

       
        public T Front => linkedList.First.Value;

        public T Back => linkedList.Last.Value;

        public bool IsEmpty => linkedList.Count == 0;

        public int Length => linkedList.Count;

        public void AddFront(T item)
        {
            linkedList.AddFirst(item);
        }

        public void AddBack(T item)
        {
            linkedList.AddLast(item);
        }

        public T RemoveFront()
        {
            if (IsEmpty)
            {
                throw new EmptyQueueException();
            }

            T front = Front;
            linkedList.RemoveFirst();

            return front;


        }

        public T RemoveBack()
        {
            if (IsEmpty)
            {
                throw new EmptyQueueException();
            }

            T back = Back;
            linkedList.RemoveLast();

            return back;


        }

        public override string ToString()
        {
            string result = "<Back> ";

            var currentNode = linkedList.Last;
            while (currentNode != null)
            {
                result += currentNode.Value;
                if (currentNode.Previous != null)
                    if (currentNode.Previous != null)
                    {
                        result += " → ";
                    }
                currentNode = currentNode.Previous;
            }

            result += " <Front>";


            return result;
        }


    }
}
