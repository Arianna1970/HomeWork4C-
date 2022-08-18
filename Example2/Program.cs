/*
1. Написать метод, который генерирует массив 0 и 1 заданного количества N

3 -> 1 1 0
	 1 0 0
	 0 0 1
*/
// генерация случайного двоичного числа из N разрядов
int[] GenMas(int N)
{

    int[] masRand = new int[N];

    for (int i = 0; i < N; i++)
    {
        masRand[i] = new Random().Next(0, 2);
    }
    return masRand;

}
 void PrintArray(int[] arr)
 {
   for (int i = 0; i < arr.Length; i++)
   {
    Console.Write(arr[i] + " ");
   }
   System.Console.WriteLine();
 }

// перевод двоичного числа в десятичное
int BinDig( int[] Arr)
{
int Number = 0;
int Power=1;

for (int i = Arr.Length-1; i >=0; i--)
{ 
    Number= Number + Arr[i]*Power;
    Power*=2;
}
return  Number;
}
// преобразует заданное целое число в систему с основанием Base
int[] NumberConvert(int Number, int Base )
{

int TempNumber = Number;
int Count=0;
while ( TempNumber!=0 )
{ 
    TempNumber/=Base;
    Count++;
}    
int[] Arr= new int[Count];

while ( Number!=0 )
{ 
    Arr[Count-1]=Number%Base;
    Number/=Base;
    Count--;
}    
return Arr;

}

System.Console.Write("Input N =");
int N = Convert.ToInt32(Console.ReadLine());
// 1
int[] Arr = GenMas(N);
PrintArray(Arr);
//2
int DecNumber=BinDig(Arr);
System.Console.WriteLine($"Переведем в десятичную систему : {DecNumber} ");
//3
System.Console.Write("А теперь в систему с другим основанием ( от 2 до 9 )= ");
int Base = Convert.ToInt32(Console.ReadLine());
if ( Base>1 & Base <10 ) 
{  System.Console.Write("Получилось ");
   PrintArray(NumberConvert(DecNumber, Base));
}
else 
   System.Console.WriteLine("Неправильное основание!!!");

 

    
