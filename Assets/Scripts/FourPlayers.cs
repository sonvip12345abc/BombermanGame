using UnityEngine;
using UnityEngine.SceneManagement;

public class FourPlayers : MonoBehaviour
{
    public void Four()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }
}
