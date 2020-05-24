using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finishPoint : MonoBehaviour
{
    [SerializeField]
    private float point;
    [SerializeField]
    private GameObject particle;
    private bool canScale;
    private float timer;

    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        timer = 3;
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canScale)
        {
            gameObject.transform.localScale = Vector3.Lerp(transform.localScale, new Vector3(4, 1, 5), 0.05f);
            timer -= Time.deltaTime;
        }

        if (timer < 0)
        {
            gameManager.NextScene();
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "FinishSpiral")
        {
            particle.SetActive(true);
            gameManager.MyGameScore += point;
            canScale = true;
            Destroy(collision.gameObject.GetComponent<Collider>());
        }
    }
}
