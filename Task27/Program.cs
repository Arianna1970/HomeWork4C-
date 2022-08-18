// преобразование цифр десятичного числа в массив целых чисел 
int[] NumberToArray(int number)
{
 
  int TempNumber = number;
  int Count=0;
  // определим, сколько в числе разрядов
  while ( TempNumber!=0 )
  { 
    TempNumber/=10;
    Count++;
  }    
  int[] Arr= new int[Count];

  while ( number!=0 )
  { 
    Arr[Count-1]=number%10;
    number/=10;
    Count--;
  }    
return Arr;
}

int DigitsSum(int[] arr)
{ int sum=0;
  for (int i = 0; i < arr.Length; i++)
   sum+=arr[i];
  return sum;
}  
    
int Number;
System.Console.Write("Введите натуральное число :  ");
// но можно и любое
Number = System.Math.Abs(Convert.ToInt32(System.Console.ReadLine()));
System.Console.WriteLine($"Сумма цифр равна {DigitsSum(NumberToArray(Number))}");