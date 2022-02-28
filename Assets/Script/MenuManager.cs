using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    public GameObject playBtn,quitBtn,aboutBtn,aboutPanel;

    void Start() {
        aboutPanel.SetActive(false);
    }
   public void Play() {
       SceneManager.LoadScene("main");
       Time.timeScale = 1;
   }

   public void Quit() {
       Application.Quit();
   }

   public void AboutBtnON() {
       playBtn.SetActive(false);
       quitBtn.SetActive(false);
       aboutPanel.SetActive(true);
       aboutBtn.SetActive(false);
       Ads.instance.ShowFullScreenAd();
   }

   public void AboutBtnOFF() {
       playBtn.SetActive(true);
       quitBtn.SetActive(true);
       aboutPanel.SetActive(false);
       aboutBtn.SetActive(true);
   }
}
 