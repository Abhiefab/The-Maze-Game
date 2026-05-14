using System;
using UnityEngine;

public class characterController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    CharacterController charControl;
    public float movespeed = 2f;

    void Start()
    {
        charControl = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float mh = Input.GetAxis("Horizontal");
        float mv = Input.GetAxis("Vertical");
        Vector3 moveC = new Vector3(mv,0f,mh);
        charControl.Move(moveC*movespeed*Time.deltaTime);
        

        
    }
}
