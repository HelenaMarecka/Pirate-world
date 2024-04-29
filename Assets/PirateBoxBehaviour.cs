using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PirateBoxBehaviour : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
    Debug.Log("start");    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("trigger"); 
        if (other.tag == "Player")
        {
            //play animation
            animator.SetTrigger("Open"); 
        }
    }

}
