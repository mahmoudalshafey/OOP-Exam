using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Exam
{
    internal class McqQuestion : Question
    {
        public McqQuestion(string body, int mark): base("MCQ Question", body, mark)
        {
        }

        public override void CreateQuestion()
        {
            AnswerList = new Answer[4];
            Console.WriteLine("Enter the 4 choices for the question:");
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"Choice {i + 1}: ");
                string choiceText = Console.ReadLine();
                AnswerList[i] = new Answer(i + 1, choiceText);
            }

            int rightAnswerId;
            do
            {
                Console.Write("Enter the right answer id (1, 2, 3, or 4): ");
            } while (!int.TryParse(Console.ReadLine(), out rightAnswerId) || rightAnswerId < 1 || rightAnswerId > 4);

            RightAnswer = AnswerList[rightAnswerId - 1];
        }
        public override string ToString()
        {
            string result = base.ToString() + "\nChoices:\n";
            foreach (var answer in AnswerList)
            {
                result += $"{answer}\n";
            }
            return result.TrimEnd();
        }
    }
}
