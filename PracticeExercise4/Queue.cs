﻿using System;
using System.Collections.Generic;

namespace PracticeExercise4
{
    public class Queue<T> : IQueue<T>
    {
        private LinkedList<T> linkedList;

        public Queue()
        {
            linkedList = new LinkedList<T>();

        }

        public T First => linkedList.First.Value;

        public T Last => linkedList.Last.Value;

        public bool IsEmpty => linkedList.Count == 0;

        public int Length => linkedList.Count;

        public T Dequeue()
        {
            T firstItem = linkedList.First.Value;

            linkedList.RemoveFirst();

            return firstItem;
        }

        public void Enqueue(T item)
        {
            linkedList.AddLast(item);
        }
    }
}