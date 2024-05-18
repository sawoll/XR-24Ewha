using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elevator : MonoBehaviour
{
    public GameObject elev;
    
    private void OnTriggerStay()
    { 
        elev.transform.position += elev.transform.up * Time.deltaTime; 
    }
}
