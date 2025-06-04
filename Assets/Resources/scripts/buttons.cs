using UnityEngine;
using UnityEngine.SceneManagement;

public class button : MonoBehaviour
{
    public string sceneName;
    public bool quitGame = false;
    public void LoadScene()
    {
        if (quitGame)
        {
            Debug.Log("Quitting game...");
            Application.Quit();

            #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false; // Stop play mode in the editor
            #endif
        }
        else if (!string.IsNullOrEmpty(sceneName))
        {
            SceneManager.LoadScene(sceneName);
        }
        else
        {
            Debug.LogWarning("Scene name is empty and quitGame is false on " + gameObject.name);
        }
    }
}