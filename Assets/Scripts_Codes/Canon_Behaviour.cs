using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canon_behaviour : MonoBehaviour
{
    public AudioClip cannonShot;

    public GameObject ui;
    // Start is called before the first frame update
    void Start()
    {
        HideUI();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        ShowUI();
        if(other.tag == "Player")
        {
            gameObject.GetComponent<AudioSource>().PlayOneShot(cannonShot);
        }
    }

    public void ShootCannon() 
    {

     gameObject.GetComponent<AudioSource>().PlayOneShot(cannonShot);   
    }


    public void HideUI() 
    {
        ui.SetActive(false);

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    public void ShowUI() 
    {
        ui.SetActive(true);

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
