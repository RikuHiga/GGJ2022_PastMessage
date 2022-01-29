using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgeController : MonoBehaviour
{
    public GameObject Player;
    PlayerController playerController;
    // Start is called before the first frame update
    void Start()
    {
        playerController = Player.GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            playerController.ChangeAge(false);
            this.gameObject.transform.position = new Vector3(245f,14.42f,245f);
            //Player.transform.position = new Vector3(250, 3.83f, 250);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            playerController.ChangeAge(true);
            this.gameObject.transform.position = new Vector3(-255f,14.42f,-255f);
            //Player.transform.position = new Vector3(-250, 3.83f, -250);
        }
    }
}
