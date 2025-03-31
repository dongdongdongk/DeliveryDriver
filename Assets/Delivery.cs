using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("충돌 발생");
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Package"))
        {
            Debug.Log("Package 트리거 발생");
        }

        if(collision.CompareTag("Customer"))
        {
            Debug.Log("Customer 트리거 발생");
        }
    }
}
