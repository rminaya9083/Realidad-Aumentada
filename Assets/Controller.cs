using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{


    private Animation anim;
    private Rigidbody rigid;

    public float speed = 5.0f;


    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        anim = GetComponent<Animation>();
    }

    
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Vector3 mov = new Vector3(x, 0, y);
        rigid.velocity = mov * 4f;

        if (x != 0 && y != 0)
        {
            anim.Play("Running");
        }

        if (x != 0 && y != 0)
        {
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, Mathf.Atan2(x, y) * Mathf.Rad2Deg, transform.eulerAngles.z);
        }
    }
}
