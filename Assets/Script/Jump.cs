using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jump : MonoBehaviour
{
    public Transform target;
    public Transform[] Transforms = new Transform[0];
    public GameObject[] gameObjects = new GameObject[11];
    public GameObject[] Text = new GameObject[1];

    public float jump = 10f, rotateSpeed = 10f;

    public static bool isOpen = true;
    public static bool StartPlay = false;
    public static bool ExitInTheMenu;

    private Rigidbody rb;
    public static bool isJump;
    public static bool isJump2;
    void Awake()
    {
        jump *= 1000;
        isOpen = true;
        isJump = false;
        isJump2 = false;
        ExitInTheMenu = true;
        StartPlay = true;
        Cursor.visible = false;

        rb = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        if(isJump == true)
        {
            isJump = false;
            isJump2 = true;
            StartCoroutine(Jump3dObjAktive(1.1f));
            rb.AddForce(new Vector3(0, 1, 0) * jump * Time.deltaTime);
        }
        Transforms[0].Rotate(new Vector3(0, 1, 0) * rotateSpeed * Time.deltaTime);
    }
    void Update()
    {
        if (StartPlay == true)
        {
            if (Input.GetKeyDown(KeyCode.Escape) && ExitInTheMenu == true || Input.GetKey(KeyCode.M) && ExitInTheMenu == true)
            {
                SceneManager.LoadScene(0);
            }
            if (Input.GetKeyDown(KeyCode.Space) && isJump2 == false)
            {
                isJump = true;
            }
        }
    }

    private IEnumerator Jump3dObjAktive(float wait)
    {
        yield return new WaitForSeconds(0.2f);
        for (int i = 0; i < 11; i++)
        {
            gameObjects[i].SetActive(false);
        }
        yield return new WaitForSeconds(wait);
        isJump2 = false;
        yield return new WaitForSeconds(0.4f);
        for (int x = 0; x < 11; x++)
        {
            gameObjects[x].SetActive(true);
        }
        
    }
}
