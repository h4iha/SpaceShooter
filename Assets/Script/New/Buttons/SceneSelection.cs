using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneSelection : MonoBehaviour
{
    public void ChangeScene(int indexScene)
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(indexScene);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
