using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class timer : MonoBehaviour
{
    public TMP_Text timeText;
    public GameObject CameraEndGame;
    public GameObject CameraGame;
    public GameObject Audio;
    public GameObject EndAllGame;
    public GameObject EndGame1; 
    public GameObject EndGame2; 
    public GameObject EndGame3; 
    public GameObject EndGame4;
    public GameObject TextTime;
    public GameObject Light;
    public GameObject CubeForLevel1;
    public int Time;
    public static bool OpenLevel;

    private float Star;
    private float Star2;
    private float Star3;
    private bool Timer;
    void Awake()
    {
        Audio.SetActive(true);
        EndAllGame.SetActive(false);
        CameraGame.SetActive(true);
        CameraEndGame.SetActive(false);
    }
    void Start()
    {
        Star = 0f;
        Star2 = 0f;
        Star3 = 0f;
        OpenLevel = false;
        Light.SetActive(true);
        TextTime.SetActive(false);
        EndGame1.SetActive(false);
        EndGame2.SetActive(false);
        EndGame3.SetActive(false);
        EndGame4.SetActive(false);
        CubeForLevel1.SetActive(false);
        Timer = true;
        StartCoroutine(TimerTime());
    }
    IEnumerator TimerTime()
    {
        while (Timer)
        {
            Time++;
            yield return new WaitForSeconds(1);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "EndLevel1")
        {
            Star = 50f;
            Star2 = 45f;
            Star3 = 40;
            EndGame();
            EndGame1.SetActive(true);
            Jump.isOpen = false;
        }
        if (other.gameObject.tag == "EndLevel2")
        {
            Star = 90f;
            Star2 = 70f;
            Star3 = 65f;
            EndGame();
            EndGame2.SetActive(true);
            Jump.isOpen = false;
        }
        if (other.gameObject.tag == "EndLevel3")
        {
            Star = 135;
            Star2 = 105f;
            Star3 = 95f;
            EndGame();
            EndGame3.SetActive(true);
            Jump.isOpen = false;
        }
        if (other.gameObject.tag == "EndLevel4")
        {
            Star = 270f;
            Star2 = 250f;
            Star3 = 240f;
            EndGame();
            EndGame4.SetActive(true);
            Jump.isOpen = false;
        }
        if (other.gameObject.tag == "EndLevel5")
        {
            Jump.ExitInTheMenu = false;
            Audio.SetActive(false);
            EndAllGame.SetActive(true);
            CameraGame.SetActive(false);
            Light.SetActive(false);
            CameraEndGame.SetActive(true);
            StartCoroutine(EndWaitTime());
            Jump.ExitInTheMenu = false;
            Jump.isOpen = false;
        }
        
        void EndGame()
        {
            Light.SetActive(false);
            StartCoroutine(CubeLevel1());
            Cursor.visible = true;
            TextTime.SetActive(true);
            Timer = false;
            if (Time <= Star && Time >= Star2)
            {
                timeText.text = "" + Time + "s" + " \n \nStars: 1";
            }
            if (Time <= Star2 && Time >= Star3)
            {
                timeText.text = "" + Time + "s" + " \n \nStars: 2";
                OpenLevel = true;
            }
            if (Time <= Star3)
            {
                timeText.text = "" + Time + "s" + " \n \nStars: 3";
                OpenLevel = true;
            }
                
            if(Time >= Star)
                timeText.text = "" + Time + "s" + " \n \nStars: 0";
            TextTime.SetActive(true);

        }
        IEnumerator EndWaitTime()
        {
            yield return new WaitForSeconds(42);
            SceneManager.LoadScene(0);
        }
        IEnumerator CubeLevel1()
        {
            CubeForLevel1.SetActive(true);
            yield return new WaitForSeconds(4);
            CubeForLevel1.SetActive(false);
        }
    }
}
