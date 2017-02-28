using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassOne
{
    class Program
    {
        int wallWeight;
        int wallWidth;
        int wallHeight;
        int wallLenght;
        int widhRol;
        int lenghtRol;
        decimal Calculate;
        

                static void Main(string[] args)
        {
            
            int wallWidth;
            int wallHeight;
            int wallLenght;
            int widthRoll;
            int lenghtRoll;
            decimal Between;
            decimal Final;
            decimal Calculate;
            ////Student First Name and Surname willl be enter here
            Console.WriteLine("Please Enter Your Name :");
            string userName = Console.ReadLine();
            Console.WriteLine("Welcome To Vatebra Academy , ");
            Console.WriteLine("{0} The Current Time Test Start is {1}", userName, System.DateTime.Now.TimeOfDay);
            ///// We will be calculating the class wall
            Console.WriteLine("Q1: Please Enter the Lenght of Class Wall : ");
            wallLenght = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Q2: Please Enter the Width of Class Wall : ");
            wallWidth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Q3: Please Enter the Height of Class Wall : ");
            wallHeight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Q4: Please Enter the Width of the Roll : ");
            widthRoll = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Q5: Please Enter the Lenght of the Roll : ");
            lenghtRoll = Convert.ToInt32(Console.ReadLine());

            /////The Result of the class wall
            Calculate = (wallWidth * wallHeight) + (wallLenght * wallHeight);
            Between = (widthRoll * lenghtRoll);
            Final = Calculate / Between;

            Console.WriteLine("The Answer is {0} : ", Final.ToString());

            Console.WriteLine("Press Any Key to Submit");

            Console.ReadKey();
        }
    }
}
