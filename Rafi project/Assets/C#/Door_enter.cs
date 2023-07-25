using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_enter : MonoBehaviour
{
    [SerializeField] private GameObject pressE_button;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    //---------------------------------------------------------------------------------------------

    private bool work_just_once;


    private void OnTriggerEnter(Collider other)
    {
        work_just_once = true;

        if(other.tag == "Player")
        {
            pressE_button.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {

        if (other.tag == "Player")
        {
            pressE_button.SetActive(false);
        }
    }

    private void OnTriggerStay(Collider other)
    {

        if (other.tag == "Player"  && Input.GetKey(KeyCode.E))
        {
            if (work_just_once)
            {
                work_just_once = false;
            }
        }
    }
}
