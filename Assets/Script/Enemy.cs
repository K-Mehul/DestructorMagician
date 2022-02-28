using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    float speed = 5f;
    Score score;
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == gameObject.tag) {
            Destroy(gameObject); //remove enemies
            Destroy(other.gameObject); //remove projectile
            FindObjectOfType<Score>().IncrementScore();
        }
        else {
            Destroy(other.gameObject);
            FindObjectOfType<UIManager>().spawnPanel.SetActive(false);
            FindObjectOfType<UIManager>().gameOverPanel.SetActive(true);
            FindObjectOfType<UIManager>().gameOverTxt.SetActive(true);
            FindObjectOfType<UIManager>().playBtn.SetActive(false);
            Time.timeScale = 0;
        }

      if(other.tag == "Player") {
        FindObjectOfType<UIManager>().spawnPanel.SetActive(false);
        FindObjectOfType<UIManager>().gameOverPanel.SetActive(true);
        FindObjectOfType<UIManager>().gameOverTxt.SetActive(true);
        FindObjectOfType<UIManager>().playBtn.SetActive(false);
        Time.timeScale = 0;

      }
    }
}
