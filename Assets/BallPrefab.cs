using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class BallPrefab : MonoBehaviour
{
    private Rigidbody rb;
    private ScoreManager scoreManager; 
  
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false; 
        scoreManager = FindObjectOfType<ScoreManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        rb.useGravity = true;

        if (other.CompareTag("target5"))
        {
            scoreManager.AddScore(5);
            Debug.Log("Hit! 5 points");
        }
        else if (other.CompareTag("target4"))
        {
            scoreManager.AddScore(4);
            Debug.Log("Hit! 4 points");
        }
        else if (other.CompareTag("target3"))
        {
            scoreManager.AddScore(3);
            Debug.Log("Hit! 3 points");
        }
        else if (other.CompareTag("target2"))
        {
            scoreManager.AddScore(2);
            Debug.Log("Hit! 2 points");
        }
        else if (other.CompareTag("target1"))
        {
            scoreManager.AddScore(1);
            Debug.Log("Hit! 1 points");
        }
    }
}
