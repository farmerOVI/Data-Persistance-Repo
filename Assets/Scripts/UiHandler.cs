using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEditor;

public class UiHandler : MonoBehaviour
{
    public Button startButton;
    public Button quitButton;
    public GameObject inputField;
    public string Name;

    // Start is called before the first frame update
    

    public void StoreName()
    {
        Name = inputField.GetComponent<Text>().text;
        
    }



    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
    public void ExitGame()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
