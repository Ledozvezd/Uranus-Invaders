using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour 
{ 
    public void ChangeScene() 
    {
        SceneManager.LoadScene("Game");
    } 
    private void Exit() 
    { 
        Application.Quit(); 
    }
}