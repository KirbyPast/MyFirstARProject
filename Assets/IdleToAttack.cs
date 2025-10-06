using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleToAttack : MonoBehaviour
{
    public GameObject cactusA;          
    public GameObject cactusB;          
    public Animator animatorA;
    public Animator animatorB;

    private bool hasAttacked;

    void Update()
    {
        float dist = Vector3.Distance(cactusA.transform.position, cactusB.transform.position);

        if (dist <= 0.2f)
        {
            animatorA.SetTrigger("TrAttack");
            animatorB.SetTrigger("TrAttack");
        }
    }
}
