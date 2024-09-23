using UnityEngine;

public class launcher : MonoBehaviour
{
    public float angleDegrees=30;
    public float speed=100;
    public float deltaTime = 0.02f;
    public Vector3 velocity;
    public Vector3 gravityAcceleration = new Vector3(0, -10, 0);

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            velocity = new Vector3(10, 16);
            transform.position = Vector3.zero;
        }
    }

    private void FixedUpdate()
    {
        Vector3 prevPos = transform.position;
        transform.position = transform.position + velocity * deltaTime;
        velocity = velocity + gravityAcceleration * deltaTime;

    }

    public void launch()
    {

    }
}
