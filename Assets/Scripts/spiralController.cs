using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class spiralController : MonoBehaviour
{

    [SerializeField] private float m_TimeOut = 1.0f;
    public float thrust;
    public Rigidbody rb;
    public bool canThrow;
    public Transform spawnPoint;
    public GameManager gameManager;
    public float multiplier;
    public Slider slider;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        spawnPoint= GameObject.Find("spawnPoint").transform;
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        slider = GameObject.Find("Slider").GetComponent<Slider>();
        
    }

    private void Start()
    {
        multiplier = 1;
    }
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Mouse0) && canThrow)
        {
            spiralOut();
        }

        if (canThrow)
        {
            transform.localScale = Vector3.Lerp(transform.localScale, new Vector3(5, 5, 5), Time.deltaTime*0.1f);
            multiplier += Time.deltaTime;
            gameManager.MyGameScore += 10 * Time.deltaTime * (int)multiplier;
            transform.position = new Vector3(spawnPoint.position.x, transform.position.y);
        }

        gameManager.MultiplierText.text = (int)multiplier + "X";
        slider.value = multiplier;
    }

    public void spiralOut()
    {        
        rb.AddForce(thrust, thrust/3, 0, ForceMode.Impulse);
        rb.AddTorque(transform.forward * thrust * Time.deltaTime);
        canThrow = false;
        multiplier = 1;
        Invoke("DestroyNow", m_TimeOut);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag=="Blocker" && canThrow)
        {
            spiralOut();
        }

       
    }
    private void DestroyNow()
    {
        Destroy(gameObject);
    }
}
