
int[] MyArray = { 1, 3, 3, 3, 2, 5, 6, 7 };
List<int> MyList = new List<int>();
foreach (int i in MyArray)
{
    if (MyList.Contains(i) == false)
    { MyList.Add(i); }
}
int[] SortedArray = MyList.ToArray();