using System;

public class Gun
{
	private readonly Baraban _baraban;
	private readonly Random _random;
	public Gun()
    {
		_baraban = new Baraban();
		_random = new Random();
    }
	public void Spin()
	{
		int spinCount = _random.Next(1,6);
		_baraban.Rotate(spinCount);
	}

	public void LoadGunWithOneBullet()
    {
		int chamberIndex = _random.Next(0, 5);
		_baraban.LoadBarabanChamber(chamberIndex);
	}

	//public void LoadGunWithFullBaraban()
 //   {
 //       for (int i = 0; i < Baraban.BulletsCount - 1; i++)
 //       {
	//		_baraban.LoadBarabanChamber(i);
	//	}
	//}

	public void ReloadIfEmpty()
    {
		if (_baraban.IsEmpty())
        {
			LoadGunWithOneBullet();
        }
    }

	public bool Fire()
    {
		return _baraban.Fire();
    }
}
