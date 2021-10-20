using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float verticalInput = Input.GetAxis("Vertical");

        transform.position = transform.position + new Vector3(0 , verticalInput * speed * Time.deltaTime, 0);
        Vector3 pos = transform.position + new Vector3(0, verticalInput * speed * Time.deltaTime, 0);
        pos.y = Mathf.Clamp(transform.position.y, -4, 4);
        transform.position = pos;



    }
}
