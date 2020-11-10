
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    public void StartGame()
    {
        Debug.Log("StartGame");
        //SceneManager.LoadScene(SceneManager.GetSceneByBuildIndex(1).buildIndex);
        SceneManager.LoadScene(1);
    
    }
    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
    public void StartMenu()
    {

        Debug.Log("Menu");
        SceneManager.LoadScene(0);
    }

}
