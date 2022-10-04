﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : Collectable
{
    public Sprite empty;
    public int pesosAmount = 5;

    protected override void OnCollect()
    {
        if(!collected)
        {
            collected = true;
            GetComponent<SpriteRenderer>().sprite = empty;
            GameManager.instance.pesos += pesosAmount;
            GameManager.instance.ShowText("+ " + pesosAmount + " pesos!",25,Color.yellow,transform.position,Vector3.up * 50, 1.5f);
        }
    }

}
