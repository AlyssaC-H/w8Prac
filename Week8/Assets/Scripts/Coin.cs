using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        if(col.CompareTag("Player"))
        {
            FindObjectOfType<UpdateScore>().IncreaseScore(1);
            Destroy(gameObject);
        }
    }
}
