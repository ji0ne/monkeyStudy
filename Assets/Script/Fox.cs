using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fox : MonoBehaviour
{
    public int foxAp;
    public Rabbit target;
    void Start()
    {
        
    }
   

    void Update()
    {
     
    } 
    void FoxAttack()
    {
        target.rabbHp -= foxAp;
        target.countEgg -= 1;
        Debug.Log("죽어-----!!!!!!!! 토끼의 체력이 " + target.rabbHp + "밖에 안남았는데 계란도 " + target.countEgg +"개 뺏김;;;");
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name != "Rabbit") return;
        GameObject target = collision.gameObject;
        Rabbit instance = target.GetComponent<Rabbit>();
        this.target = instance;
        FoxAttack();
    }
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("거리두기");
    }

}
