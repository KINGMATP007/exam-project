
int[] MyMethod(int[] input)
{
    List<int> MyList = new List<int>();
    foreach (int i in input)
    {
        if (MyList.Contains(i) == false)
        {
            MyList.Add(i);
        }

    }
    return MyList.ToArray();
}