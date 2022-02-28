using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject[] projectiles;

    public void P1() {
        Instantiate(projectiles[0],transform.position ,Quaternion.identity);   
    }

    public void P2() {
        Instantiate(projectiles[1],transform.position,Quaternion.identity);
    }

    public void P3() {
        Instantiate(projectiles[2],transform.position,Quaternion.identity);
    }

}
