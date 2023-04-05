using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Gohome : MonoBehaviour
{
    
    void Start()
    {
        Debug.Log("Scene second");
    }

    public void goToHome()
    {
        SceneManager.LoadScene("first");
    }


}
