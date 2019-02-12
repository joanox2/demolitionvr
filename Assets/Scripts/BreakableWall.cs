using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableWall : MonoBehaviour
{
    [SerializeField]GameObject wall;
    [SerializeField]GameObject bricks;
     bool moving=false;
     float counter=10;
    private void OnTriggerEnter(Collider other) {
        wall.SetActive(false);
        bricks.SetActive(true);
        moving=true;
    }
    private void Update() {
        counter-=Time.deltaTime;
        if(moving){

        }
    }
}
