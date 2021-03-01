var someNumbers = { 4, 3, 2, 1 };

var processed = someNumbers
        .Select(n => n * 2)   // Multiply each number by 2
        .Where(n => n != 6)   // Keep all the results, except for 6
        .OrderBy(n => n);     // Sort in ascending order