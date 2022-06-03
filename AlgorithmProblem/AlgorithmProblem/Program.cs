//----p1-------//
    String str = "ABC";
    int n = str.Length;
    AlgorithmProblem.StaticProgram.permute(str, 0, n - 1);

//---------------p2---------------//
    String[] arr = { "chinki", "kumari", "singh", "strong" };
    String x = "strong";
    int result = AlgorithmProblem.StaticProgram.binarySearch(arr, x);

    if (result == -1)
        Console.WriteLine("Element not present");
    else
        Console.WriteLine("Element found at " + "index " + result);

//-------------------------------p3---------//

    string[] names = { "John Doe", "Doe John", "Suman singh", "chinki singh" };
    AlgorithmProblem.StaticProgram.InsertSort(names);
    foreach (var item in names)
    {
        Console.WriteLine(item);
    }
