using UnityEngine;
using UnityEngine.SceneManagement;

public class ThreePlayers : MonoBehaviour
{
    public void Three()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
}
