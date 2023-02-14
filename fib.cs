using System ;

namespace LogicalPro{

    public class Fib{
        
        public static  void Displayfib(){
            int n1 =0 ,n2 =1, n3 ,number;
            Console.WriteLine("enter the num: ");
            number  = Convert.ToInt16(Console.ReadLine());

            Console.Write(n1 + " " +n2 + " ");

            for(int i =2;i<number;i++){
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2=n3;
            }
        }

    }

}