﻿int [] array = {1,21,32,4,15,4,16,17,8};

int n=array.Length;
int find=4;
int index=0;

while (index<n)
{
 
  if(array[index]==find)
{
    Console.WriteLine(index);
    break;
}
  index++;
}