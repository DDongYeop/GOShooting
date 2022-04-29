using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Movement movement;

    void Awake()
    {
        movement = GetComponent<Movement>();
    }


    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        movement.MoveTo(new Vector3(x, y, 0));
    }
}
