using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Movement : MonoBehaviour
{
    public float speed = 3;

    void Update()
    {
        transform.position += new Vector3(Input.GetAxis("h2"), 0, Input.GetAxis("v2")) * Time.deltaTime * speed;
    }
}
