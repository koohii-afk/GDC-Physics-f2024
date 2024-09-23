using UnityEngine;

public class FunkyMotion : MonoBehaviour
{
    public float x;
    public float y;
    public float z;
    public float amplitude;
    public float frequency;
    public float time;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        amplitude = 2;
        frequency = 2;

        float dt = Time.fixedDeltaTime;
        
        x = x+ (-Mathf.Sin(time * frequency) * frequency * amplitude *dt) ;
      y = y+(-Mathf.Cos(time * frequency) * frequency * amplitude *dt);

        transform.position= new Vector3(x,y,z);

        time += dt;
    }
}
