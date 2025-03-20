using UnityEngine;

public class Rotete : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] Vector3 angularV, torque;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.angularVelocity = angularV;
        }
        else if (Input.GetMouseButtonDown(1))
        {
            rb.AddTorque(torque);
        }
        else if (Input.GetKeyDown(KeyCode.Escape))
        {
            rb.angularVelocity = Vector3.zero;
        }

    
    }
}
