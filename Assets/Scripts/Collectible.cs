using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    private GameManager gameManager;
    [SerializeField]
    private GameObject collectionEffect;
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
        if (other.gameObject.tag == "Player" || other.gameObject.tag == "Spiral")
        {
            collectionEffect.SetActive(true);
            Destroy(this.gameObject);
            gameManager.MyGameScore += 10;
            Debug.Log("Collected");
        }
    }
}
