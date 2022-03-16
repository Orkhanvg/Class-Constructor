using System;

namespace oppclass
{
    class Program
    {
        static void Main(string[] args)
        {
            #region class intro
            //    string name = "Ehmed";
            //    string surname = "Jabrayilov";
            //    int age = 24;


            //    string name1 = "Ilkin";
            //    string surname1 = "Ibrahimov";
            //    int age1 = 20;


            //anonim
            //var ehmed = new
            //{
            //    name = "Ehmed",
            //    surName = "Jabrayilov",
            //    age = 24
            //};

            //var kamal = new
            //{
            //    name = "Kamal",
            //    surName = "Abdullayev",
            //    age = 20
            //};




            //Console.WriteLine(ehmed.name);
            //Console.WriteLine(kamal.name);
            #endregion

            //instance
            //int num = 4;

            //Student stu1 = new Student("Ehmed" , "Jabrayilov", 24);

            //stu1.name = "Lorem";
            //stu1.surName = "Jabrayilov";
            //stu1.age = 24;
            //stu1.Fullname();
            //Console.WriteLine(stu1.GetAge());

            Student stu2 = new Student("Nargiz","Qaniyeva", 20);

            //stu2.name = "Kamal";
            //stu2.surName = "Abdullayev";
            //stu2.age = 20;
            stu2.Fullname();

            //Console.WriteLine(stu2.GetAge());

            //Console.WriteLine(stu1.age);
            //Console.WriteLine(stu2.age);


        }

    }


    class Student
    {
        //fields
        public string name;
        public string surName;
        public int age;

        //constructor
        //1. classin adi ile eynidir;
        //2. ilk ishe dushen methoddur;
        //3.return type'i olmur

        public Student() 
        {
            Console.WriteLine("ishledi");
        }

        
        public Student(string name) : this()
        {
            this.name = name;
            
        }

        public Student(string name, string surName, int age):this(name)
        {
            
            this.surName = surName;
            this.age = age;
        }
        


        public void Fullname()
        {
            Console.WriteLine($"{name} {surName} ");

        }

        public int GetAge()
        {
            return age;

        }
    }
}
