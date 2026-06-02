using UnityEngine;

public class AI : MonoBehaviour
{
    public Transform ball;
    public float speed = 6f;

    void Update()
    {
        // Only move when ball is on AI side
        if (ball.position.x > 4.5f)
        {
            Vector3 target = new Vector3(
                transform.position.x,
                ball.position.y,
                transform.position.z
            );

            transform.position = Vector3.MoveTowards(
                transform.position,
                target,
                speed * Time.deltaTime
            );
        }
    }
}