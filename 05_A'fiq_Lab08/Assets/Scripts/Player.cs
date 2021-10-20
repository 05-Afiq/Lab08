using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float speed;
    public int score;
    public Text ScoreText;
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
    private void OnTriggerEnter(Collider other)
    {
        

            if (other.gameObject.tag == "Obstacle")
            {
                SceneManager.LoadScene("GameOver");

            }
        if (other.gameObject.tag == "Trigger")
        {
            score++;
            ScoreText.text = "Score : " + score;
        }

    }

}
