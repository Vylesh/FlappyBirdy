using System;
using UnityEngine;

public class ScoreIncrease : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) Score.instance.UpdateScore();
    }
}