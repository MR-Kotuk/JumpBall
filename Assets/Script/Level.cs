using UnityEngine;

public class Level : MonoBehaviour
{
    public GameObject[] Levels = new GameObject[5];

    private void Awake()
    {
        for(int g = 0; g < 5; g++)
        {
            Levels[g].SetActive(false);
        }

        switch (MenuUI.level)
        {
            case 1:
                Levels[0].SetActive(true);
                break;
            case 2:
                Levels[1].SetActive(true);
                break;
            case 3:
                Levels[2].SetActive(true);
                break;
            case 4:
                Levels[3].SetActive(true);
                break;
            case 5:
                Levels[4].SetActive(true);
                break;
        }
    }
}
