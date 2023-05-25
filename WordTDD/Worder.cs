namespace WordTDD
{
    public class Worder
    {
        private string _word;
        public Worder(string testWord)
        {
            _word = testWord;

        }

        public bool IsEmpty()
        {
            return _word.Length == 0 ? true : false;
        }

        public bool IsPalindrome()
        {
            _word = _word.Replace(" ", "");

            int position = 0;
            int lettersLeft = _word.Length - 1;

            while (position < lettersLeft)
            {
                if (_word[position] != _word[lettersLeft])
                    return false;

                position++;
                lettersLeft--;
            }

            return true;
        }
    }
}