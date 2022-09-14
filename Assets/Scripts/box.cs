using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box : MonoBehaviour
{
    int type;
    float size;
    int score;
    float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        float x = Random.Range(-2.2f, 2.2f);
        float y = Random.Range(3.5f, 4.5f);

        transform.position = new Vector3(x, y, 0.0f);
        float size = Random.Range(0.5f, 1.5f);
        transform.localScale = new Vector3(size, size, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -6.0f)
        {
            Destroy(gameObject);
        }
    }
    
    // void BounceOff() {
    //     transform.speed = new Vector3(0.0f, speed, 0.0f);
    // }

    void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == "ball_protector") {
            // 
        }
        if (other.gameObject.tag == "ball") {
            // end game
            gameManager.I.gameOver();
        }
        // if (other.gameObject.tag == "ground") {
        //     Destroy(gameObject);
        // }
    }
}
