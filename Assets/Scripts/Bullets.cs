using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{

    public float speed;
    public GameObject effect;
    


    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
        if (gameObject.transform.position.y > 5.5 || gameObject.transform.position.y < -5.5 || gameObject.transform.position.x<-12.68||gameObject.transform.position.x>12.77)
        {
            Destroy(gameObject);

        }
        speed += .05f;
        Debug.Log("Speed is:" + speed);
    }
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("Player"))
            {

            Instantiate(effect, transform.position, Quaternion.identity);
            collision.GetComponent<Bird>().health -= 0.1f;
                
                Destroy(gameObject);

            }

        }

    }



