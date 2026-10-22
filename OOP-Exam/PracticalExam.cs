using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Exam
{
    internal class PracticalExam : Exam
    {
        public PracticalExam(int time, int numberOfQuestions) : base(time, numberOfQuestions)
        {
        }

        public override void ShowExam()
        {
            Console.Clear();
            Console.WriteLine($"==================== PRACTICAL EXAM ({Time}) ====================");

            for (int i = 0; i < Questions.Length; i++)
            {
                Console.WriteLine($"\nQ{i + 1}) {Questions[i]}");

                int userChoice;
                do
                {
                    Console.Write("Your Choice ID: ");
                } while (!int.TryParse(Console.ReadLine(), out userChoice) || userChoice < 1 || userChoice > Questions[i].AnswerList.Length);

                Questions[i].UserAnswer = Questions[i].AnswerList[userChoice - 1];
            }

            Console.Clear();
            Console.WriteLine("==================== RIGHT ANSWERS ====================");
            for (int i = 0; i < Questions.Length; i++)
            {
                Console.WriteLine($"Q{i + 1}: {Questions[i].Body}");
                Console.WriteLine($"Right Answer: {Questions[i].RightAnswer.AnswerText}\n");
            }
        }
    }
}

