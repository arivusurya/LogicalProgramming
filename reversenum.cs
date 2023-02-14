using System;

namespace LogicalPro{

    public class Reverse {

    public static void Revernum(){
        int reverse = 0 ,rem , number;
        Console.WriteLine("enter the Number ");
        number = Convert.ToInt32(Console.ReadLine()); 
        while (number!=0){
            rem = number%10;
            reverse = reverse *10 +rem;
            number = number /10;
        }

        Console.WriteLine("The reverse number is  {0}",reverse);
    }        

    }

}