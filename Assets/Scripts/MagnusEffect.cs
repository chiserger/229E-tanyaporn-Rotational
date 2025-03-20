using UnityEngine;

public class MagnusEffect : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] Vector3 velocity, spin;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Kick();
            
        }
        ApplyMagnusEffect();
    }
    void Kick()
    {
        rb.linearVelocity = velocity; //�еç仢�ҧ˹��
        rb.angularVelocity = spin; //�ç��ع
    }

    void ApplyMagnusEffect()
    {
       Vector3 mangnusForce = Vector3.Cross(rb.linearVelocity, rb.angularVelocity);
        rb.AddForce(mangnusForce, ForceMode.Force);
    }
}
