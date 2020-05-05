using UnityEngine;

public class Finish : MonoBehaviour
{
    public GameManager gameManager;
    void OnTriggerEnter()
    {
        gameManager.LevelComplete();
    }
}
