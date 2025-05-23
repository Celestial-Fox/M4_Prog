using UnityEngine;

[RequireComponent (typeof(Rigidbody))]
public class PlayerControl : MonoBehaviour
{
    private Rigidbody body;
    [SerializeField]private float speed;
    [SerializeField]private float jumpForce;

    void Start()
    {
        body = GetComponent<Rigidbody>();
        Debug.Log("Speler klaar!");
    }

    void Update()
    {
        float input = Input.GetAxis("Horizontal");
        transform.position += Vector3.right * input * speed *Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            body.AddForce(Vector3.up*jumpForce, ForceMode.Impulse);
        }
    }
}