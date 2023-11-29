using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int apple;
    private int banana;
    public TextMeshPro appleCount;
    public TextMeshPro bananaCount;
    [SerializeField] GameObject congratsScreen;
    [SerializeField] List<GameObject> gameObjects;

    private void Start()
    {
        apple = 0;
        banana = 0;
    }

    public void increaseApple()
    {
        apple++;
        appleCount.text = apple.ToString();
    }

    public void increaseBanana()
    {
        banana++;
        bananaCount.text = banana.ToString();

    }


    private void Update()
    {
        if (apple == 16 && banana == 16)
        {
            congratsScreen.SetActive(true);
            foreach(GameObject i in gameObjects)
            {
                i.SetActive(false);
            }
        }
    }
}
