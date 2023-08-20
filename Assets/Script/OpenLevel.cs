using UnityEngine;

public class OpenLevel : MonoBehaviour
{
    public GameObject Level2Open;
    public GameObject Level3Open;
    public GameObject Level4Open;
    public GameObject Level5Open;
    private int Level2OpenSave;
    private int Level3OpenSave;
    private int Level4OpenSave;
    private int Level5OpenSave;
    private int LevelOpen2;
    private int LevelOpen3;
    private int LevelOpen4;
    private int LevelOpen5;

    void Update()
    {
        OpenLevelSave();
        OpenLevelinMenu();
    }
    void OpenLevelinMenu()
    {
        if (MenuUI.level == 1 && timer.OpenLevel == true)
        {
            Level2OpenSave = 1;
            timer.OpenLevel = false;

            PlayerPrefs.SetInt("SameLevel2", Level2OpenSave);
            PlayerPrefs.Save();
        }
        if (MenuUI.level == 2 && timer.OpenLevel == true)
        {
            Level3OpenSave = 1;
            timer.OpenLevel = false;

            PlayerPrefs.SetInt("SameLevel3", Level3OpenSave);
            PlayerPrefs.Save();
        }
        if (MenuUI.level == 3 && timer.OpenLevel == true)
        {
            Level4OpenSave = 1;
            timer.OpenLevel = false;

            PlayerPrefs.SetInt("SameLevel4", Level4OpenSave);
            PlayerPrefs.Save();
        }
        if (MenuUI.level == 4 && timer.OpenLevel == true)
        {
            Level5OpenSave = 1;
            timer.OpenLevel = false;

            PlayerPrefs.SetInt("SameLevel5", Level5OpenSave);
            PlayerPrefs.Save();
        }
    }

    void OpenLevelSave()
    {
        LevelOpen2 = PlayerPrefs.GetInt("SameLevel2");
        LevelOpen3 = PlayerPrefs.GetInt("SameLevel3");
        LevelOpen4 = PlayerPrefs.GetInt("SameLevel4");
        LevelOpen5 = PlayerPrefs.GetInt("SameLevel5");

        if(LevelOpen2 == 1)
            Level2Open.SetActive(true);

        if (LevelOpen3 == 1)
            Level3Open.SetActive(true);

        if (LevelOpen4 == 1)
            Level4Open.SetActive(true);

        if (LevelOpen5 == 1)
            Level5Open.SetActive(true);
    }
}
