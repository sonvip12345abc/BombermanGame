using UnityEngine;
using UnityEngine.SceneManagement;

public class TwoPlayers : MonoBehaviour
{
    public void TwoPlayer()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
