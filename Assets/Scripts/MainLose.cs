using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainLose : MonoBehaviour
{
    public void PlayAgain(){
        SceneManager.LoadScene(0);
    }
    public void Quit(){
        Application.Quit();
    }
   
}

