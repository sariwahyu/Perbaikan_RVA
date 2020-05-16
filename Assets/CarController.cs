using UnityEngine;
using System.Collections;

public class CarController : MonoBehaviour {

    public WheelCollider WheelFL;
    public WheelCollider WheelFR;
    public WheelCollider WheelBL;
    public WheelCollider WheelBR;

    public GameObject FL;
    public GameObject FR;
    public GameObject BL;
    public GameObject BR;

    private float topSpeed = 250f;
    private float maxTorque = 200f;

    public float maxSteerAngle = 45f;
    public float currentSpeed;
    public float maxBrakeTorque = 220f;

    private float Forward;
    private float Turn;
    private float Brake;

    private Rigidbody rb;
    // public Camera usercam;
    // private GameObject player;
    // public Transform centreofmass;

    void Start() 
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
    	Forward = Input.GetAxis("Vertical");
   		Turn = Input.GetAxis("Horizontal");
   		Brake = Input.GetAxis("Jump");

   		WheelFL.steerAngle = maxSteerAngle * Turn;
   		WheelFR.steerAngle = maxSteerAngle * Turn;

   		currentSpeed = 2 * 22/7 * WheelBL.radius * WheelBL.rpm * 60 / 1000;

   		if(currentSpeed < topSpeed)
        {
        	WheelBL.motorTorque = maxTorque * Forward;
        	WheelBR.motorTorque = maxTorque * Forward;
        }

        WheelFL.brakeTorque = maxBrakeTorque * Brake;
        WheelFR.brakeTorque = maxBrakeTorque * Brake;
        WheelBL.brakeTorque = maxBrakeTorque * Brake;
        WheelBR.brakeTorque = maxBrakeTorque * Brake;
    }

    void Update()
    {

    	// Quaternion flq;
    	// Vector3 flv;

    	// WheelFL.GetWorldPose(out flv, out flq);

    	// FL.transform.position = flv;
    	// FL.transform.rotation = flq;

    	// Quaternion blq;
    	// Vector3 blv;

    	// WheelBL.GetWorldPose(out blv, out blq);

    	// BL.transform.position = blv;
    	// BL.transform.rotation = blq;

    	// Quaternion frq;
    	// Vector3 frv;

    	// WheelFR.GetWorldPose(out frv, out frq);

    	// FR.transform.position = frv;
    	// FR.transform.rotation = frq;

    	// Quaternion brq;
    	// Vector3 brv;

    	// WheelBR.GetWorldPose(out brv, out brq);

    	// BR.transform.position = brv;
    	// BR.transform.rotation = brq;
    }
}