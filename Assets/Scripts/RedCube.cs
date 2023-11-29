using UnityEngine;

public class RedCube : MonoBehaviour
{
    [SerializeField] GameObject gameManager;



    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Apple")
        {
            gameManager.GetComponent<GameManager>().increaseApple();
            Debug.Log("Apple found");
            GameObject.Destroy(other.transform.gameObject);
        }
    }
}
