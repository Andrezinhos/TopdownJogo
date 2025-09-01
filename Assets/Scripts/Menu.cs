using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void Iniciar()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Creditos()
    {

    }

    public void Sair()
    {
        Application.Quit();
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif

    }
}
