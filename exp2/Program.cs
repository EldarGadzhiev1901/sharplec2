int[] array = { 11, 21, 31, 41, 1303, 61, 2, 3, 0};

int n = array.Length;
int find = 41;

int index = 0;

while (index < n)

{
   if(array[index] == find)
   {
    Console.WriteLine(index);
    break;
   }

index++;


}