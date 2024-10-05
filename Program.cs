using System;
namespace Vazifa
{   
    class Program
    {
        static void Main(){
        
            int x = 15;
            int y = 10;
            string result;
            if(x>y){
                System.Console.WriteLine("x is greater than y");
            } 
            else if(x<y){
                System.Console.WriteLine("x is less than y");
            }
            else if( x == y){
                System.Console.WriteLine("x is equal to y");
            }
            else{
                System.Console.WriteLine("x and y are not comparable");
            }
        }
    }
}