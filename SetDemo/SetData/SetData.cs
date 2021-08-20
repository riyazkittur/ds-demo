using System;

namespace SetData
{
    public class SetData
    {
        public int ElementsCount = 0;
        public object[] Elements = new object[5];
        public bool IsEmpty()
        {
            return ElementsCount==0;
        }
        public void Add(object element)
        {
            
            Elements[ElementsCount] = element;
            ElementsCount += 1;
            
        }
        public int Count()
        {
            return ElementsCount;
        }
        public bool Contains(object element)
        {
            for(int i = 0;i< Elements.Length; i++)
            {
                return element.Equals(Elements[i]);
            }
        return false;
        }
      
    }
}
