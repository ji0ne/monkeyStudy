using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public Text Hello;
    
    void Start()
    {
        Hello.text = "겜시작 ~~~~";
       
    }

    public void sceneChange()
    {
        Debug.Log("변신~~~~~~~~~~~~~~~~");
        SceneManager.LoadScene("second");
    }

    
}
