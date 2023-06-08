﻿Console.WriteLine("Введите номер задачи (54, 56, 58, 62):");
int taskNumber = Convert.ToInt32(Console.ReadLine());
switch (taskNumber)
{
    case 54:
        TaskNumber54();
        break;

    case 56:
        TaskNumber56();
        break;

    case 58:
        TaskNumber58();
        break;

    case 62:
        TaskNumber62();
        break;   
   
    default:
        Console.WriteLine("Вы ввели неверный номер");
        break;
}


void TaskNumber54()
{
    Console.WriteLine();

    Console.WriteLine("Введите длину массива :");
    int arrayLength = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите высоту массива :");
    int arrayHeight = Convert.ToInt32(Console.ReadLine());

    int[,] array2d = new int[arrayHeight,arrayLength];
    for (int i=0; i<array2d.GetLength(0); i++)
    {
        for (int j=0; j<array2d.GetLength(1); j++)
        {
            array2d[i,j] = new Random().Next(0,10);
            Console.Write(array2d[i,j] +" ");
        }
        Console.WriteLine();
    }

    Console.WriteLine( new String('-', arrayLength*2));

    int[,] arrayTemp = new int[arrayHeight,arrayLength];
    int[] arr = new int[arrayLength];
    
    for (int i=0; i<array2d.GetLength(0); i++)
    {
        for (int j=0; j<array2d.GetLength(1); j++)
        {
            for (int l=0; l<array2d.GetLength(1); l++)
            {
                arr[l] = array2d[i,l]; 
            }
            Array.Sort(arr, (x, y) => y.CompareTo(x));
            arrayTemp[i,j]=arr[j];
        }
    }
    
    for (int i=0; i<arrayTemp.GetLength(0); i++)
    {
        for (int j=0; j<arrayTemp.GetLength(1); j++)
        {   
            Console.Write(arrayTemp[i,j] +" ");
        }
        Console.WriteLine();
    }

}


void TaskNumber56()
{
    Console.WriteLine();

    Console.WriteLine("Введите длину/высоту массива :");
    int arrayLength = Convert.ToInt32(Console.ReadLine());

    // Console.WriteLine("Введите высоту массива :");
    int arrayHeight = arrayLength;
    Console.WriteLine();

    int[,] array2d = new int[arrayHeight,arrayLength];
    for (int i=0; i<array2d.GetLength(0); i++)
    {
        for (int j=0; j<array2d.GetLength(1); j++)
        {
            array2d[i,j] = new Random().Next(0,10);
            Console.Write(array2d[i,j] +" ");
        }
        Console.WriteLine();
    }

    Console.WriteLine( new String('-', arrayLength*2));
    int[] sumArray = new int[arrayLength];
    int temp = 0;
    int rowSum = 0;
        
    int k = 0;

    for (int i=0; i<array2d.GetLength(0); i++)
    {
        
        for (int j=0; j<array2d.GetLength(1); j++)
        {
            temp = array2d[i, j];
            rowSum = temp + rowSum;
        }
        
        sumArray[k]=rowSum;
        k++;
        rowSum = 0;
        
    }

    // массив сумм   
    // Console.WriteLine(String.Join(", ",sumArray));
 
    int minRow = Array.IndexOf(sumArray, sumArray.Min())+1;
    Console.WriteLine($"строка {minRow} имеет минимальную сумму элементов");
}


void TaskNumber58()
{
    Console.WriteLine();

    // Начальные данные для теста
    // int[,] matrix1 = new int[2,2]{{2,4},{3,2}};
    // int[,] matrix2 = new int[2,2]{{3,4},{3,3}};
    // int arrayLength=2;
    // int arrayHeight=2;
    // Console.WriteLine( new String('-', arrayLength*2));
    // for (int i=0; i<matrix1.GetLength(0); i++)
    // {
    //     for (int j=0; j<matrix1.GetLength(1); j++)
    //     {
                
    //         Console.Write(matrix1[i,j] +" ");
    //     }
    //     Console.WriteLine();
    // }
    // Console.WriteLine( new String('-', arrayLength*2));
    // for (int i=0; i<matrix2.GetLength(0); i++)
    // {
    //     for (int j=0; j<matrix2.GetLength(1); j++)
    //     {
                
    //         Console.Write(matrix2[i,j] +" ");
    //     }
    //     Console.WriteLine();
    // }


    // Ввод данных
    Console.WriteLine("Введите длину/высоту матриц:");
    int arrayLength = Convert.ToInt32(Console.ReadLine());
    int arrayHeight = arrayLength;
    Console.WriteLine();
    Console.WriteLine($"Matrix1: ");
    int[,] matrix1 = new int[arrayHeight,arrayLength];
    for (int i=0; i<matrix1.GetLength(0); i++)
    {
        for (int j=0; j<matrix1.GetLength(1); j++)
        {
            matrix1[i,j] = new Random().Next(0,10);
            Console.Write(matrix1[i,j] +" ");
        }
        Console.WriteLine();
    }

    Console.WriteLine( new String('-', arrayLength*2)); 

    Console.WriteLine($"Matrix2: ");
    int[,] matrix2 = new int[arrayHeight,arrayLength];
    for (int i=0; i<matrix2.GetLength(0); i++)
    {
        for (int j=0; j<matrix2.GetLength(1); j++)
        {
            matrix2[i,j] = new Random().Next(0,10);
            Console.Write(matrix2[i,j] +" ");
        }
        Console.WriteLine();
    }

    Console.WriteLine( new String('-', arrayLength*2));

    Console.WriteLine($"Результат: ");
    int[,] resultMatrix = new int[arrayHeight,arrayLength];
    for (int i=0; i<resultMatrix.GetLength(0); i++)
    {
        for (int j=0; j<resultMatrix.GetLength(1); j++)
        {
            resultMatrix[i,j]=0;
            for (int k=0;k<resultMatrix.GetLength(0); k++)
            {
                resultMatrix[i,j] += matrix1[i,k]*matrix2[k,j]; 
            }
        }
    } 

    for (int i=0; i<resultMatrix.GetLength(0); i++)
    {
        for (int j=0; j<resultMatrix.GetLength(1); j++)
        {
            Console.Write(resultMatrix[i,j] +" ");
        }
        Console.WriteLine();
    }
}



void TaskNumber62()
{
    Console.WriteLine();
    Console.WriteLine("Введите длину/высоту матриц:");
    int arraySize = Convert.ToInt32(Console.ReadLine());

    int[,] array2d = new int[arraySize,arraySize];
    
    int count = 1;
    int h = 0;
    int l = 0;

    while (count <= array2d.GetLength(0) * array2d.GetLength(1))
    {
        array2d[h, l] = count;
        count++;
        if (h <= l + 1 && h + l < array2d.GetLength(1) - 1)
            l++;
        else if (h < l && h + l >= array2d.GetLength(0) - 1)
            h++;
        else if (h >= l && h + l > array2d.GetLength(1) - 1)
            l--;
        else
            h--;
    }

    for (int i=0; i<array2d.GetLength(0); i++)
    {
        for (int j=0; j<array2d.GetLength(1); j++)
        {
                
            Console.Write(array2d[i,j].ToString("D2") +" ");
        }
        Console.WriteLine();
    }

}