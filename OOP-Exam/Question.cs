using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Exam
{
    internal abstract class Question : ICloneable, IComparable<Question>
    {
        public string Header { get; set; }

        public string Body { get; set; }

        public int Mark { get; set; }

        public Answer[] AnswerList { get; set; }

        public Answer RightAnswer { get; set; }

        public Answer UserAnswer { get; set; }

        public Question(string header, string body, int mark)
        {
            Header = header;
            Body = body;
            Mark = mark;
        }

        public abstract void CreateQuestion();


        //   ------------ معرفتش اعملها لوحدي ------------
        public object Clone()
        {
            Question cloned = (Question)this.MemberwiseClone();
            if (AnswerList != null)
            {
                cloned.AnswerList = new Answer[AnswerList.Length];
                for (int i = 0; i < AnswerList.Length; i++)
                {
                    cloned.AnswerList[i] = (Answer)AnswerList[i].Clone();
                }
            }
            if (RightAnswer != null)
            {
                cloned.RightAnswer = (Answer)RightAnswer.Clone();
            }
            return cloned;
        }

        public int CompareTo(Question other)
        {
            if (other == null) return 1;
            return this.Mark.CompareTo(other.Mark);
        }

        public override string ToString()
        {
            return $"Header: {Header}\nQuestion: {Body}\tMark: {Mark}";
        }
    }
}
