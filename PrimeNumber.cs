using System;

namespace LogicalPro{

    public class PrimeNumer{

        public static void primeNumer(int n ){
            if(n >=2){
                for (int i =2 ; i < n ; i++){
                    if( n%i ==  0){
                        Console.WriteLine("it is not a Prime Number");
                        break;
                    }
            }
                Console.WriteLine("{0} is a prime Number",n );
        }else{
            Console.WriteLine("enter the Number More Than two");
        }
        }
                
    }

}