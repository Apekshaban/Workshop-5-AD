

namespace Task3
{
    class Teacher
    {
        public string Name { get; set; }

        public virtual void Teaching()
        {
            Console.WriteLine("Teacher teaches in English.");
        }

        public void SalaryInfo()
        {
            Console.WriteLine("Teacher receives monthly salary.");
        }
    }

    class NepaliTeacher : Teacher
    {
        public override void Teaching()
        {
            Console.WriteLine("Nepali Teacher teaches in Nepali language.");
        }
    }

    class EnglishTeacher : Teacher
    { }
}