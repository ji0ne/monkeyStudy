using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    private static SoundManager instance;
    public string musicTitle;
    private void Awake()
    {
        if (instance !=null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }
    public static SoundManager GetInstance()
    {
        if (instance == null)
        {
            var obj = FindObjectOfType<SoundManager>();

            if(obj != null)
            {
                instance = obj;
            }
        }

        return instance;
    }

    public void PlayMusic()
    {
        Debug.Log($"NowPlaying. . . : {musicTitle}");
    }


}
