using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rabbit : MonoBehaviour
{
    public float speed;
    public int rabbHp;
    public bool isRabbAlive;
    public int countEgg;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        

        float horPosition = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float verPosition = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        transform.position += new Vector3(horPosition, Input.GetAxis("Jump"), verPosition);
    }
    public void IsAlive()
    {
        if (rabbHp < 0)
        {
            Debug.Log("ав╢ы...............");
            isRabbAlive = false;
        }
    }
}
