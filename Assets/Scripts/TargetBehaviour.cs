using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetBehaviour : MonoBehaviour
{
    private void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Debug.Log("si");
            gameObject.GetComponent<Light>().color = Color.green;
        }

        Debug.Log("si");
    }

}
