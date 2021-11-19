using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class camPos : MonoBehaviour
{
    public Transform player;
    int score = 0;
    float floatScore = 0f;
    public Text scoreText;

    void Update()
    {
        floatScore = transform.position.y * 50;
        score = (int)floatScore;
        scoreText.text = score.ToString();
    }

    void LateUpdate()
    {
        if(player.position.y > transform.position.y)
        {
            Vector3 newPos = new Vector3(transform.position.x, player.position.y, transform.position.z);
            transform.position = newPos;
        }
    }
}
