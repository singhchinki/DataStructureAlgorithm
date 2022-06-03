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
//------------------p4-------------------------//

AlgorithmProblem.StaticProgram staticProgram = new AlgorithmProblem.StaticProgram();
    int[] array = { 64, 34, 25, 12, 22, 11, 90 };
    AlgorithmProblem.StaticProgram.bubbleSort(array);
    Console.WriteLine("Sorted array");
    AlgorithmProblem.StaticProgram.print_Array(array);

//-------------------p5-------------------------//

AlgorithmProblem.StaticProgram merge = new AlgorithmProblem.StaticProgram();
    int[] array_merge = { 12, 11, 13, 5, 6, 7 };
    Console.WriteLine("Given Array");
    AlgorithmProblem.StaticProgram.printArrayMerge();
    Merge ob = new MergeSort();
    ob.sort(arr, 0, arr.Length - 1);
    Console.WriteLine("\nSorted array");
    printArrayMerge(array_merge);



