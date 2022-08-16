//написать программу, которая принимает два числа и показывает, какое больше, а какое меньше.
int userNumberFirst = new int();
int userNumberSecond = new int();

Console.WriteLine ( "Введите первое число: " );
userNumberFirst = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите второе число: ");
userNumberSecond = Convert.ToInt32(Console.ReadLine());
if ( userNumberFirst >  userNumberSecond)
{ 
    Console.WriteLine ( $"Max={userNumberFirst}). Min={userNumberSecond}");
    }
    else
    {
         Console.WriteLine ( $"Max={userNumberSecond}). Min={userNumberFirst}");
        
    };
    