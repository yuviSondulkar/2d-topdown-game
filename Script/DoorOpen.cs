using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : Collectable
{
    public Sprite Door;

    protected override void OnCollect()
    {
        GetComponent<SpriteRenderer>().sprite = Door;  
    }
}

