namespace RussionRullet
{
    public class Baraban
    {
        private const int BulletsCount = 6;

        private Chamber _head;
        private Chamber _current;

        public Baraban()
        {
            _head = new Chamber();
            _current = _head;

            for (int i = 1; i < BulletsCount; i++)
            {
                var newChamber = new Chamber();
                _current.Next = newChamber;
                _current = newChamber;
            }

            _current.Next = _head;
        }

        public Chamber Current => _current;

        public Chamber this[int index]
        {
            get
            {
                if (index >= BulletsCount || index < 0)
                    throw new IndexOutOfRangeException();


                if (index == 0)
                    return _head;

                var current = _head;
                for (int i = 1; i < index; i++)
                {
                    current = current.Next;
                }

                return current;
            }
        }
    }
}