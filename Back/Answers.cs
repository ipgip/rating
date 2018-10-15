using System;

namespace Back
{
    public class Answers
    {
        private DateTime _Date;
        private int _QuestionNumber;
        private int _A;

        public Answers(DateTime value1, int v, int value2)
        {
            this._Date = value1;
            this._QuestionNumber  = v;
            this._A = value2;
        }

        public DateTime Date => _Date;
        public int QuestionNumber => _QuestionNumber;
        public int A => _A;
    }
}