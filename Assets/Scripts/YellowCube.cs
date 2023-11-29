using UnityEngine;

public class YellowCube : MonoBehaviour
{
    [SerializeField] GameObject gameManager;


    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Banana")
        {
            gameManager.GetComponent<GameManager>().increaseBanana();
            GameObject.Destroy(other.gameObject);
        }
    }



}