using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finishSpiral : MonoBehaviour
{
    public float thrust;
    public Rigidbody rb;
    public bool canThrow;
    public Transform spawnPoint;
    public GameManager gameManager;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        spawnPoint = GameObject.Find("spawnPoint").transform;
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }


    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Mouse0) && canThrow)
        {
            spiralOut();
        }

        if (canThrow)
        {
            transform.localScale = Vector3.Lerp(transform.localScale, new Vector3(5, 0.5f, 5), Time.deltaTime * 0.05f);
            gameManager.MyGameScore += 10 * Time.deltaTime;
            transform.position = new Vector3(spawnPoint.position.x, transform.position.y);
        }

    }

    public void spiralOut()
    {
        rb.AddForce(thrust, thrust / 3, 0, ForceMode.Impulse);
        rb.AddTorque(transform.forward * thrust * Time.deltaTime);
        canThrow = false;
        gameManager.CurrentTarget = 1;
    }
}
