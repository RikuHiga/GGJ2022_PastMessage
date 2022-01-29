using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgeController : MonoBehaviour
{
    //public GameObject Player;
    //PlayerController playerController;

    public GameObject pastGround;
    public GameObject nowGround;
    public GameObject child;
    public GameObject adult;

    CamControl camControl;

    private bool childFlag=true;
    // Start is called before the first frame update
    void Start()
    {
        //playerController = Player.GetComponent<PlayerController>();
        camControl = this.gameObject.GetComponent<CamControl>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (childFlag == false)
            {
                //éqãüÇ…ê¨ÇÈ
                //playerController.ChangeAge(false);
                nowGround.SetActive(false);
                pastGround.SetActive(true);
                camControl.tracedObj = child;
                childFlag = true;
                child.transform.position = new Vector3(adult.transform.position.x, 0, adult.transform.position.z);
                //this.gameObject.transform.position = new Vector3(245f,14.42f,245f);
            }

        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (childFlag == true)
            {
                //ëÂêlÇ…Ç»ÇÈ
                //playerController.ChangeAge(true);
                nowGround.SetActive(true);
                pastGround.SetActive(false);
                camControl.tracedObj = adult;
                childFlag = false;
                adult.transform.position = new Vector3(child.transform.position.x, 0, child.transform.position.z);
                //this.gameObject.transform.position = new Vector3(-255f,14.42f,-255f);
            }

        }

        if (childFlag)
        {
            adult.transform.position = new Vector3(0, -5f, 0);
        }
        else
        {
            child.transform.position = new Vector3(0, -5f, 0);
        }
    }
}
