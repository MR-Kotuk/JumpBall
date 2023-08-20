using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUI : MonoBehaviour
{
    public GameObject CameraInMenu;
    public GameObject[] Menu = new GameObject[4];
    public static float level = 0;

    private void Awake()
    {
        Cursor.visible = true;
        Menu[0].SetActive(true);
    }
    public void Play()
    {
        Menu[1].SetActive(true);
        Menu[0].SetActive(false);
    }
    public void AuthorsBUtton()
    {
        Menu[2].SetActive(true);
        Menu[0].SetActive(false);
    }
    public void DeleteSaveGame()
    {
        PlayerPrefs.DeleteAll();
    }
    public void ExidButton()
    {
        Menu[3].SetActive(true);
    }

    public void ExidButtonYes()
    {
        Application.Quit();
    }
    public void BackInMenu()
    {
        Menu[0].SetActive(true);
        Menu[1].SetActive(false);
        Menu[2].SetActive(false);
        Menu[3].SetActive(false);
    }
    public void ExitInTheMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void LevelOne()
    {
        level = 1;
        Jump.StartPlay = true;
        SceneManager.LoadScene(1);
    }
    public void LevelTwo()
    {
        level = 2;
        Jump.StartPlay = true;
        SceneManager.LoadScene(1);
    }
    public void LevelThre()
    {
        level = 3;
        Jump.StartPlay = true;
        SceneManager.LoadScene(1);
    }
    public void LevelFour()
    {
        level = 4;
        Jump.StartPlay = true;
        SceneManager.LoadScene(1);
    }
    public void LevelFafe()
    {
        level = 5;
        Jump.StartPlay = true;
        SceneManager.LoadScene(1);
    }
}
