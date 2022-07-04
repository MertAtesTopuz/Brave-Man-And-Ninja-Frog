using UnityEngine;
using UnityEngine.SceneManagement;
public class BolumControl : MonoBehaviour
{
    [System.Obsolete]
    public void bolumac(string bolumismi)
    {
        Application.LoadLevel(bolumismi);
        Time.timeScale = 1.0f;
    }

    public void geri_btn()
    {
        SceneManager.LoadScene(0);
    }
}
