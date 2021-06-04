using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Di_Chuyen : MonoBehaviour
{
    // Start is called before the first frame update
    public float SpeedDiChuyen = 5.5f;
    public float SpeedXoay = 30f;
    private bool TimDuoc = false;
    public int lever = 1;
    public Animator animator;
    public Animator People;
    public bool Di_Chuyen_s = true;
    public GameObject[] button;

    
    public GameObject Meo;
  
    void Start()
    {
        button[0].SetActive(false);
        button[1].SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("Di",false);
        People.SetBool("Peolpe", false);
        if (Di_Chuyen_s)
        {
            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(Vector3.forward * Time.deltaTime * SpeedDiChuyen);
                People.SetBool("Peolpe", true);

                if (TimDuoc)
                    animator.SetBool("Di", true);



            }
            else if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(Vector3.back * Time.deltaTime * SpeedDiChuyen);
                People.SetBool("Peolpe", true);
                if (TimDuoc)
                    animator.SetBool("Di", true);

            }

            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(Vector3.left * Time.deltaTime * SpeedDiChuyen);
                People.SetBool("Peolpe", true);
                if (TimDuoc)
                    animator.SetBool("Di", true);

            }
            else if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(Vector3.right * Time.deltaTime * SpeedDiChuyen);
                People.SetBool("Peolpe", true);
                if (TimDuoc)
                    animator.SetBool("Di", true);

            }

            if (Input.GetKey(KeyCode.Q))
            {
                transform.Rotate(Vector3.down * Time.deltaTime * SpeedXoay);

            }
            else if (Input.GetKey(KeyCode.E))
            {
                transform.Rotate(Vector3.up * Time.deltaTime * SpeedXoay);

            }
            if (TimDuoc)
            {

                float x, y, z;
                x = transform.position.x;
                y = transform.position.y;
                z = transform.position.z;
                //Meo.transform.position = transform.transform.position;
               
                Meo.transform.rotation = transform.transform.rotation;

                Meo.transform.position = new Vector3(x - 1, y, z - 1);
            }
        }
        
        

        




    }
    //private void OnTriggerEnter(Collider other)
    //{
    //    if(other.tag == "Meo")
    //    {
    //        TimDuoc = true;
            
    //    }
    //}
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "oto")
        {
            Time.timeScale = 0;
            button[0].SetActive(true);
            TimDuoc = false;
        }
        if (collision.gameObject.tag == "Meo")
        {
            TimDuoc = true;

        }
    }
}
