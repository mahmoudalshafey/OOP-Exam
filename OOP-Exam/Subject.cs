using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Exam
{
    internal class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public Exam SubjectExam { get; set; }

        public Subject(int subjectId, string subjectName)
        {
            SubjectId = subjectId;
            SubjectName = subjectName;
        }

        public void CreateExam()
        {
            int examType;
            do
            {
                Console.Write("Enter Exam Type (1 for Practical, 2 for Final): ");
            } while (!int.TryParse(Console.ReadLine(), out examType) || (examType != 1 && examType != 2));


            int duration;
            do
            {
                Console.Write("Enter Exam Duration in Minutes (from 30 to 180): ");
            } while (!int.TryParse(Console.ReadLine(), out duration) || duration < 30 || duration > 180);

            int numQuestions;
            do
            {
                Console.Write("Enter Number of Questions: ");
            } while (!int.TryParse(Console.ReadLine(), out numQuestions) || numQuestions <= 0);

            if (examType == 1)
            {
                SubjectExam = new PracticalExam(duration, numQuestions);
                for (int i = 0; i < numQuestions; i++)
                {
                    Console.WriteLine($"\n--- Designing Question {i + 1} (MCQ) ---");
                    Console.Write("Enter Question Body: ");
                    string body = Console.ReadLine();

                    int mark;
                    do
                    {
                        Console.Write("Enter Question Mark: ");
                    } while (!int.TryParse(Console.ReadLine(), out mark) || mark <= 0);

                    SubjectExam.Questions[i] = new McqQuestion(body, mark);
                    SubjectExam.Questions[i].CreateQuestion();
                }
            }
            else
            {
                SubjectExam = new FinalExam(duration, numQuestions);
                for (int i = 0; i < numQuestions; i++)
                {
                    int qType;
                    do
                    {
                        Console.Write($"\nEnter Question {i + 1} Type (1 for True/False, 2 for MCQ): ");
                    } while (!int.TryParse(Console.ReadLine(), out qType) || (qType != 1 && qType != 2));

                    Console.Write("Enter Question Body: ");
                    string body = Console.ReadLine();

                    int mark;
                    do
                    {
                        Console.Write("Enter Question Mark: ");
                    } while (!int.TryParse(Console.ReadLine(), out mark) || mark <= 0);

                    if (qType == 1)
                    {
                        SubjectExam.Questions[i] = new TrueFalseQuestion(body, mark);
                    }
                    else
                    {
                        SubjectExam.Questions[i] = new McqQuestion(body, mark);
                    }

                    SubjectExam.Questions[i].CreateQuestion();
                }
            }
        }
    }

}
