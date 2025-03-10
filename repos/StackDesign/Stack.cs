using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackDesign
{
    public class Stack : PopObject
    {
        //Creating a list to store various object
        private List<object> stack = new List<object>();

        // Push method to add an object to the stack
        public void Push(object obj)
        {
            if (obj == null)
            {
                throw new InvalidOperationException("Cannot push null onto the stack.");
            }

            //Adds the obj to the list after passing the validation
            stack.Add(obj);
        }

        // Pop method to remove and return the top object from the stack
        public Object Pop()
        {
            if (stack.Count == 0)
            {
                throw new InvalidOperationException("Cannot pop from an empty stack");
            }

            int lastIndex = stack.Count - 1;
            object lastItem = stack[lastIndex];
            stack.RemoveAt(lastIndex);
            return lastItem;
        }

        // Clear method to remove all objects from the stack
        public void Clear()
        {
            stack.Clear();
        }


    }   
}
