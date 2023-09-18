namespace ArrayListLibray
{
    public class ArrayList
    {
        public int _length { get { return _array.Length; } set { } }
        public int[] _array;
        public int Count { get; private set; }

        public ArrayList()
        {
            _array = new int[7];
            Count = 0;
        }

        public ArrayList(int length)
        {
            _array = new int[length];
            Count = 0;
        }

        public ArrayList(int[] arr)
        {
            int length = (int)(arr.Length * 1.5);
            _array = new int[length];
            for (int i = 0; i < arr.Length; i++)
            {
                _array[i] = arr[i];
            }
            Count = arr.Length;
        }

        public int this[int index]
        {
            get
            {
                if (index > Count - 1)
                {
                    throw new Exception($"row 38, по индексу:{index} нет элемента");
                }
                return _array[index];
            }
            set
            {
                if (index > Count - 1)
                {
                    throw new IndexOutOfRangeException();
                }
                _array[index] = value;
            }
        }

        public void Add(int element)
        {
            if (Count >= _array.Length)
            {
                Increathlength();
            }
            _array[Count++] = element;
        }

        public void Increathlength(int countElements = 1)
        {
            int newLength = _length;
            while (newLength <= _length + countElements)
            {
                newLength = (int)(newLength * 1.5 + countElements);
            }
            int[] newArray = new int[newLength];
            Array.Copy(_array, newArray, _length); _array = newArray;
        }

        public void Print()
        {
            for (int i = 0; i < Count; i++)
            {
                Console.Write(_array[i]);
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        public void Add(int element, int index)
        {
            if (index < Count)
            {
                int[] newArray = new int[_array.Length + 1];

                for (int i = 0; i < index; i++)
                    newArray[i] = _array[i];

                for (int i = index; i < _array.Length; i++)
                    newArray[i + 1] = _array[i];

                newArray[index] = element;
                Count = index + 1;
                _array = newArray;
            }

            else if (index > Count)
            {
                int[] newArray = new int[_array.Length + 1];

                for (int i = 0; i < index; i++)
                {
                    newArray[i] = _array[i];
                }

                newArray[index] = element;

                Count = index + 1;
                _array = newArray;
            }
        }

        public void DecreaseLength(int countElements = 1)
        {
            int newLength = _length - countElements;
            int[] newArray = new int[newLength];
            Count -= countElements;
            for (int i = 0; i < Count; i++)
            {
                newArray[i] = _array[i];
            }
            _array = newArray;
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= Count)
            {
                throw new IndexOutOfRangeException();
            }

            for (int i = index; i < Count - 1; i++)
            {
                _array[i] = _array[i + 1];
            }

            Count--;
        }


        public void Remove(int element)
        {
            int newIndex = 0;
            for (int i = 0; i < Count; i++)
            {
                if (_array[i] != element)
                {
                    _array[newIndex] = _array[i];
                    newIndex++;
                }
            }

            Count = newIndex;
            DecreaseLength(Count - newIndex);
        }

        public void FindMax()
        {
            if (Count == 0)
            {
                throw new Exception("Список пуст.");
            }

            int max = _array[0];
            for (int i = 1; i < Count; i++)
            {
                if (_array[i] > max)
                {
                    max = _array[i];
                }
            }

            Console.WriteLine($"Максимальное число в массиве : {max}");
        }

        public void FindMin()
        {
            if (Count == 0)
            {
                throw new Exception("Список пуст.");
            }

            int min = _array[0];
            for (int i = 1; i < Count; i++)
            {
                if (_array[i] < min)
                {
                    min = _array[i];
                }
            }

            Console.WriteLine($"Минимальное число в массиве : {min}");
        }
    }
}