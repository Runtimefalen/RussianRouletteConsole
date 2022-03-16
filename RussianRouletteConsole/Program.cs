int m = 10;
int n = 15;
int[,] array = new int[m, n];

for (int i = 0; i < m; i++)
{

    for (int j = 0; j < n; j++)
    {

        if (i - n  == j - m )
        {
            array[i, j] = 1;
        }
    }
}


/*
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
