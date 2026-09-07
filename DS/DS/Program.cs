namespace DS { 
class MyArray
{
    private int[] arr;
    private int count;
    private int capacity;

    public MyArray(int size)
    {
        capacity = size;
        arr = new int[capacity];
        count = 0;
    }

    public void Push(int value)
    {
        if (count == capacity)
        {
            capacity = capacity * 2;
            int[] newArr = new int[capacity];

            for (int i = 0; i < count; i++)
            {
                newArr[i] = arr[i];
            }

            arr = newArr;
        }

        arr[count] = value;
        count++;
    }
    public int pop()
    {
        count--;
        return arr[count];
    }

       public int Peek()
        {
            if (count==0)
            {
                Console.WriteLine("Array is empty");
                return -1;
            }
            return arr[count - 1];
        }

        public bool IsEmpty()
    {
        return count == 0;
    }

    public void Display()
    {
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}

    internal class Program
    {
        static void Main(string[] args)
        {
           
            MyArray array = new MyArray(2);

           array.Push(10);
          array.Push(20);
            array.Push(30);
            array.pop();

         Console.WriteLine("Peek: " + array.Peek());

           





        }
    }
}
