using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 hasPackageColor = new Color32(0, 0, 0, 0);
    [SerializeField] Color32 noPackageColor = new Color32(0, 0, 0, 0);    

    [SerializeField] float destroyDelayTime = 0.3f;
    bool hasPackage;

    SpriteRenderer spriteRenderer;

    void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "package" && !hasPackage) {
            Debug.Log("package picked up");
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject, destroyDelayTime);
        }

        if (other.tag == "customer" && hasPackage) {
           Debug.Log("you deliverd to the customer");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
        }
    }
}
