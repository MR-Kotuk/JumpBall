using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInLEvels : MonoBehaviour
{
    public void BackInMenuToLevel()
    {
        SceneManager.LoadScene(0);
    }
}
