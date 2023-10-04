using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float playerSpeed;
    public float rotationSpeed;
    public Rigidbody rb;

    private float horiazontalMove;
    private float verticalMove;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        horiazontalMove = Input.GetAxis("Horizontal");
        verticalMove = Input.GetAxis("Vertical");
        rb.velocity = (transform.forward * verticalMove) * playerSpeed * Time.deltaTime;
        transform.Rotate((transform.up * horiazontalMove) * rotationSpeed * Time.deltaTime);
    }

}
