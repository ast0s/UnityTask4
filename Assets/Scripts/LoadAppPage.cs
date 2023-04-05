using UnityEngine.SceneManagement;
using UnityEngine;

public class LoadAppPage : MonoBehaviour
{
    public void LoadOpera() 
    {
        SceneManager.LoadScene("Opera App Menu");
    }
    public void LoadFirefox()
    {
        SceneManager.LoadScene("Firefox App Menu");
    }
    public void LoadChrome()
    {
        SceneManager.LoadScene("Chrome App Menu");
    }
}
