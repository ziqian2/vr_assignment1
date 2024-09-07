using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ButtonClick : MonoBehaviour
{
    public BallPrefab ballPrefab; 
    private BallPrefab currentBall; 

    void Update()
    {
        if (Touchscreen.current != null)
        {

            if (Touchscreen.current.press.wasPressedThisFrame)
            {

                if (currentBall == null)
                {
                    currentBall = Instantiate<BallPrefab>(ballPrefab);
                    currentBall.transform.position = transform.position;

                    Rigidbody ballRb = currentBall.GetComponent<Rigidbody>();
                    ballRb.useGravity = false;

                    Vector3 randomOffset = new Vector3(
                        UnityEngine.Random.Range(-0.1f, 0.1f), 
                        UnityEngine.Random.Range(-0.1f, 0.1f),
                        0); 
             
                    Vector3 throwDirection = (Camera.main.transform.forward + randomOffset).normalized;
                    ballRb.AddForce(throwDirection * UnityEngine.Random.Range(500, 750));
                }
            }
        }
    }

    private void FixedUpdate()
    {
      
        if (currentBall != null && currentBall.transform.position.y < -10f)
        {
            Destroy(currentBall.gameObject);
            currentBall = null; 
        }
    }
}
