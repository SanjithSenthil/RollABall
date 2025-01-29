using UnityEngine;

public class BallController : MonoBehaviour
{
    public Rigidbody sphereRigidbody;
    public float ballSpeed = 2f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Calling the Start method");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Calling the Update method");

        Vector2 inputVector = Vector2.zero;

        if (Input.GetKey(KeyCode.W)) {
            Debug.Log("User's Input: W");
            inputVector += Vector2.up;
        }
        else if (Input.GetKey(KeyCode.A)) {
            Debug.Log("User's Input: A");
            inputVector += Vector2.left;
        }
        else if (Input.GetKey(KeyCode.S)) {
            Debug.Log("User's Input: S");
            inputVector += Vector2.down;
        }
        else if (Input.GetKey(KeyCode.D)) {
            Debug.Log("User's Input: D");
            inputVector += Vector2.right;
        }

        Vector3 inputXZPlane = new Vector3(inputVector.x, 0, inputVector.y);
        sphereRigidbody.AddForce(inputXZPlane * ballSpeed);

        Debug.Log("Resultant Vector: " + inputVector);
        Debug.Log("Resultant 3D Vector: " + inputXZPlane);
    }
}
