using UnityEngine;

public class LeftPaddle : MonoBehaviour
{
    public float speed = 8f;

    void Update()
    {
        float move = Input.GetAxis("Vertical");

        transform.Translate(Vector2.up * move * speed * Time.deltaTime);
    }
}