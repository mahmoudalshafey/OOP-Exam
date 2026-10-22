using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Exam
{
    internal abstract class Exam : ICloneable
    {
        public int Time { get; set; }
        public int NumberOfQuestions { get; set; }
        public Question[] Questions { get; set; }

        public Exam(int time, int numberOfQuestions)
        {
            Time = time;
            NumberOfQuestions = numberOfQuestions;
            Questions = new Question[numberOfQuestions];
        }

        public object Clone()
        {
            Exam cloned = (Exam)this.MemberwiseClone();
            if (Questions != null)
            {
                cloned.Questions = new Question[Questions.Length];
                for (int i = 0; i < Questions.Length; i++)
                {
                    cloned.Questions[i] = (Question)Questions[i].Clone();
                }
            }
            return cloned;
        }

        public abstract void ShowExam();
    }
}
