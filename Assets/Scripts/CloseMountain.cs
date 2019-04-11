using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseMountain : MonoBehaviour
{
    public float speed;
    public float endX;
    public float startX;
    public float length;
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        if (transform.position.x <= endX - length/2)
        {
            Vector2 pos = new Vector2(startX+length/2, transform.position.y);
            transform.position = pos;

        }

    }
}
