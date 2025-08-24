using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject StartScreen;
    public GameObject GameOverScreen;

    void Start()
    {
        StartScreen.SetActive(true);
        GameOverScreen.SetActive(false);
        Time.timeScale = 0f; // pause game at start
    }

    public void StartGame()
    {
        StartScreen.SetActive(false);
        Time.timeScale = 1f; // resume game
    }

    public void GameOver()
    {
        GameOverScreen.SetActive(true);
        Time.timeScale = 0f; // pause game
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
