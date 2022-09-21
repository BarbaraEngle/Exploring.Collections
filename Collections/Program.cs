using System.Collections;

namespace Exploring.Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //----------------------------------------------------//
            //--- System.Collections - Non Generic Collections ---//
            //----------------------------------------------------//

            //The ArrayList
            //-------------
            //An ArrayList is an array with a size that's dynamically increased as required
            //The ArrayList is designed to hold HETEROGENEOUS collections of objects

            //1.  Create and initialise the list - note that the size is not specified.
            ArrayList anArrayList = new ();

            //2.  Populate the ArrayList.
            Random random = new();
            for (int i = 0; i < 10; i++)
            {
                anArrayList.Add(random.Next());
            }

            //3. Print out the type of the Array List.
            Console.WriteLine($"The type of this collection is:  {anArrayList.GetType()}");
            Console.WriteLine();

            //4.  Print out the value of each item in the ArrayList.
            Console.WriteLine("The value of each item in the ArrayList: ");
            foreach (var item in anArrayList)
            {
                Console.Write($" {item} \t");
            }
            Console.WriteLine();

            //5. The Count Method indicates the no. of items in the ArrayList.
            Console.WriteLine();
            Console.WriteLine($"There are {anArrayList.Count} items in the ArrayList.");
            Console.WriteLine();

            //6. Retrieve an item by index.
            Console.WriteLine($"The value of Index[3] is: {anArrayList[3]}");
            Console.WriteLine();

            //7.  Remove an item by index.
            anArrayList.RemoveAt(3);
            Console.WriteLine($"After removing the item at index 3, There are now {anArrayList.Count} items in the ArrayList.");
            Console.WriteLine($"The value at index[3] is now: {anArrayList[3]}");
            Console.WriteLine();

            //8.  Note that the Capacity of an ArrayList will always be greater or equal to count.
            Console.WriteLine($"The Capacity of this ArrayList is {anArrayList.Capacity}");
            Console.WriteLine();

            //9. Add more entries to the ArrayList.
            for (int i = 0; i < 10; i++)
            {
                anArrayList.Add(random.Next());
            }

            //10.  Show that the capacity has increased to be more than the new count.
            Console.WriteLine("10 New items have now been added to the ArrayList.");
            Console.WriteLine($"There are now {anArrayList.Count} items in the ArrayList, and the capacity is {anArrayList.Capacity}.");
            Console.WriteLine();

            //  The BitArray
            //---------------
            //An array of bit values, represented as Booleans
            //true means the bit is on (1)
            //false means the bit is off (0)

            //1.  Create and Initialise the BitArray
            //    The default value of a BitArray is False

            BitArray myBitArray1 = new (5);
            Console.WriteLine($"The type of this collection is:  {myBitArray1.GetType()}");
            Console.WriteLine();


            Console.WriteLine("The default value of a BitArray is false:");
            foreach (var bit in myBitArray1)
            {
                Console.Write($"{bit} \t");
            }
            Console.WriteLine();
            Console.WriteLine();

            //2. You can set the default value to true.
            Console.WriteLine("The default value of a BitArray can be set to true:");

            BitArray myBitArray2 = new (5, true);

            foreach (var bit in myBitArray2)
            {
                Console.Write($"{bit} \t");
            }
            Console.WriteLine();
            Console.WriteLine();

            //3.  You can also create a BitArray based off a series of Bytes.
            Console.WriteLine("You can create a BitArray from a series of Bytes:");

            byte[] myBytes = new byte[5] {1,2,3,4,5};
            BitArray myBitArray3 = new (myBytes);

            foreach (var bit in myBitArray3)
            {
                Console.Write($"{bit} \t");
            }
            Console.WriteLine();
            Console.WriteLine();

            //4.  You can also create a BitArray based off a series of Booleans.
            Console.WriteLine("You can create a BitArray from a series of Booleans:");
            bool[] myBools = new bool[5] { true,true,false,false,false };
            BitArray myBitArray4 = new (myBools);

            foreach (var bit in myBitArray4)
            {
                Console.Write($"{bit} \t");
            }
            Console.WriteLine();
            Console.WriteLine();

            //5.  You can also create a BitArray based off a series of Integers.
            Console.WriteLine("You can create a BitArray from a series of Integers:");

            int[] myInts = new int[5] { 1,2,3,4,5 };
            BitArray myBitArray5 = new (myInts);

            foreach (var bit in myBitArray5)
            {
                Console.Write($"{bit} \t");
            }
            Console.WriteLine();
            Console.WriteLine();

            //The Comparer Class
            //-------------------
            //This class compares two objects of the same type and indicates whether they are
            //bigger,smaller or equal

            Console.WriteLine("Examples of the use of the Comparer Class:");
            //1.  Create strings to compare

            string str1 = "Barbara";
            string str2 = "Engle";
            string str3 = "Lillian";

            Console.WriteLine("InvariantComparer: {0} with {1} and {2};",
                Comparer.DefaultInvariant.Compare(str1, str2), str1, str2);

            Console.WriteLine("InvariantComparer: {0} with {1} and {2};",
               Comparer.DefaultInvariant.Compare(str2, str3), str2, str3);

            Console.WriteLine();
            Console.WriteLine();

            //The Hashtable
            //-------------
            Hashtable cars = new()
            {
                { "green", "Land Rover" },
                { "orange", "Escort" },
                { "purple", "Porche" },
                {"red", "Mini" }
            };

            Console.WriteLine($"The type of this collection is: {cars.GetType()}.");

            Console.WriteLine("The items in this Hashtable are:");

            foreach (DictionaryEntry de in cars) 
            {
                Console.WriteLine($"Key: {de.Key}, Value: {de.Value}");
            }
            Console.WriteLine();
            Console.WriteLine();

            //The SortedList
            //--------------
            //A collection of key/value pairs that are sorted by keys
            //The items in a SortedList are accessible by key or by index

            //1.  Create and initialise a new SortedList
            SortedList mySortedList = new();

            mySortedList.Add(1, "OYSTER");
            mySortedList.Add(2, "Porcupine");
            mySortedList.Add(4, "Octopus");
            mySortedList.Add(3, "Shark");

            Console.WriteLine($"This collection is of type {mySortedList.GetType()}.");

            Console.WriteLine($"Count: {mySortedList.Count}");
            Console.WriteLine($"Capacity: {mySortedList.Capacity}");
            Console.WriteLine($"Keys and Values:");

            for (int i = 0; i < mySortedList.Count; i++)
            {
                Console.WriteLine( $"{mySortedList.GetKey(i)} {mySortedList.GetByIndex(i)}");
            }
            Console.WriteLine();
            Console.WriteLine();

            //The Queue
            //---------
            //A first-in, first-out collection of objects (FIFO)
            //A temporary storage because once you retrieve the value it is discarded.

            //1.  Create and initialise a new Queue.

            Queue myQueue = new ();

            myQueue.Enqueue("Oyster");
            myQueue.Enqueue("Prawn");
            myQueue.Enqueue("Octopus");
            myQueue.Enqueue("Lobster");

            Console.WriteLine($"This collection is of type {myQueue.GetType()}.");


            Console.WriteLine($"Count: {myQueue.Count}");

            Console.WriteLine("Values: ");

            foreach (var item in myQueue)
            {
                Console.Write($"{item} \t");
            }

            Console.WriteLine();

            Console.WriteLine("Now an item is retrieved:");
           
            Console.WriteLine($"{myQueue.Dequeue()}");
           
            Console.WriteLine($"Count after dequeueing: {myQueue.Count}");

            Console.WriteLine($"You can use Peek to look, but not remove:");
            Console.WriteLine($"{myQueue.Peek()}");

            Console.WriteLine($"Count after Peeking at the item at the top of the queue: {myQueue.Count}");


            Console.WriteLine();
            Console.WriteLine();

            //The Stack
            //---------
            //Very similar to the queue, except that is is Last-in, First-out (LIFO)

            //1.  Create and initialise a new Queue.

            Stack myStack = new();

            myStack.Push("Oyster");
            myStack.Push("Prawn");
            myStack.Push("Octopus");
            myStack.Push("Lobster");

            Console.WriteLine($"This collection is of type {myStack.GetType()}.");

            Console.WriteLine($"Count: {myStack.Count}");

            Console.WriteLine("Values: ");

            foreach (var item in myStack)
            {
                Console.Write($"{item} \t");
            }

            Console.WriteLine();

            Console.WriteLine("Now an item is retrieved:");

            Console.WriteLine($"{myStack.Pop()}");

            Console.WriteLine($"Count after Popping: {myStack.Count}");

            Console.WriteLine($"You can use Peek to look, but not remove:");
            Console.WriteLine($"{myStack.Peek()}");

            Console.WriteLine($"Count after Peeking at the item at the top of the queue: {myStack.Count}");


            Console.WriteLine();
            Console.WriteLine();




        }
    }
} 