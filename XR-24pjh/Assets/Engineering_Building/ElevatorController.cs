using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorController : MonoBehaviour
{
    public Animator animator;
    int flag = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Robot_Transform")
        {
            print("trigger enter");
            if (flag == 0) // up
            {
                animator.SetInteger("Controll", 1);
                flag = 1;
            }
            else if(flag == 1) // down
            {
                animator.SetInteger("Controll", 2);
                flag = 0;
            }
            
        }
    }
    private void OnTriggerExit(Collider other)
    {

    }
}
