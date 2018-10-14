namespace rating
{
    public  class Questions
    {
        private string _Question;
        private int _Answers;
        private bool _Logical;

        public Questions(string question, int answers, bool logical)
        {
            _Question = question;
            _Answers = answers;
            _Logical = logical;
        }

        public string Question => _Question;
        public int Answers => _Answers;
        public bool Logical => _Logical;
    }
}