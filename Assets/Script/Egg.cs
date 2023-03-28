using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Egg : MonoBehaviour
{
    public Rabbit predator;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    void GetEgg()
    {
        predator.countEgg += 1;
        gameObject.SetActive(false);
        Debug.Log("계란"+ predator.countEgg+ "주움");
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name != "Rabbit") return;

        GameObject egg = collision.gameObject;
        Rabbit instance = egg.GetComponent<Rabbit>();
        this.predator = instance;
        GetEgg();
    }
}
