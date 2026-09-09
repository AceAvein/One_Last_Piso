using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;

    public void Pause(){
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
    }

    public void Continue(){
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }

    public void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }

    public void Home(){
        SceneManager.LoadScene("MenuScreen");
        Time.timeScale = 1;
    }

}
