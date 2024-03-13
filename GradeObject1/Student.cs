
using System;
using System.Linq.Expressions;

namespace GradeObject1
{
    class Program
    {
        static void Main(string[] args)                      // main method
        {
            try
            {

                // Starting execution
                // Creating object of class Studentheck
                StudentCheck chk = new StudentCheck();
                chk.accept(); //Invoking accept method
                chk.print();//Invoking print method
            }
            catch (Exception ex)
            {
                Console.WriteLine(("Exception has been handeled " + ex.Message));
            }
            Console.ReadLine();
        }
    }
        class StudentCheck                          // create class 
        {
            
        
            string[] subject = { "Maths", "Physics", "Chemistry", "Computer Science" };   //assign subject array
            int[] marks = new int[4];                                                     //assign marks array

            int tot = 0;                 //assign tot and average
            float average = 0;

            public void accept()           // create method
            {

                for (int i = 0; i < subject.Length; i++)
                {
                    Console.Write("\nEnter your marks for (below 100) " + subject[i] + " ");
                    marks[i] = Convert.ToInt32(Console.ReadLine());

                }
                for (int i = 0; i < subject.Length; i++)
                {
                    tot += marks[i];
                    average = tot / subject.Length;


                }



            }
            public void print()                      // create anothe method
            {
                // string name;
                //Console.WriteLine("Enter your name : ");
                //name = Console.ReadLine();
                Console.WriteLine("Your average marks :" + average);

                char grade;

                if (average >= 80)                             // condtions function for average 
                {
                    grade = 'A';

                }
                else if (average >= 70 && average < 80)
                {
                    grade = 'B';
                }
                else if (average >= 60 && average < 70)
                {
                    grade = 'C';

                }
                else if (average >= 50 && average < 60)
                {
                    grade = 'D';
                }
                else
                {
                    grade = 'F';
                }
                switch (grade)                             // switch function for grade

                {
                    case 'A':
                        Console.WriteLine("Welcome   Excellent! Your grade is " + grade);
                        break;

                    case 'B':
                        Console.WriteLine("Welcome   Good! Your grade is " + grade);
                        break;

                    case 'C':
                        Console.WriteLine("Welcome  Satisfactory. Your grade is " + grade);
                        break;

                    case 'D':
                        Console.WriteLine("Welcome  Pass. Your grade is " + grade);
                        break;

                    case 'F':
                        Console.WriteLine("Welcome Fail. Your grade is  " + grade);
                        break;

                    default:
                        Console.WriteLine("Invalid entry");
                        break;
                }
            }

         
              
        }

    

}