
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelEnd : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
        if (SceneManager.GetActiveScene().buildIndex == 3)
        {
            SceneController.instance.MenuReturn();
        }
        else
        {
            SceneController.instance.NextLevel();
        }
        }
    }
}
