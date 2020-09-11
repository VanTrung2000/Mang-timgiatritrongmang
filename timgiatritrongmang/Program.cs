using System;

namespace timgiatritrongmang
{
    class Program
    {
       

        static void Main(string[] args)
        {
            string[] students = { "Hi", "Van", "Trung", "Dep", "Trai", "Anh", "Nam", "Linh", "Long", "Nhat" };

            Console.WriteLine("Enter a name’s student:");
            
            hienthi(students);
            Console.ReadKey();

        }  
        private static void hienthi(string[] students)
        {
            string input_name = Console.ReadLine();
            bool isExist = false;
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].Equals(input_name))
                {
                    Console.WriteLine("Position of the students in the list " + input_name + " is: " + (i + 1));
                    isExist = true;
                    break;
                }
            }
            if (!isExist)
            {
                Console.WriteLine("Not found" + input_name + " in the list.");

            }
        }

    }
}
    
    

