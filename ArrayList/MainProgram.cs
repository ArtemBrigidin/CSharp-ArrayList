using ArrayListLibray;

class MainProgram
{
    static void Main(string[] args)
    {
        ArrayList list = new ArrayList();
        list.Add(1);
        list.Add(2);
        list.Add(4);

        list.Print();

        //list.Increathlength();
        //// 1
        //list.Add(300, 200);
        list.Add(5, 4);
        list.Add(0, 5);
        list.Add(1, 6);
        list.Print();

        //// 2
        //list.DecreaseLength(1);
        //list.Print();

        //// 3
        //list.RemoveAt(4);
        //list.Print();

        //// 4
        //list.Remove(2);
        //list.Print();

        //// 5
        //list.FindMax();

        //// 6
        //list.FindMin();
        //list.Print();
    }
}