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

    private Vector3 adultPos = new Vector3(-250,0,-250);
    private Vector3 childPos= new Vector3(250,0,250);

    
    bool nowAdultFlag = false;
    float CHILD_CENTER_Y = -1.28f;
    float CHILD_HEIGHT = 5.08f;
    float ADULT_CENTER_Y = -0.3f;
    float ADULT_HEIGHT = 7.01f;
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
        if (adultFlag != nowAdultFlag)
        {
            nowAdultFlag = adultFlag;
            if (adultFlag == false)
            {
                //子供(右上)
                spriteRenderer.sprite = child;
                Vector3 posDiff = new Vector3(transform.position.x - adultPos.x, 0, transform.position.z - adultPos.z);
                Debug.Log(posDiff);
                this.gameObject.transform.position = new Vector3(childPos.x + posDiff.x, 3.83f, childPos.x + posDiff.z);
            }
            else
            {
                //大人（左下）
                spriteRenderer.sprite = adult;
                Vector3 posDiff = new Vector3(transform.position.x - childPos.x, 0, transform.position.z - childPos.z);
                Debug.Log(posDiff);
                this.gameObject.transform.position = new Vector3(adultPos.x + posDiff.x, 3.83f, adultPos.x + posDiff.z);
            }
        }

    }
}
