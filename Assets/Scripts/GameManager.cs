using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]private float speed = 5;
    [SerializeField]private float remainingTime = 20;
    private int score = 0;

    private Rigidbody body;

    private void Awake()
    {
        body = GetComponent<Rigidbody>();
    }
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        transform.position += Vector3.right * inputX * speed * Time.deltaTime;
        float inputZ = Input.GetAxis("Vertical");
        transform.position += Vector3.forward * inputZ * speed * Time.deltaTime;

        if (remainingTime < 0)
        {
            Debug.Log("Game Over! Endscore: " + score);

            enabled = false;
            return;
        }

        remainingTime -= Time.deltaTime;


        if (remainingTime > 0)
        {
            Debug.Log("Time remaining: " + Mathf.Round(remainingTime) + "| Score achieved: " + score);
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("!!");
        if (other.gameObject.CompareTag("Coin"))
         {
            score += 10;

            Debug.Log("Wahoo Coin! +10 points!");

            Destroy(other.gameObject);

        }
    }
}