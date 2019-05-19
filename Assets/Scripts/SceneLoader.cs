using UnityEngine;

public class SceneLoader : MonoBehaviour
{
    public void LoadScene(int scene)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(scene);
    }
}
