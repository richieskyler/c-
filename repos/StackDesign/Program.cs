namespace StackDesign
{
    public class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine(stack);

            Console.WriteLine(stack.Pop()); // Removes the Last object 3
            Console.WriteLine(stack.Pop()); // Removes the Next Last 2
            Console.WriteLine(stack.Pop()); // Removes 1
        }
    }

}