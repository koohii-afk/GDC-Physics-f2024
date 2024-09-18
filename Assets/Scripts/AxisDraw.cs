using UnityEngine;

public class AxesDraw : MonoBehaviour
{
    public float length = 1.0f;
    public bool local = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 start= transform.position;
        Vector3 right = local ? transform.right: Vector3.right;
        Vector3 up = local? transform.up: Vector3.up;
        Vector3 forward = local? transform.forward: Vector3.forward;  

        Debug.DrawLine(start, start + right * length, Color.red);
        Debug.DrawLine(start, start + up * length , Color.green);
        Debug.DrawLine(start, start + forward * length , Color.blue);
    }
}
