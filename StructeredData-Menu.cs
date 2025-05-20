using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataStructuresMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("=== Data Structures and Algorithms Menu ===");
                Console.WriteLine("1. Matrix Operations");
                Console.WriteLine("2. Vector Operations");
                Console.WriteLine("3. Stack Operations");
                Console.WriteLine("4. Queue Operations");
                Console.WriteLine("5. List Operations");
                Console.WriteLine("6. Search Algorithms");
                Console.WriteLine("0. Exit");
                Console.Write("Select an option: ");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            MatrixMenu();
                            break;
                        case 2:
                            VectorMenu();
                            break;
                        case 3:
                            StackMenu();
                            break;
                        case 4:
                            QueueMenu();
                            break;
                        case 5:
                            ListMenu();
                            break;
                        case 6:
                            SearchAlgorithmsMenu();
                            break;
                        case 0:
                            exit = true;
                            Console.WriteLine("Exiting program...");
                            break;
                        default:
                            Console.WriteLine("Invalid option. Please try again.");
                            Console.ReadKey();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a NUMBER.");
                    Console.ReadKey();
                }
            }
        }

        static void ReturnToMainMenu()
        {
            Console.WriteLine("\nPress any key to return to the main menu...");
            Console.ReadKey();
        }

        static int GetIntegerInput(string prompt)
        {
            int value;
            while (true)
            {
                Console.Write(prompt);
                if (int.TryParse(Console.ReadLine(), out value))
                {
                    return value;
                }
                Console.WriteLine("Invalid input. Please enter a NUMBER.");
            }
        }

        static void MatrixMenu()
        {
            bool back = false;
            int[,] matrix = null;

            while (!back)
            {
                Console.Clear();
                Console.WriteLine("=== Matrix Operations ===");
                Console.WriteLine("1. Create Matrix");
                Console.WriteLine("2. Insert Element");
                Console.WriteLine("3. Remove Element");
                Console.WriteLine("4. Display Matrix");
                Console.WriteLine("5. Search Element");
                Console.WriteLine("0. Back to Main Menu");
                Console.Write("Select an option: ");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            int rows = GetIntegerInput("Enter number of rows: ");
                            int cols = GetIntegerInput("Enter number of columns: ");
                            matrix = new int[rows, cols];
                            Console.WriteLine("Enter matrix elements:");
                            for (int i = 0; i < rows; i++)
                            {
                                for (int j = 0; j < cols; j++)
                                {
                                    matrix[i, j] = GetIntegerInput($"Element [{i},{j}]: ");
                                }
                            }
                            Console.WriteLine("Matrix created successfully!");
                            break;
                        case 2:
                            if (matrix == null)
                            {
                                Console.WriteLine("Matrix not created yet!");
                                break;
                            }
                            int row = GetIntegerInput("Enter row index: ");
                            int col = GetIntegerInput("Enter column index: ");
                            if (row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1))
                            {
                                int value = GetIntegerInput("Enter value to insert: ");
                                matrix[row, col] = value;
                                Console.WriteLine("Element inserted successfully!");
                            }
                            else
                            {
                                Console.WriteLine("Invalid row or column index!");
                            }
                            break;
                        case 3:
                            if (matrix == null)
                            {
                                Console.WriteLine("Matrix not created yet!");
                                break;
                            }
                            int r = GetIntegerInput("Enter row index: ");
                            int c = GetIntegerInput("Enter column index: ");
                            if (r >= 0 && r < matrix.GetLength(0) && c >= 0 && c < matrix.GetLength(1))
                            {
                                matrix[r, c] = 0;
                                Console.WriteLine("Element removed successfully!");
                            }
                            else
                            {
                                Console.WriteLine("Invalid row or column index!");
                            }
                            break;
                        case 4:
                            if (matrix == null)
                            {
                                Console.WriteLine("Matrix not created yet!");
                                break;
                            }
                            Console.WriteLine("Matrix:");
                            for (int i = 0; i < matrix.GetLength(0); i++)
                            {
                                for (int j = 0; j < matrix.GetLength(1); j++)
                                {
                                    Console.Write(matrix[i, j] + "\t");
                                }
                                Console.WriteLine();
                            }
                            break;
                        case 5:
                            if (matrix == null)
                            {
                                Console.WriteLine("Matrix not created yet!");
                                break;
                            }
                            int searchValue = GetIntegerInput("Enter value to search: ");
                            bool found = false;
                            for (int i = 0; i < matrix.GetLength(0); i++)
                            {
                                for (int j = 0; j < matrix.GetLength(1); j++)
                                {
                                    if (matrix[i, j] == searchValue)
                                    {
                                        Console.WriteLine($"Value found at position [{i},{j}]");
                                        found = true;
                                    }
                                }
                            }
                            if (!found) Console.WriteLine("Value not found in matrix.");
                            break;
                        case 0:
                            back = true;
                            break;
                        default:
                            Console.WriteLine("Invalid option. Please try again.");
                            break;
                    }
                    if (!back) ReturnToMainMenu();
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a NUMBER.");
                }
            }
        }

        static void VectorMenu()
        {
            bool back = false;
            int[] vector = null;

            while (!back)
            {
                Console.Clear();
                Console.WriteLine("=== Vector Operations ===");
                Console.WriteLine("1. Create Vector");
                Console.WriteLine("2. Insert Element");
                Console.WriteLine("3. Remove Element");
                Console.WriteLine("4. Display Vector");
                Console.WriteLine("5. Search Element");
                Console.WriteLine("0. Back to Main Menu");
                Console.Write("Select an option: ");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            int size = GetIntegerInput("Enter vector size: ");
                            vector = new int[size];
                            Console.WriteLine("Enter vector elements:");
                            for (int i = 0; i < size; i++)
                            {
                                vector[i] = GetIntegerInput($"Element [{i}]: ");
                            }
                            Console.WriteLine("Vector created successfully!");
                            break;
                        case 2:
                            if (vector == null)
                            {
                                Console.WriteLine("Vector not created yet!");
                                break;
                            }
                            int index = GetIntegerInput("Enter index to insert: ");
                            if (index >= 0 && index < vector.Length)
                            {
                                int value = GetIntegerInput("Enter value to insert: ");
                                vector[index] = value;
                                Console.WriteLine("Element inserted successfully!");
                            }
                            else
                            {
                                Console.WriteLine("Invalid index!");
                            }
                            break;
                        case 3:
                            if (vector == null)
                            {
                                Console.WriteLine("Vector not created yet!");
                                break;
                            }
                            int removeIndex = GetIntegerInput("Enter index to remove: ");
                            if (removeIndex >= 0 && removeIndex < vector.Length)
                            {
                                vector[removeIndex] = 0;
                                Console.WriteLine("Element removed successfully!");
                            }
                            else
                            {
                                Console.WriteLine("Invalid index!");
                            }
                            break;
                        case 4:
                            if (vector == null)
                            {
                                Console.WriteLine("Vector not created yet!");
                                break;
                            }
                            Console.WriteLine("Vector:");
                            Console.WriteLine(string.Join(", ", vector));
                            break;
                        case 5:
                            if (vector == null)
                            {
                                Console.WriteLine("Vector not created yet!");
                                break;
                            }
                            int searchValue = GetIntegerInput("Enter value to search: ");
                            bool found = false;
                            for (int i = 0; i < vector.Length; i++)
                            {
                                if (vector[i] == searchValue)
                                {
                                    Console.WriteLine($"Value found at index {i}");
                                    found = true;
                                }
                            }
                            if (!found) Console.WriteLine("Value not found in vector.");
                            break;
                        case 0:
                            back = true;
                            break;
                        default:
                            Console.WriteLine("Invalid option. Please try again.");
                            break;
                    }
                    if (!back) ReturnToMainMenu();
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a NUMBER.");
                }
            }
        }

        static void StackMenu()
        {
            bool back = false;
            Stack<int> stack = new Stack<int>();

            while (!back)
            {
                Console.Clear();
                Console.WriteLine("=== Stack Operations ===");
                Console.WriteLine("1. Push (Insert) Element");
                Console.WriteLine("2. Pop (Remove) Element");
                Console.WriteLine("3. Display Stack");
                Console.WriteLine("4. Search Element");
                Console.WriteLine("0. Back to Main Menu");
                Console.Write("Select an option: ");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            int element = GetIntegerInput("Enter element to push: ");
                            stack.Push(element);
                            Console.WriteLine($"Element {element} pushed to stack.");
                            break;
                        case 2:
                            if (stack.Count == 0)
                            {
                                Console.WriteLine("Stack is empty!");
                                break;
                            }
                            Console.WriteLine($"Element {stack.Pop()} popped from stack.");
                            break;
                        case 3:
                            if (stack.Count == 0)
                            {
                                Console.WriteLine("Stack is empty!");
                                break;
                            }
                            Console.WriteLine("Stack contents (top to bottom):");
                            Console.WriteLine(string.Join(", ", stack));
                            break;
                        case 4:
                            if (stack.Count == 0)
                            {
                                Console.WriteLine("Stack is empty!");
                                break;
                            }
                            int searchValue = GetIntegerInput("Enter value to search: ");
                            if (stack.Contains(searchValue))
                            {
                                Console.WriteLine($"Value {searchValue} found in stack.");
                            }
                            else
                            {
                                Console.WriteLine("Value not found in stack.");
                            }
                            break;
                        case 0:
                            back = true;
                            break;
                        default:
                            Console.WriteLine("Invalid option. Please try again.");
                            break;
                    }
                    if (!back) ReturnToMainMenu();
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a NUMBER.");
                }
            }
        }

        static void QueueMenu()
        {
            bool back = false;
            Queue<int> queue = new Queue<int>();

            while (!back)
            {
                Console.Clear();
                Console.WriteLine("=== Queue Operations ===");
                Console.WriteLine("1. Enqueue (Insert) Element");
                Console.WriteLine("2. Dequeue (Remove) Element");
                Console.WriteLine("3. Display Queue");
                Console.WriteLine("4. Search Element");
                Console.WriteLine("0. Back to Main Menu");
                Console.Write("Select an option: ");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            int element = GetIntegerInput("Enter element to enqueue: ");
                            queue.Enqueue(element);
                            Console.WriteLine($"Element {element} added to queue.");
                            break;
                        case 2:
                            if (queue.Count == 0)
                            {
                                Console.WriteLine("Queue is empty!");
                                break;
                            }
                            Console.WriteLine($"Element {queue.Dequeue()} removed from queue.");
                            break;
                        case 3:
                            if (queue.Count == 0)
                            {
                                Console.WriteLine("Queue is empty!");
                                break;
                            }
                            Console.WriteLine("Queue contents (front to rear):");
                            Console.WriteLine(string.Join(", ", queue));
                            break;
                        case 4:
                            if (queue.Count == 0)
                            {
                                Console.WriteLine("Queue is empty!");
                                break;
                            }
                            int searchValue = GetIntegerInput("Enter value to search: ");
                            if (queue.Contains(searchValue))
                            {
                                Console.WriteLine($"Value {searchValue} found in queue.");
                            }
                            else
                            {
                                Console.WriteLine("Value not found in queue.");
                            }
                            break;
                        case 0:
                            back = true;
                            break;
                        default:
                            Console.WriteLine("Invalid option. Please try again.");
                            break;
                    }
                    if (!back) ReturnToMainMenu();
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a NUMBER.");
                }
            }
        }

        static void ListMenu()
        {
            bool back = false;
            List<int> list = new List<int>();

            while (!back)
            {
                Console.Clear();
                Console.WriteLine("=== List Operations ===");
                Console.WriteLine("1. Add (Insert) Element");
                Console.WriteLine("2. Remove Element");
                Console.WriteLine("3. Display List");
                Console.WriteLine("4. Search Element");
                Console.WriteLine("0. Back to Main Menu");
                Console.Write("Select an option: ");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            int element = GetIntegerInput("Enter element to add: ");
                            list.Add(element);
                            Console.WriteLine($"Element {element} added to list.");
                            break;
                        case 2:
                            int toRemove = GetIntegerInput("Enter element to remove: ");
                            if (list.Remove(toRemove))
                            {
                                Console.WriteLine($"Element {toRemove} removed from list.");
                            }
                            else
                            {
                                Console.WriteLine("Element not found in list.");
                            }
                            break;
                        case 3:
                            if (list.Count == 0)
                            {
                                Console.WriteLine("List is empty!");
                                break;
                            }
                            Console.WriteLine("List contents:");
                            Console.WriteLine(string.Join(", ", list));
                            break;
                        case 4:
                            if (list.Count == 0)
                            {
                                Console.WriteLine("List is empty!");
                                break;
                            }
                            int searchValue = GetIntegerInput("Enter value to search: ");
                            int index = list.IndexOf(searchValue);
                            if (index >= 0)
                            {
                                Console.WriteLine($"Value found at index {index}.");
                            }
                            else
                            {
                                Console.WriteLine("Value not found in list.");
                            }
                            break;
                        case 0:
                            back = true;
                            break;
                        default:
                            Console.WriteLine("Invalid option. Please try again.");
                            break;
                    }
                    if (!back) ReturnToMainMenu();
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a NUMBER.");
                }
            }
        }

        static void SearchAlgorithmsMenu()
        {
            bool back = false;
            int[] array = null;

            while (!back)
            {
                Console.Clear();
                Console.WriteLine("=== Search Algorithms ===");
                Console.WriteLine("1. Create Array");
                Console.WriteLine("2. Insert Element");
                Console.WriteLine("3. Remove Element");
                Console.WriteLine("4. Display Array");
                Console.WriteLine("5. Linear Search");
                Console.WriteLine("6. Binary Search");
                Console.WriteLine("0. Back to Main Menu");
                Console.Write("Select an option: ");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            int size = GetIntegerInput("Enter array size: ");
                            array = new int[size];
                            Console.WriteLine("Enter array elements (sorted for binary search):");
                            for (int i = 0; i < size; i++)
                            {
                                array[i] = GetIntegerInput($"Element [{i}]: ");
                            }
                            Console.WriteLine("Array created successfully!");
                            break;
                        case 2:
                            if (array == null)
                            {
                                Console.WriteLine("Array not created yet!");
                                break;
                            }
                            int index = GetIntegerInput("Enter index to insert: ");
                            if (index >= 0 && index < array.Length)
                            {
                                int value = GetIntegerInput("Enter value to insert: ");
                                array[index] = value;
                                Console.WriteLine("Element inserted successfully!");
                            }
                            else
                            {
                                Console.WriteLine("Invalid index!");
                            }
                            break;
                        case 3:
                            if (array == null)
                            {
                                Console.WriteLine("Array not created yet!");
                                break;
                            }
                            int removeIndex = GetIntegerInput("Enter index to remove: ");
                            if (removeIndex >= 0 && removeIndex < array.Length)
                            {
                                array[removeIndex] = 0;
                                Console.WriteLine("Element removed successfully!");
                            }
                            else
                            {
                                Console.WriteLine("Invalid index!");
                            }
                            break;
                        case 4:
                            if (array == null)
                            {
                                Console.WriteLine("Array not created yet!");
                                break;
                            }
                            Console.WriteLine("Array:");
                            Console.WriteLine(string.Join(", ", array));
                            break;
                        case 5:
                            if (array == null)
                            {
                                Console.WriteLine("Array not created yet!");
                                break;
                            }
                            int linearValue = GetIntegerInput("Enter value to search: ");
                            bool linearFound = false;
                            for (int i = 0; i < array.Length; i++)
                            {
                                if (array[i] == linearValue)
                                {
                                    Console.WriteLine($"Value found at index {i}.");
                                    linearFound = true;
                                    break;
                                }
                            }
                            if (!linearFound) Console.WriteLine("Value not found in array.");
                            break;
                        case 6:
                            if (array == null)
                            {
                                Console.WriteLine("Array not created yet!");
                                break;
                            }
                            int binaryValue = GetIntegerInput("Enter value to search: ");
                            int result = Array.BinarySearch(array, binaryValue);
                            if (result >= 0)
                            {
                                Console.WriteLine($"Value found at index {result}.");
                            }
                            else
                            {
                                Console.WriteLine("Value not found in array.");
                            }
                            break;
                        case 0:
                            back = true;
                            break;
                        default:
                            Console.WriteLine("Invalid option. Please try again.");
                            break;
                    }
                    if (!back) ReturnToMainMenu();
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a NUMBER.");
                }
            }
        }
    }
}