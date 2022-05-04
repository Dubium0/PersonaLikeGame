using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BattleHUD : MonoBehaviour
{
    public string nameText;
	public Slider hpSlider;

    public Slider spSlider;

	public void SetHUD(Unit unit)
	{
		nameText = unit.unitName;
		hpSlider.maxValue = unit.maxHP;
		hpSlider.value = unit.currentHP;
        spSlider.maxValue = unit.maxSP;
		spSlider.value = unit.currentSP;

        

	}

	public void SetHP(int hp)
	{
		hpSlider.value = hp;
	}
    public void SetSP(int sp){
        spSlider.value = sp;
    }
}
