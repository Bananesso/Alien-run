using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectSceneButton : MonoBehaviour
{
    public int SceneNumber;

    public void Transition()
    {
        SceneManager.LoadScene(SceneNumber);
    }
}