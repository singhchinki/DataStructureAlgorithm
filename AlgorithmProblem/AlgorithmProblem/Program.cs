
    String str = "ABC";
    int n = str.Length;
    AlgorithmProblem.StaticProgram.permute(str, 0, n - 1);

    String[] arr = { "contribute", "geeks", "ide", "practice" };
    String x = "ide";
    int result = AlgorithmProblem.StaticProgram.binarySearch(arr, x);

    if (result == -1)
        Console.WriteLine("Element not present");
    else
        Console.WriteLine("Element found at "
                        + "index " + result);
