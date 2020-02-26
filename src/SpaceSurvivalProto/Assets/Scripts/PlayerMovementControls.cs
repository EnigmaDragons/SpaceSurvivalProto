using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovementControls : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 20.0f;
    
    private Rigidbody body;

    private float xDir;
    private float zDir;
    private float diagonalMoveFactor = 0.7f;

    void Awake ()
    {
        body = GetComponent<Rigidbody>();
    }

    void Update()
    {
        xDir = Input.GetAxisRaw("Horizontal");
        zDir = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        if (xDir != 0 && zDir != 0) // Check for diagonal movement
        {
            xDir *= diagonalMoveFactor;
            zDir *= diagonalMoveFactor;
        } 

        body.velocity = new Vector3(xDir * moveSpeed, body.velocity.y, zDir * moveSpeed);
    }
}
