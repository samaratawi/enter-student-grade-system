using System;

namespace projectToeq
{
    class Program
    {
        static void Main(string[] args)
        {
            //i still devloping it to becom perfect 
            StudentOperationMunue();
            Console.ReadKey();
        }

        public static void enterData(ref string[] studentName, ref int[] studentGrade, ref int n)
        {
            int check;
            
            bool CheckNameS;
            bool CheckGradeS;
            String Checknumber;
            bool ChecknumberB;





            for (int i = 0 ; i < n ; i++)
            {
                Console.WriteLine("Enter student name:");
                studentName[i] = Console.ReadLine();
                CheckNameS = checkName(studentName[i]);
                while (CheckNameS == false)
                {
                        Console.WriteLine("the student name not correct plz Enter correct student name:");
                        studentName[i] = Console.ReadLine();
                        CheckNameS = checkName(studentName[i]);
                   
                }
                Console.WriteLine("Enter the student grade :");
                Checknumber = Console.ReadLine();
                ChecknumberB = CheckNumber(Checknumber);
                while (ChecknumberB == false)
                {
                    Console.WriteLine("Enter numer not correct plz enter correct number :");
                    Checknumber = Console.ReadLine();
                    ChecknumberB = CheckNumber(Checknumber);
                }
                studentGrade[i] = Convert.ToInt32(Checknumber);
                CheckGradeS = checkGrade(studentGrade[i]);
                while (CheckGradeS == false)
                {
                    Console.WriteLine("the grade is not correct plz Enter the correct student grade :");
                    studentGrade[i] = int.Parse(Console.ReadLine());
                    CheckGradeS = checkGrade(studentGrade[i]);
                }
                Console.WriteLine("if you have another student enter 1 else enter 0 :");
                check = Convert.ToInt32(Console.ReadLine());
                if (check == 1)
                {
                    
                    n++;
                    Array.Resize(ref studentName, n);
                    Array.Resize(ref studentGrade, n);
                }
              

            }

            
        }
        public static bool checkName(string Name)
        {
           foreach(char leater in Name)
            {
                if (!char.IsLetter(leater))
                    return false;
            }
            return true;
        }
        public static bool checkGrade(int Grade)
        {
            if(Grade <= 100)
            {
                return true;
            }
            return false;
        }
        public static void PrintStudentData(ref string[] studentName, ref int[] studentGrade, ref int n)
        {
            if (studentName.Length > 1)
            {
                Console.WriteLine("Student number \t\t Student name \t Student grade \t evaluation");
                for (int i = 0; i < studentName.Length; i++)
                {
                    Console.Write(i + "\t\t\t");
                    Console.Write(studentName[i] + "\t\t\t");
                    if (studentGrade[i] >= 60)
                    {
                        Console.Write(studentGrade[i] + "\t\t\t");
                        Console.Write("Passed");
                    }
                    else
                    {
                        Console.Write(studentGrade[i] + "\t\t\t");
                        Console.Write("filed");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine(" there is no data to view ");
            }
        }
        public static void UpdateStudentData(ref string[] studentName, ref int[] studentGrade, ref int n)
        {
            int StudentNo;
            string StudentNoS;
            bool checkNumberS;
            bool CheckNameS;
            bool stop = false;
            int checkstop;
            bool CheckGradeS;
            string Checknumber;
            bool ChecknumberB;
            Console.WriteLine("Student List");
            PrintStudentData(ref studentName, ref studentGrade, ref n);
            while (stop == false)
            {
                Console.WriteLine("Enter the student number to ubdate Student data");
                StudentNoS = Console.ReadLine();
                checkNumberS = CheckNumber(StudentNoS);
                while(checkNumberS == false)
                {
                    Console.WriteLine(" the student number is not correct pls enter correct student number to ubdate Student data");
                    StudentNoS = Console.ReadLine();
                    checkNumberS = CheckNumber(StudentNoS);

                }
                checkNumberS = false;
                while (checkNumberS == false)
                {
                    
                    StudentNo = Convert.ToInt32(StudentNoS);
                    if (StudentNo >= studentName.Length)
                    {
                        checkNumberS = false;
                    }
                    else
                    {
                        StudentNo = Convert.ToInt32(StudentNoS);
                        Console.WriteLine("Enter Ubdate student name");
                        studentName[StudentNo] = Console.ReadLine();
                        CheckNameS = checkName(studentName[StudentNo]);
                        while (CheckNameS == false)
                        {
                            Console.WriteLine("the student name not correct plz Enter correct student name:");
                            studentName[StudentNo] = Console.ReadLine();
                            CheckNameS = checkName(studentName[StudentNo]);

                        }
                        Console.WriteLine("Enter Ubdate student Grade");
                        Checknumber = Console.ReadLine();
                        ChecknumberB = CheckNumber(Checknumber);
                        while (ChecknumberB == false)
                        {
                            Console.WriteLine("Enter numer not correct plz enter correct number :");
                            Checknumber = Console.ReadLine();
                            ChecknumberB = CheckNumber(Checknumber);
                        }
                        studentGrade[StudentNo] = Convert.ToInt32(Checknumber);
                        CheckGradeS = checkGrade(studentGrade[StudentNo]);
                        while (CheckGradeS == false)
                        {
                            Console.WriteLine("the grade is not correct plz Enter the correct student grade :");
                            studentGrade[StudentNo] = Convert.ToInt32(Console.ReadLine());
                            CheckGradeS = checkGrade(studentGrade[StudentNo]);
                        }
                        checkNumberS = true;

                    }

                }
                Console.WriteLine("if you want stop update student data enter 0");
                checkstop = Convert.ToInt32(Console.ReadLine());
                if(checkstop == 0)
                {
                    stop = true;
                }

            }


        }
        public static void StudentOperationMunue()
        {
            string Schoos;
            int Schoosi;
            bool ScheckNumer;
            int n = 1;
            string[] studentName = new string[n];
            int[] studentGrade = new int[n];
            bool stopProgram = true;
            String StringStop;
            int NumberStop;
            while (stopProgram == true)
            {
                Console.WriteLine("Choose one of the operation");
                Console.WriteLine("1- Enter students Data \n2- View Students Data \n3-Update Students data");
                Schoos = Console.ReadLine();
                ScheckNumer = CheckNumber(Schoos);
                while (ScheckNumer == false)
                {
                    Console.WriteLine("Enter numer not correct plz enter correct number :");
                    Schoos = Console.ReadLine();
                    ScheckNumer = CheckNumber(Schoos);
                    Schoosi = Convert.ToInt32(Schoos);
                    if (Schoosi > 3)
                    {
                        ScheckNumer = false;
                    }
                    else
                    {
                        ScheckNumer = true;
                    }


                }
                switch (Schoos)
                {
                    case "1":
                        enterData(ref studentName, ref studentGrade, ref n);
                        break;
                    case "2":
                        PrintStudentData(ref studentName, ref studentGrade, ref n);
                        break;
                    case "3":
                        UpdateStudentData(ref studentName, ref studentGrade, ref n);
                        break;


                }
                Console.WriteLine("if you want more operation click 1 else click any number");
                StringStop = Console.ReadLine();
                ScheckNumer = CheckNumber(StringStop);
                while (ScheckNumer == false)
                {
                    Console.WriteLine("Enter numer not correct plz enter correct number :");
                    StringStop = Console.ReadLine();
                    ScheckNumer = CheckNumber(StringStop);
                   
                    
                }
                NumberStop = Convert.ToInt32(StringStop);
                if (NumberStop == 1)
                {
                    stopProgram = true;
                }
                else
                {
                    Console.WriteLine("have a nice day");
                    stopProgram = false;
                    
                }

            }



        }

        public static bool CheckNumber(string inputNumber)
        {
            foreach(char digit in inputNumber)
            if (!char.IsDigit(digit) && digit != '.')
            {
                return false;
            }
            return true;
        }
        
    }
}
