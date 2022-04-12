//---------------------------array-------------------- -
//int[] arr = new int[5];
//arr[0] = 10;
//arr[1] = 20;
//arr[2] = 30;
//arr[3] = 40;
//arr[4] = 50;


//for (int i = 0; i < arr.Length; i++)
//{
//    Console.WriteLine(arr[i]);
//}

//-------------------------------------------------------------------


//int[,] arr = new int[2,2];
//Console.WriteLine("Enter value : ");
//for (int i = 0; i <= 1; i++)
//{
//for (int j = 0; j <= 1 ; j++)
//{
//arr[i,j] = int.Parse(Console.ReadLine());
//}
//}



//Console.WriteLine("\nDisplaying value : ");
//for (int i = 0; i <= 1; i++)
//{
//for (int j = 0; j <= 1; j++)
//{
//Console.Write(arr[i, j]+"\t");
//}
//Console.WriteLine();
//}


//-------------------------------------------------------------------


//int[,] arr = new int[3, 4];
//Console.WriteLine("enter array value");

//for (int i = 0; i < 3; i++)
//{
//    for (int j = 0; j < 4; j++)
//    {
//        Console.Write("enter the number : ");
//        arr[i, j] = int.Parse(Console.ReadLine());
//    }
//}

//for (int i = 0; i < 3; i++)
//{
//    for (int j = 0; j < 4; j++)
//    {
//        Console.Write(arr[i, j] + "\t");
//    }
//    Console.WriteLine();
//}
//------------------------------------------------------
//*       *       *
//        *       *
//                *

//int[,] arr = new int[3,4];
//Console.WriteLine("enter array value");
//for (int i = 0; i <= 1; i++)
//{
//    for (int j = 0; j <= 1; j++)
//    {
//        arr[i, j] = int.Parse(Console.ReadLine());
//    }
//}

//for (int i = 0; i < 3; i++)
//{
//    for(int j = 0; j < 3; j++)
//    {
//        if(j >= i)
//        {
//            Console.Write("*\t");

//        }
//        else
//        {
//            Console.Write(" \t");

//        }
//    }
//    Console.WriteLine(" ");
//}







//---------------------------------------------------------------

//*       *       *       *

//*                       *

//*                       *

//*       *       *       *

//for (int i = 0; i < 4; i++)
//{
//    for (int j = 0; j <4; j++)
//    {
//        if (i==0 || j==0 || i == 3 || j == 3)
//        {
//            Console.Write("*\t");
//        }

//        else
//        {
//            Console.Write("\t");
//        }       

//    }
//    Console.WriteLine("\n");
//}
//------------------------------------------------
//-       -       -       *

//-       -       -       *

//-       -       -       *

//*       *       *       *


//for (int i = 0; i < 4; i++)
//{
//    for (int j = 0; j < 4; j++)
//    {
//        if (i == 3 || j==3  )
//        {
//            Console.Write("*\t");
//        }

//        else
//        {
//            Console.Write("-\t");
//        }

//    }
//    Console.WriteLine("\n");
//}
//-----------------------------------------------
//*       *       *

//*               *

//*               *

//*       *       *

//*

//*


//for (int i = 0; i < 6; i++)
//{
//    for (int j = 0; j < 3; j++)
//    {
//        if (i == 0 || j == 0 || i == 3 || j==3  )
//        {
//            Console.Write("*\t");
//        }

//        else
//        {
//            Console.Write("\t");
//        }
//        if(i==1 && j==1 || i==2 && j==1)
//        {
//            Console.Write("*\t");

//        }
//    }
//    Console.WriteLine("\n");
//}
//-----------------------------------------------


//*                               *
//        *               *
//                *
//        *               *
//*                               *



//for (int row = 0; row < 5; row++)
//{
//    for (int column = 0; column < 5; column++)
//    {
//        if (((column == 0 || column == 4) && (row > 3 || row < 1)) || row == column || (column == 1 && row == 3) || column == 3 && row == 1)
//            Console.Write("*\t");
//        else
//            Console.Write("\t");
//    }
//    Console.Write("\n");
//}

//------------- or ---------------------------------
//for (int row = 0; row < 5; row++)
//{
//    for (int column = 0; column < 5; column++)
//    {
//        if (row == column || (row + column) ==4)
//            Console.Write("*\t");
//        else
//            Console.Write("\t");
//    }
//    Console.Write("\n");
//}
//---------------------------------------------------------------------
//checked large no array

Console.Write("enter row : ");
int row = int.Parse(Console.ReadLine());
Console.Write("enter col : ");
int col = int.Parse(Console.ReadLine());

int[,] arr = new int[row, col];

for (int i = 0; i < row; i++)
{
    for(int j = 0; j < col; j++)
    {
        Console.Write("enter no :");
        arr[i, j] = int.Parse(Console.ReadLine());
    }
}

var largeNo = 0;

for (int i = 0; i < row; i++)
{
    for (int j = 0; j < col; j++)
    {
        if(arr[i, j] > largeNo)
        {
            largeNo=arr[i, j];
        }
    }
}
Console.WriteLine("large of array : "+ largeNo);


