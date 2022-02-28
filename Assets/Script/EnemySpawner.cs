using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] enemies;
    
    void Start() {
        StartCoroutine(Spawning());    
    }
    public void EnemySpawning() {
        int rand = Random.Range(0,enemies.Length);
        GameObject enemy =   Instantiate(enemies[rand],transform.position,Quaternion.identity) as GameObject;
    }

    IEnumerator Spawning() {
        while(true) {
            yield return new WaitForSeconds(0.5f);
            EnemySpawning();
        }
    }
}
