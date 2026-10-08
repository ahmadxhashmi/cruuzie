using UnityEngine;

public class Driver : MonoBehaviour
{

    [SerializeField] float steerSpeed = 300.0f;
    [SerializeField] float moveSpeed = 20.0f;
    [SerializeField] float slowSpeed = 20.0f;
    [SerializeField] float boostSpeed = 50.0f;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        moveSpeed = slowSpeed;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "nitro")
        {
           moveSpeed = boostSpeed;
        }
    }

}
