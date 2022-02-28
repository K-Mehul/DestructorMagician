
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{

    public static UIManager uiManager;
    public GameObject pausePanel,gameOverPanel;
    public GameObject spawnPanel,pauseTxt,gameOverTxt;
    public GameObject playBtn;


    void Start() {
        if(uiManager = null) {
            uiManager = this;
        } 
    }

    public void Pause() {
        if(Time.timeScale == 1) {
            Time.timeScale = 0;
            spawnPanel.SetActive(false);
            pausePanel.SetActive(true);
            pauseTxt.SetActive(true);
            playBtn.SetActive(false);
            Ads.instance.ShowFullScreenAd();
        }
    }

    public void Play() {
        if(Time.timeScale == 0) {
            Time.timeScale = 1;
            spawnPanel.SetActive(true);
            pausePanel.SetActive(false);
            pauseTxt.SetActive(false);
            playBtn.SetActive(true);
        }
    }

    public void Quit() {
        Application.Quit();
        print("Quit");
    }

    public void Retry() {
        SceneManager.LoadScene("main");
        Time.timeScale = 1;
    }

    public void Home() {
        SceneManager.LoadScene("menu");
    }
}
