using UnityEngine;

public class Delivery : MonoBehaviour
{

    bool haspackage;
    [SerializeField] Color32 hasPackageColor = new Color32 (0, 0, 1, 1);
    [SerializeField] Color32 noPackageColor = new Color32 (1, 0, 0, 1);
    [SerializeField] float destroyDelay = 0.5f;
    SpriteRenderer spriteRenderer;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Ooouuuchhhh!");
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Package" && !haspackage)
        {
            Debug.Log("Package picked up!");
            haspackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(collision.gameObject,destroyDelay);
        }
        else if(collision.tag == "Customer" && haspackage)
        {
            Debug.Log("Package Delivered");
            haspackage = false;
            spriteRenderer.color = noPackageColor;
        }

    }
}
