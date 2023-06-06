using UnityEngine;

public class YellowCube : MonoBehaviour
{
    [SerializeField] GameObject gameManager;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Banana")
        {
            gameManager.GetComponent<GameManager>().increaseBanana();
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.transform.tag == "Banana")
        {
            gameManager.GetComponent<GameManager>().decreaseBanana();
        }
    }
}