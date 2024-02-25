using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float movespeed = 5f;

    private Master controls;
    // Start is called before the first frame update
    void Start()
    {
        controls = newMaster();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
