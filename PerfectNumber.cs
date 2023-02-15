using System ;

namespace PerfectNumber{

    public class PerfectNumber{
        public static void CheckPerfectorNot(){
            Console.WriteLine("enter the number: ");
            int N =Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            if(N > 0){
                for (int i=1 ;i < N ; i++){
                    if(N % i == 0){
                        sum = sum + i;
                    }
                }
                if(sum == N){
                    Console.WriteLine("It is perfect Number");
                }else{
                    Console.WriteLine("it is not a perfect Number");
                }
            }else {
                Console.WriteLine("Enter the number the greater than 0");
            }
        }
    }
 
}