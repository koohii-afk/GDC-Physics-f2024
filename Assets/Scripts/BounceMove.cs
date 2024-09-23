using UnityEngine;

public class BounceMove : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float vel = 0.0f;
    public float pos = 5.0f;
    public float acc = Physics.gravity.y;
    // 60fps
    // 60frames / 1 second
    // 0.02 seconds, then we can convert to framerate by dividing 1 second by frequency
    // rate = 1 / frequency
    void FixedUpdate()
    {
        float dt = Time.fixedDeltaTime; // 0.02s, updating at 50fps!
        float acc = Physics.gravity.y; // -9.81
       

        if (transform.position.y <= 0.0f)
        {
            
            pos = 0.0f;
            vel = (-vel) +  acc * dt;
            pos = pos + vel * dt;
            
            transform.position = new Vector3(0.0f, pos, 0.0f);
        }
        else
        {
            vel = vel + acc * dt;
            pos = pos + vel * dt;
            transform.position = new Vector3(0.0f, pos, 0.0f);
        }
      

    }
}
        // Write code to do the following:
        // When the ball goes below the ground plane, flip its velocity.
        // (if done correctly, the ball will bounce)

    
