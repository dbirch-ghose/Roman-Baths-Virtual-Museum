using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed = 3f;

    private CharacterController cc;
    private Vector3 velocity;
    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    void Update()
    {
        Vector3 move = transform.right * Input.GetAxis("Horizontal") + transform.forward * Input.GetAxis("Vertical");
        cc.Move(move * speed * Time.deltaTime);
        cc.Move(velocity * Time.deltaTime);
    }
}
