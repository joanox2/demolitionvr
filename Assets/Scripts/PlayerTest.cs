using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTest : MonoBehaviour
{
    public Rigidbody bola;
    public float power;
  
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
            bola.AddForce(new Vector3(0,0,power),ForceMode.Impulse);
    }
}
