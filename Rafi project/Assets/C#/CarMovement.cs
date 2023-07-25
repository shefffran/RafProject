using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    [SerializeField] private float car_speed = 7f;

    private void FixedUpdate()
    {
        transform.Translate(Vector3.back * car_speed * Time.deltaTime * -1);    
    }
}
