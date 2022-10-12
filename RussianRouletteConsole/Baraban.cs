public class Baraban
{
    public const int BulletsCount = 6;

    private Chamber _head;
    private Chamber _current;

    // Baraban chamber class description
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

    public bool IsEmpty()
    {
        var current = _head;
        for (int i = 0; i < BulletsCount; i++)
        {
            if(current.Armored)
                return false;
            current = current.Next!;
        }
        return true;
    }

    public void LoadBarabanChamber(int index)
    {
        var current = _head;
        for (int i = 0; i < index; i++)
        {
            current = current.Next!;
        }
        current.LoadChamber();
    }

    public bool Fire()
    {
        var result = _current.Fire();
        _current = _current.Next!;
        return result;

    }

    public void Rotate(int count)
    {
        for (int i = 0; i < count; i++)
        {
            _current = _current.Next!;
        }
    }
}