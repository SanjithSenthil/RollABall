using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private Rigidbody sphereRigidbody;
    [SerializeField] private float ballSpeed = 2f;
    [SerializeField] private float ballJump = 1.5f;

    public void MoveBall(Vector2 inputVector) {
        Vector3 inputXZPlane = new Vector3(inputVector.x, 0, inputVector.y);
        sphereRigidbody.AddForce(inputXZPlane * ballSpeed);
    }

    public void Jump() {
        if (Physics.Raycast(transform.position, Vector3.down, 1f)) {
            sphereRigidbody.AddForce(Vector3.up * ballJump);
            Debug.Log("Ball is jumping");
        }
        else {
            Debug.Log("Ball cannot jump in air");
        }
    }
}
