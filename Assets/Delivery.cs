using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{

    [SerializeField] Color32 hasPackageColor = new(255, 255, 255, 255);
    [SerializeField] Color32 noPackageColor = new(255, 255, 255, 255);
    [SerializeField] float destroyDelay = 0.5f;
    bool hasPackage;

    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("충돌 발생");
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Package") && !hasPackage)
        {
            Debug.Log("Package 직업");
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(collision.gameObject, destroyDelay);
        }

        if(collision.CompareTag("Customer") && hasPackage)
        {
            Debug.Log("Customer 배달 성공");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
        }
    }
}
