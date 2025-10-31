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
    public void Exit()
    {
        Debug.Log("Simulating Quit Function, if you see this then it is working");
        Application.Quit();
    }
    public void LoadMenu()
    {
        SceneManager.LoadSceneAsync(0);
    }
    public void LevelSelect()
    {
        Time.timeScale = 1f;
        SceneManager.LoadSceneAsync(1);
    }
    public void LoadLevel1()
    {
        Time.timeScale = 1f;
        SceneManager.LoadSceneAsync(2);
    }
    public void LoadLevel2()
    {
        Time.timeScale = 1f;
        SceneManager.LoadSceneAsync(3);
    }


}
