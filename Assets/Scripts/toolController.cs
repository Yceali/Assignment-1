using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toolController : MonoBehaviour
{

    private Animator toolAnimator;

    [SerializeField]
    private Transform spiralSpawn;
    public spiralController spiral;
    public finishSpiral finishSpiral;

    private Rigidbody toolRigidbody;
    
    private bool canCreate;
    private bool canCreateFinish;
    private bool onPlatform;
    private bool onFinish;
    private float speed;
    private bool canDie;


    // Start is called before the first frame update
    void Start()
    {
        toolAnimator = GetComponent<Animator>();
        toolRigidbody = GetComponent<Rigidbody>();
        speed = 5;
    }

    // Update is called once per frame
    void Update()
    {

        MoveForward();

        if (Input.GetKey(KeyCode.Mouse0))
        {
            if (onPlatform || onFinish)
            {
                toolAnimator.SetBool("isActive", true);              
            }
            else
            {
                toolAnimator.SetBool("isActive", false);
            }

            canDie = true;

        }
        else
        {
            toolAnimator.SetBool("isActive", false);
            canDie = false;
        }


        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            canCreate = true;
        }

        if (onPlatform && canCreate)
        {
            createSpiral();
        }

        if (onFinish && canCreate && canCreateFinish)
        {
            creatFinish();
            canCreateFinish = false;
        }

        if (Input.GetKeyUp(KeyCode.Mouse0) && onFinish)
        {
            speed = 0;          
        }
    }


    private void createSpiral()
    {        
        spiralController clone = Instantiate(spiral, new Vector3 (spiralSpawn.position.x,0.5f), spiralSpawn.rotation);
        canCreate = false;     
    }

    private void creatFinish()
    {
        finishSpiral clone = Instantiate(finishSpiral, new Vector3(spiralSpawn.position.x, 0.5f), spiralSpawn.rotation);
        canCreate = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Platform1")
        {
            onPlatform = true;
        }

        if (other.gameObject.tag == "Platform2")
        {
            onFinish = true;
            canCreateFinish = true;
        }

        if (other.gameObject.tag == "Obstacle" && canDie)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Platform1")
        {
            onPlatform = false;
        }

        if (other.gameObject.tag == "Platform2")
        {
            onFinish = false;
            speed = 0;
        }
    }

    private void MoveForward()
    {
        toolRigidbody.velocity = new Vector3(speed, 0, 0);
    }


}
