using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Page : MonoBehaviour
{
    
    void Start()
    {
        SoundManager sm = SoundManager.GetInstance();

        sm.PlayMusic();
    }

    
}
