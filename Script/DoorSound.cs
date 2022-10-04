using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSound : MonoBehaviour
{
    [SerializeField] private AudioSource Gate;
    // Start is called before the first frame update
    void Start()
    {
        Gate.Play();
    }

}
