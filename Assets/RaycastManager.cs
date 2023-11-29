using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RaycastManager : MonoBehaviour
{    
    public GameObject targetObject;
    public TextMeshPro score;
    private int scoreVal = 0;

    private void Update()
    {
        // Cast a ray from the current GameObject's position in the forward direction
        Ray ray = new Ray(transform.position, transform.forward);

        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            // Check if the ray hits the targetObject
            if (hit.collider.gameObject == targetObject)
            {
                scoreVal++;
                score.text = scoreVal.ToString();
            }
            else
            {
                scoreVal--;
            }
        }

        // Draw a debug line to visualize the ray in the Scene view
        Debug.DrawRay(ray.origin, ray.direction * 10f, Color.red);
    }
}

