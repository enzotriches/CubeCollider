using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;
    public float zForce = 4000f; // para a frente
    public float xForce = 40f; // lados

    // Use this for initialization
    void Start ()
    {
        Debug.Log("Hello, World!");
    }
	
	// Update is called once per frame
	void FixedUpdate ()
    {


        rb.AddForce(0, 0, zForce * Time.deltaTime);
       
        //D
        if (Input.GetKey("d"))
        {
            rb.AddForce(xForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        //A
        if (Input.GetKey("a"))
        {
            rb.AddForce(-xForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (rb.position.y < -1f)
        {
           
                FindObjectOfType<GameManager>().GameOver();
               
        }

    }
}
