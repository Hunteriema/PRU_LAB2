using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [Header("UI to display")]
    [SerializeField] private GameObject gameOverUI;



    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void LoadMenu()
    {
        SceneManager.LoadSceneAsync(0);
    }
    public void LevelSelect()
    {
        SceneManager.LoadSceneAsync(1);
    }
    public void LoadLevel1()
    {
        SceneManager.LoadSceneAsync(2);
    }
    public void LoadLevel2()
    {
        SceneManager.LoadSceneAsync(3);
    }
    public void LoadLevel3()
    {
        SceneManager.LoadSceneAsync(4);
    }

}
