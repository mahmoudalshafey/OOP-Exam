namespace OOP_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject sub1 = new Subject(101, "Object-Oriented Programming");

            sub1.CreateExam();

            Console.Clear();
            Console.Write("Do you want to start the exam right now? (Y/N): ");
            char start = char.Parse(Console.ReadLine());

            if (start == 'Y' || start == 'y')
            {
                sub1.SubjectExam.ShowExam();
            }
            else
            {
                Console.WriteLine("Exam postponed.");
            }
        }
    }
}
