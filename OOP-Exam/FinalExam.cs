using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Exam
{
    internal class FinalExam : Exam
    {
        public FinalExam(int time, int numberOfQuestions) : base(time, numberOfQuestions)
        {
        }

        public override void ShowExam()
        {
            int totalMarks = 0;
            int obtainedMarks = 0;

            Console.Clear();
            Console.WriteLine($"==================== FINAL EXAM ({Time}) ====================");

            for (int i = 0; i < Questions.Length; i++)
            {
                Console.WriteLine($"\nQ{i + 1}) {Questions[i]}");

                int userChoice;
                do
                {
                    Console.Write("Your Choice ID: ");
                } while (!int.TryParse(Console.ReadLine(), out userChoice) || userChoice < 1 || userChoice > Questions[i].AnswerList.Length);

                Questions[i].UserAnswer = Questions[i].AnswerList[userChoice - 1];
                totalMarks += Questions[i].Mark;

                if (Questions[i].UserAnswer.AnswerId == Questions[i].RightAnswer.AnswerId)
                {
                    obtainedMarks += Questions[i].Mark;
                }
            }

            Console.Clear();
            Console.WriteLine("==================== EXAM RESULTS ====================");
            for (int i = 0; i < Questions.Length; i++)
            {
                Console.WriteLine($"Q{i + 1}: {Questions[i].Body}");
                Console.WriteLine($"Your Answer: {Questions[i].UserAnswer.AnswerText}");
                Console.WriteLine($"Right Answer: {Questions[i].RightAnswer.AnswerText}\n");
            }
            Console.WriteLine($"Your Total Grade is: {obtainedMarks} out of {totalMarks}");
        }
    }
}
