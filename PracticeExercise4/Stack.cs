
using System;
using System.Collections.Generic;

namespace PracticeExercise4
{
    public class Stack<T> : IStack<T>
    {
        private LinkedList<T> linkedList;

        public Stack()
        {
            linkedList = new LinkedList<T>();
        }

        public bool IsEmpty => linkedList.Count == 0;

        public int Length => linkedList.Count;

        public T Front => linkedList.First.Value;

        public T Back => linkedList.Last.Value;

        public T Peek()
        {
            //throw new NotImplementedException();
            //if (IsEmpty) 
            //{
            //    throw new EmptyStackException();
            //}
           
            
            T peekstack = linkedList.First.Value;
            linkedList.RemoveFirst();
            return peekstack;
            

        }

        public T Pop()
        {
            if( IsEmpty)
            {
                throw new EmptyStackException();
            }

            T topOfStack = linkedList.Last.Value;
            linkedList.RemoveLast();

            return topOfStack;
        }

        public void Push(T item)
        {
            linkedList.AddLast( item );
        }

        public override string ToString()
        {
            string result = "";

            var currentNode = linkedList.Last;


            while (currentNode != null)

            while( currentNode != null)

            {
                result += currentNode.Value + "\n";
                currentNode = currentNode.Previous;
            }

            return result;


        }


        }


        }
    


