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
        Debug.Log("�׾�-----!!!!!!!! �䳢�� ü���� " + target.rabbHp + "�ۿ� �ȳ��Ҵµ� ����� " + target.countEgg +"�� ����;;;");
        
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
        Debug.Log("�Ÿ��α�");
    }

}
