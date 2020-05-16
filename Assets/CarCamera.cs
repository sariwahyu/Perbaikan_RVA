using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarCamera : MonoBehaviour
{
	public Camera usercam = default;
	private bool inCar = false;
	public Camera rotcam = default;
	// private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        usercam.enabled = false;
        inCar = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) //get in
        {
            usercam.enabled = true;
            rotcam.enabled = false;
            // player.SetActive(false);
            // player.transform.parent = this.transform;
            usercam.transform.parent = this.transform;
            // inCar = true;
        }
        else if (Input.GetKeyDown(KeyCode.O)) {
        	usercam.enabled = false;
        	rotcam.enabled = true;
        	// inCar = false;
        }
    }
}
