using System;
using System.Collections.Generic;

namespace GenericCollections
{
    public class Visitor
    {
        public string Name { get; set; }
        public bool VIP { get; set; }

        public Visitor(string name, bool isVip)
        {
            Name = name;
            VIP = isVip;
        }
    }

    public class CafeQueue
    {
        private int freePlaces;
        private Queue<Visitor> queue = new Queue<Visitor>(); 
        private Queue<Visitor> vipQueue = new Queue<Visitor>(); 
        public int Free
        {
            get => freePlaces; set => freePlaces = value;
        }

        public CafeQueue(int totalPlaces)
        {
            freePlaces = totalPlaces;
        }

        public void AddVisitor(Visitor visitor)
        {
            if (visitor.VIP)
                vipQueue.Enqueue(visitor); 
            else
                queue.Enqueue(visitor);  

            Console.WriteLine($"Visitor {visitor.Name} added to the queue.");
        }

        public void LeftFromCafe()
        {
            Console.WriteLine("Someone left from the cafe");
            Free++;
        }


        public void RemoveVisitor()
        {
            if (Free > 0)
            {
                if (vipQueue.Count > 0 )
                {
                    Visitor visitor = vipQueue.Dequeue();
                    Console.WriteLine($"Visitor {visitor.Name} (VIP) got to his table.");
                    Free--;
                }
                else if (queue.Count > 0)
                {
                    Visitor visitor = queue.Dequeue();
                    Console.WriteLine($"Visitor {visitor.Name} got to his table.");
                    Free--;
                }

                else
                {
                    Console.WriteLine("Queues are empty");
                }

            }

            else
            {
                Console.WriteLine("No free places in the cafe.");
            }

        }

        public int GetAvailablePlaces()
        {
            return freePlaces;
        }

        public void PrintQueue()
        {
            if (vipQueue.Count == 0 && queue.Count == 0)
            {
                Console.WriteLine("No visitors in the cafe.");
            }
            else
            {
                Console.WriteLine("Visitors in the cafe:");

                Console.WriteLine("VIP Queue:");
                foreach (var visitor in vipQueue)
                {
                    Console.WriteLine($"{visitor.Name} (VIP: {visitor.VIP})");
                }

                Console.WriteLine("Regular Queue:");
                foreach (var visitor in queue)
                {
                    Console.WriteLine($"{visitor.Name} (VIP: {visitor.VIP})");
                }
            }
        }
    }

}