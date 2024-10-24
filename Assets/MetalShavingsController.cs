using UnityEngine;

public class MetalShavingsController : MonoBehaviour
{
    private GameObject magnet;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        magnet = GameObject.FindWithTag("Magnet");
    }

    void FixedUpdate()
    {
        MagnetController magnetController = magnet.GetComponent<MagnetController>();

        if (magnetController.isActivated)
        {
            Vector3 direction = (magnet.transform.position - transform.position).normalized;

            rb.AddForce(direction * magnetController.magneticForce);
        }
    }
}
