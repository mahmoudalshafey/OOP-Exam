using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Exam
{
    internal class TrueFalseQuestion : Question
    {
        public TrueFalseQuestion(string body, int mark) : base("True / False Question", body, mark)
        {
        }

        public override void CreateQuestion()
        {
            AnswerList = new Answer[2]
            {
                new Answer(1, "True"),
                new Answer(2, "False")
            };

            int rightAnswerId;
            do
            {
                Console.Write("Enter the right answer id (1 for True, 2 for False): ");
            } while (!int.TryParse(Console.ReadLine(), out rightAnswerId) || (rightAnswerId != 1 && rightAnswerId != 2));

            RightAnswer = AnswerList[rightAnswerId - 1];
        }
        public override string ToString()
        {
            return $"{base.ToString()}\n1. True\t2. False";
        }
    }
}
