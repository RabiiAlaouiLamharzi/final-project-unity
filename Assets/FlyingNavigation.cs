using UnityEngine;

public class FlyingNavigation : MonoBehaviour
{
    public float speed = 5.0f; 
    public float verticalSpeed = 2.0f; 
    private Vector2 touchpadInput;

    void Update()
    {
        
        touchpadInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        
        Vector3 forwardMovement = transform.forward * touchpadInput.y * speed * Time.deltaTime;

        
        Vector3 strafeMovement = transform.right * touchpadInput.x * speed * Time.deltaTime;

       
        Vector3 movement = forwardMovement + strafeMovement;

        
        transform.position += movement;

        
        if (Input.GetButton("Jump"))
        {
            transform.position += Vector3.up * verticalSpeed * Time.deltaTime; 
        }
        else if (Input.GetButton("Crouch"))
        {
            transform.position += Vector3.down * verticalSpeed * Time.deltaTime; 
        }
    }
}
