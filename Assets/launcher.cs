using UnityEngine;

public class launcher : MonoBehaviour
{
    public float angleDegrees=30;
    public float speed=100;
    float dt;
    public Vector3 velocity;
    public Vector3 gravityAcceleration;
    public float startHeight = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // Update is called once per frame

    private void Start()
    {  gravityAcceleration = Physics.gravity;
    dt = 0;
        velocity.x = 0;
        velocity.y = 0;
        transform.position = new Vector3(0, startHeight, 0);
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            launch();
        }
        velocity = velocity + gravityAcceleration * dt;
        transform.position = transform.position + velocity * dt;
    }


    private void FixedUpdate()
    {
       
        

    }

    public void launch()
    {
        dt = 0;
        transform.position = new Vector3(0, startHeight, 0);
        dt = Time.fixedDeltaTime;
        velocity = new Vector3(Mathf.Cos(angleDegrees) * speed, Mathf.Sin(angleDegrees) * speed);
        velocity.x = Mathf.Rad2Deg;
        velocity.y = Mathf.Rad2Deg;

    }
}
