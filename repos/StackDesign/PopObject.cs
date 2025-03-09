using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackDesign
{
    public class PopObject
    {
        public Object Pop(object obj, List<object> stack)
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
    }
}
