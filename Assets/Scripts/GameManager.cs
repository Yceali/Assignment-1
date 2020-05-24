using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private float gameScore;
    [SerializeField]
    private Text scoreText;
    [SerializeField]
    private Text multiplierText;
    [SerializeField]
    private int currentTarget;

    private int currentScene;

    public float MyGameScore { get => gameScore; set => gameScore = value; }
    public Text MultiplierText { get => multiplierText; set => multiplierText = value; }
    public int CurrentTarget { get => currentTarget; set => currentTarget = value; }
    public int CurrentScene { get => currentScene; set => currentScene = value; }

    // Start is called before the first frame update

    public void Awake()
    {
        DontDestroyOnLoad(this);

        if (FindObjectsOfType(GetType()).Length > 1)
        {
            Destroy(gameObject);
        }
    }
    
    void Start()
    {
        currentTarget = 0;
        CurrentScene = 0;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score :" + (int)gameScore; 
    }

    public void NextScene()
    {
        SceneManager.LoadScene(CurrentScene + 1);
        currentScene++;
        currentTarget = 0;
    }
    public void Exit()
    {
        Application.Quit();
    }
}
