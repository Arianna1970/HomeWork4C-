int[] FillArrayRandomInt(int N)
{
     int[] Array = new int[N];
     for (int i = 0; i < N; i++)
         Array[i]=new Random().Next(1, 101);
     return Array;
}
void PrintArray(int[] Array)
{
  System.Console.Write("{");
  for (int i = 0; i < Array.Length; i++)
    { System.Console.Write($" {Array[i]}");
      if(i != Array.Length -1)
         System.Console.Write(",");
    }
    
  System.Console.WriteLine("}");
}       
PrintArray(FillArrayRandomInt(8));  
     