// N>0 по условию
int Power (int Base, int N)
{
    int power = Base;
    if (N>1)
     for (int i = 2; i <= N; i++)
        power*=Base;
        
    return power;    
        
}
System.Console.Write("Введите основание :  ");
int Base = Convert.ToInt32(System.Console.ReadLine());

System.Console.Write("Введите натуральный показатель :  ");
int N = Convert.ToInt32(System.Console.ReadLine());
if ( N>=1)
{  if (Base>0)
   System.Console.WriteLine($"{Base}^{N} = {Power(Base,N)}");
   else 
      if  (Base<0 )
        System.Console.WriteLine($"({Base})^{N} = {Power(Base,N)}");
      else
        System.Console.WriteLine( "1^N = 1");
}         
else
    System.Console.WriteLine("Используйте натуральное число для показателя");     