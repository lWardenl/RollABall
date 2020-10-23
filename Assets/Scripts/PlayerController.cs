using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public float ForceMultiplier;
    public float Jump;
    

    private float _moveHorizontal;
    private float _moveVertical;

    private Rigidbody _rigidbody;

    private bool _isJumping = false;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = gameObject.GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !_isJumping)
        {
            _isJumping = true;
            _rigidbody.AddForce(0f, Jump, 0f, ForceMode.Impulse);
        }
    }
 
  
    private void FixedUpdate()
    {
        _moveHorizontal = Input.GetAxis("Horizontal") * ForceMultiplier;
        _moveVertical = Input.GetAxis("Vertical") * ForceMultiplier;
        _rigidbody.AddForce(_moveHorizontal, 0, _moveVertical, ForceMode.Acceleration);
    }

    private void OnCollisionEnter(Collision collision)
    {
        _isJumping = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Coin"))
        {
            GameObject.Destroy(other.gameObject);
        
        }
    }
}
