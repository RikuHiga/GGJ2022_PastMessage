using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgeController : MonoBehaviour
{
    //public GameObject Player;
    //PlayerController playerController;

    public GameObject pastGround;
    public GameObject nowGround;
    // Start is called before the first frame update
    void Start()
    {
        //playerController = Player.GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            //éqãüÇ…ê¨ÇÈ
            //playerController.ChangeAge(false);
            nowGround.SetActive(false);
            pastGround.SetActive(true);
            //this.gameObject.transform.position = new Vector3(245f,14.42f,245f);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            //ëÂêlÇ…Ç»ÇÈ
            //playerController.ChangeAge(true);
            nowGround.SetActive(true);
            pastGround.SetActive(false);
            //this.gameObject.transform.position = new Vector3(-255f,14.42f,-255f);
        }
    }
}
