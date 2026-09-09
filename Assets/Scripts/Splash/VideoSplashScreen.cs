using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class SplashScreen : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public float splashDuration = 3f;

    void Start()
    {
        videoPlayer.isLooping = true;

        videoPlayer.Play();

        Invoke(nameof(LoadNextScene), splashDuration);
    }

    void LoadNextScene()
    {
        videoPlayer.Stop();

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}