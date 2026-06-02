using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody2D rb;

    public void ResetBall()
    {
        rb.velocity = Vector2.zero;

        transform.position = Vector3.zero;

        Invoke(nameof(LaunchBall), 1f);
    }

    public void LaunchBall()
    {
        float x = Random.value > 0.5f ? 1f : -1f;
        float y = Random.Range(-1f, 1f);

        rb.velocity = new Vector2(x, y).normalized * 12f;
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Paddle"))
        {
            float paddleHeight =
                collision.collider.bounds.size.y;

            float relativeIntersectY =
                transform.position.y - collision.transform.position.y;

            float normalized =
                relativeIntersectY / (paddleHeight / 2f);

            float maxBounceAngle = 75f;

            float bounceAngle =
                normalized * maxBounceAngle;

            float speed = rb.velocity.magnitude;

            float directionX =
                collision.transform.position.x < 0 ? 1f : -1f;

            Vector2 newDirection =
                new Vector2(
                    directionX * Mathf.Cos(bounceAngle * Mathf.Deg2Rad),
                    Mathf.Sin(bounceAngle * Mathf.Deg2Rad)
                );

            rb.velocity = newDirection.normalized * speed;
        }
    }
    public void StopBall()
    {
        rb.velocity = Vector2.zero;
    }
}