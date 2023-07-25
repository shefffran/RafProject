using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tunel1 : MonoBehaviour
{

    [SerializeField] private Transform tunel_pos;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Car")
        {
            other.transform.position = tunel_pos.transform.position;
        }
    }
}
