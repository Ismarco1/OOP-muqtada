namespace oop
{
    // muqtada mohammed hadi - B -
    class Student
    {
        // privte fields 
        private string name;
        private string address; 
        private double mark;

        // properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Address 
        {
            get { return address; }
            set { address = value; }
        }

        public double Mark
        {
            get { return mark; }
            set { mark = value; }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
           
            Student student = new Student();
            student.Name = "Marco";
            student.Address = "Baghdad";
            student.Mark = 98.9;

            // printing  the fields
            print(student);
        }
        // creating a methode to print the filds
        static void print(Student student)
        {
            Console.WriteLine($"Name: {student.Name}");
            Console.WriteLine($"Address: {student.Address}");
            Console.WriteLine($"Mark: {student.Mark}");
        }
    }
}
