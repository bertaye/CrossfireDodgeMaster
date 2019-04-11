using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Bird : MonoBehaviour
{
    public GameObject effectDie, gameOver;
    private Vector2 targetPos;
    public float yIncrement, maxHeight, minHeight, speed, maxWidth,minWidth,xIncrement;
    public float health;
    HealthBar healthBar;
    private float score;
    public Text scoreDisp;
    

    private void Start()
    {
        health = 1f;
        score = 0f;
    }
    // Update is called once per frame
    void Update()
    {
        score += Time.deltaTime;
        if (health <= -0.01f)
        {
            Destroy(gameObject);
            gameOver.SetActive(true);
            Instantiate(effectDie, transform.position, Quaternion.identity);
            scoreDisp.text = score.ToString();
            
        }
        healthBar = gameObject.GetComponentInChildren<HealthBar>();
        healthBar.healthCondition(health);
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
        if(Input.GetKey(KeyCode.UpArrow)&&transform.position.y<maxHeight)
        {
            targetPos = new Vector2(transform.position.x, transform.position.y + yIncrement);
        }else if (Input.GetKey(KeyCode.DownArrow) && transform.position.y > minHeight)
        {
            targetPos = new Vector2(transform.position.x, transform.position.y - yIncrement);
        }
        else if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x > minWidth)
        {
            targetPos = new Vector2(transform.position.x - xIncrement,transform.position.y);
        }
        else if (Input.GetKey(KeyCode.RightArrow) && transform.position.x < maxWidth)
        {
            targetPos = new Vector2(transform.position.x + xIncrement, transform.position.y);
        }
    }
}
