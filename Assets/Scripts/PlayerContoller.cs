using JetBrains.Annotations;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    public float speed = 20.0f;
    public float turnSpeed = 65.0f;
    public float horizontalInput;

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
       
        transform.Translate(Vector3.forward * Time.deltaTime * speed );
        transform.Rotate(Vector3.up , Time.deltaTime * turnSpeed * horizontalInput * 3);
    }
}
