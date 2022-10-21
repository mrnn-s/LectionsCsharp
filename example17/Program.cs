
                     
string [,] table= new string [2,5];
//String.Empty
//table[0,0] table[0,1] tablr [0,2] table [0,4]
//table [1,0] table[1,1] tablr [1,2] table [1,4]


// table [1,2]= "word";

// for (int rows=0;rows<2;rows++)
// {
//   for (int colums=0; colums<5; colums++ )
//   {
//   Console.WriteLine($"-{table[rows,colums]}-");
//   }
// }

void PrintArray(int[,] array)
{
    for (int i=0;i<array.GetLength(0);i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write($" -{array[i,j]}- ");
    }
    Console.WriteLine();
}
}

void FillArray(int[,] coll )
{
       for (int i=0;i<coll.GetLength(0);i++)
{
    for (int j = 0; j < coll.GetLength(1); j++)
    {
        coll[i,j]=new Random().Next(1,10);
    }
    Console.WriteLine();
}
}

int[,] matris = new int [5,8];

PrintArray(matris);
FillArray(matris);
PrintArray(matris);