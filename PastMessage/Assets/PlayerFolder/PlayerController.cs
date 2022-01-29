using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 10.0f;
    private Rigidbody rb;
    private CapsuleCollider capsuleCollider;
    private SpriteRenderer spriteRenderer;

    public Sprite adult;
    public Sprite child;


    
    // Start is called before the first frame update
    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody>();
        capsuleCollider = this.gameObject.GetComponent<CapsuleCollider>();
        spriteRenderer = this.gameObject.GetComponent<SpriteRenderer>();
    }
    private void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal") * speed;
        float z = Input.GetAxis("Vertical") * speed;
        rb.AddForce(x, 0, z);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChangeAge(bool adultFlag)
    {
        if (adultFlag == false)
        {
            //éqãü
            spriteRenderer.sprite = child;
        }
        else
        {
            //ëÂêl
            spriteRenderer.sprite = adult;
        }
    }
}
