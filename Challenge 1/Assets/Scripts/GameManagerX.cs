using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameManagerX : MonoBehaviour
{
    public GameObject gameOverUI;
    public PlayerControllerX playerController;
    public float restartDelay = 1.5f;   // delay time (in seconds)

    public void GameOver()
    {
        gameOverUI.SetActive(true);
        playerController.enabled = false;   // Stop plane control
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        StartCoroutine(RestartAfterDelay());
    }

    private IEnumerator RestartAfterDelay()
    {
        yield return new WaitForSeconds(restartDelay);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
