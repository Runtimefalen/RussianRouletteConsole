public class Chamber
{
    public Chamber? Next { get; set; }

    public bool Armored { get; private set; }
    public bool Fire()
    {
        if(Armored)
        {
            Armored = false;
            return true;
        }
        return false;
    }

    public void LoadChamber()
    {
        Armored = true;
    }
}