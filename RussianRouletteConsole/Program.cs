int m = 10;
int n = 15;
int[,] array = new int[m, n];

for (int i = 0; i < m; i++)
{
    var multiplierVert = (int) Math.Round(i / n, digits: 0);
    
    for (int j = 0; j < n; j++)
    {
        var multiplierHor = (int) Math.Round(j / m, digits: 0);
        
        if (i - n * multiplierVert == j - m * multiplierHor)
        {
            array[i, j] = 1;
        }
    }
}

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(array[i,j]);
        Console.Write(" ");
    }
    Console.WriteLine();
}
/*
 * 
 * удалил
for (int i = 0; i < m; i++)
{
    bool growDirection = i % 2 == 0;
    
    for (int j = 0; j < n; j++)
    {
        int value = i * n + j;
        int reverseValue = i * n + (n - 1 - j);
                    
        if (growDirection)
            Console.Write(value);
        else 
            Console.Write(reverseValue);
                    
                    
        Console.Write(" ");
    }

    Console.WriteLine();
}*/
