using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> st = new List<Student>();
            List<Employe> ep = new List<Employe>();
            while (true)
            {

                Console.WriteLine("1.Student elave et  2. Employe elave et   3.Axtaris et 4.Chixis ");
                string num = Console.ReadLine();
                bool isInt = int.TryParse(num, out int menu);

                if (isInt)
                {

                    if (menu == 4)
                    {
                        break;
                    }

                    switch (menu)
                    {

                        case 1:
                            STUDENT:
                            Student student = new Student();
                            Console.WriteLine("Studentin adini qeyd edin");
                            string name = Console.ReadLine();
                            student.Name = name;
                            Console.WriteLine("Studentin soyadini qeyd edin");
                            string surname = Console.ReadLine();
                            student.Surname = surname;
                            Console.WriteLine("Studentin yasini qeyd edin");
                            string _age = Console.ReadLine();
                            int age = int.Parse(_age);
                            student.Age = age;
                            Console.WriteLine("Studentin balini qeyd edin");
                            string _gr = Console.ReadLine();
                            int grade = int.Parse(_gr);
                            student.Grade = grade;
                            st.Add(student);
                            Console.WriteLine($"{name} adli student elave olundu twk<3");
                            break;
                        case 2:
                            ISCI:
                            Employe employe = new Employe();
                            Console.WriteLine("Iscinin  adini qeyd edin");
                            string name1 = Console.ReadLine();
                            employe.Name = name1;
                            Console.WriteLine("Iscinin soyadini qeyd edin");
                            string surname2 = Console.ReadLine();
                            employe.Surname = surname2;
                            Console.WriteLine("Iscinin yasini qeyd edin");
                            string _age1 = Console.ReadLine();
                            int age1 = int.Parse(_age1);
                            employe.Age = age1;
                            Console.WriteLine("Iscinin  position  qeyd edin");
                            string _ps = Console.ReadLine();
                            employe.Position = _ps;
                            ep.Add(employe);
                            Console.WriteLine($"{name1} adli isci elave olundu twk<3");
                            break;
                        case 3:
                            Console.WriteLine("1.Employe axtarisi  2. Student axtarisi  ");
                            string num1 = Console.ReadLine();
                            bool isInt1 = int.TryParse(num1, out int menu1);

                            if (isInt1)
                            {
                                switch (menu1)
                                {
                                    case 1:
                                        if (ep.Count==0)
                                        {
                                            Console.WriteLine("Isci yoxdur,zehmet olmasa iscini elave edin");
                                            goto ISCI;
                                        }
                                        Console.WriteLine("Positionlarin siyahisi");
                                        foreach (var item in ep)
                                        {
                                            Console.WriteLine((item.Position.ToString()));
                                        }
                                        
                                        Console.WriteLine("Position daxil edin");
                                        string pos = Console.ReadLine();
                                        foreach (var item in ep)
                                        { 
                                            
                                             if (item.Position == pos)
                                            {
                                                Console.WriteLine(item.Name);
                                            }
                                            
                                        }
                                        break;
                                    case 2:
                                        if (st.Count == 0)
                                        {
                                            Console.WriteLine("Student yoxdur,zehmet olmasa student elave edin");
                                            goto STUDENT;
                                        }
                                        Console.WriteLine("minGrade daxil edin");
                                        string mn = Console.ReadLine();
                                        int mingrade = int.Parse(mn);
                                        Console.WriteLine("MaxGrade daxil edin");
                                        string mx = Console.ReadLine();
                                        int maxgrade = int.Parse(mx);
                                        foreach (var item in st)
                                        {
                                            if (item.Grade >= mingrade && item.Grade <= maxgrade)
                                            {
                                                Console.WriteLine($"Student {item.Name}  Grade : {item.Grade}");
                                            }
                                        }
                                        break;
                                    default:
                                        break;
                                }

                            }
                            break;
                    }
                }
            }
        }
    }
}


