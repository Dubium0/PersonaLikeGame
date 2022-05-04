using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    public string unitName;

	public int damage;

	public int maxHP;
	public int currentHP;

    public int maxSP;
	public int currentSP;
    public bool TakeDamage(int dmg)
	{
		currentHP -= dmg;

		if (currentHP <= 0)
			return true;
		else
			return false;
	}
    public bool ConsumeSp(int amount)
    {
        currentSP -= amount;

		if (currentSP <= -10)
			return true;
		else
			return false;

    }

	public void Heal(int amount)
	{
		currentHP += amount;
		if (currentHP > maxHP)
			currentHP = maxHP;
	}


    
}
