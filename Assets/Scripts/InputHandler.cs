
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

[SerializeField]


public class InputHandler : MonoBehaviour
{
    private string input;
    public string playerName;
    public static InputHandler Instance;

  
 

    private void Start()
    {
        playerName = PlayerPrefs.GetString("playerName", "No Name");
    }

    public void ReadPlayerName(string s)
    {
        input = s;
        playerName = input;
       PlayerPrefs.SetString("playerName", playerName);
        

    }






}
