using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class breakablesScript : MonoBehaviour
{

    [SerializeField]
    private float objectScore;
    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag =="Player" )
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        else if (other.gameObject.tag == "Spiral" || other.gameObject.tag == "Breakable")
        {
            gameManager.MyGameScore += objectScore;
            Destroy(this.GetComponent<Collider>());

        }
    }
}
