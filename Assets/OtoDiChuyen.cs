using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtoDiChuyen : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 5f;
    int Di = 1;
    public GameObject[] BanhXe;
  


    void Start()
    {
       
        //transform.position = new Vector3(-315.14f, 69.77f, 54.77f);

    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < 4; i++)
        {
            BanhXe[i].transform.Rotate(Vector3.right *  5f);
        }
        


        if (Di == 1)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);

        }
        else if (Di == 2)
        {

            transform.Rotate(new Vector3(0, -90, 0));
            Di = 1;
        }
        else if (Di == 3)
        {
            transform.Rotate(new Vector3(0, 90, 0));
            Di = 1;

        }





        //Duong 1.1
        if (transform.position.x >= -207f && transform.position.x <= -204f)
        {
            //1.1.1
            if (transform.position.z <= 6f && transform.position.z >= 5f)
            {
                int a = Random.Range(0, 3);
                if (a == 1)
                {
                    Di = 1;
                }
                else if (a == 2)
                {
                    transform.Translate(new Vector3(0, 0, 7f));
                    Di = 2;
                }
            }
            //1.1.2
            else if (transform.position.z <= 61f && transform.position.z >= 60f)
            {
                transform.Translate(new Vector3(0, 0, 2f));
                Di = 2;
            }
        }
        else if (transform.position.x >= -212f && transform.position.x <= -207f)
        {
            if (transform.position.z <= -30f)
            {
                transform.position = new Vector3(-206f, 69.76829f, -27f);
                transform.localRotation = Quaternion.Euler(0, 0, 0);
            }
        }
        //duong so 2.1
        if (transform.position.x >= -257.46f && transform.position.x <= -256.99f)
        {
            if (transform.position.z <= 63.41f && transform.position.z >= 60.65f)
            {
                transform.position = new Vector3(-257.1509f, 69.76829f, 54.77f);
            }
        }



        //duog 2.2
        if (transform.position.z >= 10f && transform.position.z <= 15f)
        {
            //2.2.1
            if (transform.position.x >= -320f && transform.position.x <= -319f)
            {
                int a = Random.Range(0, 4);

                switch (a)
                {
                    case 1:
                        transform.Translate(new Vector3(0f, 0, 1f));

                        Di = 1;
                        break;
                    case 2:
                        transform.Translate(new Vector3(0f, 0f, 5f));
                        Di = 2;
                        break;
                    case 3:
                        transform.Translate(new Vector3(0f, 0, 2f));
                        Di = 3;
                        break;
                    default:
                        transform.Translate(new Vector3(0f, 0, 5f));
                        Di = 2;
                        break;
                }
            }
            //2.2.2
            else if (transform.position.x >= -398f && transform.position.x <= -397f)
            {
                int a = Random.Range(0, 3);
                if (a == 1)
                {
                    Di = 1;
                }
                else if (a == 2)
                {
                    transform.Translate(new Vector3(0, 0, 1f));
                    Di = 3;
                }
            }
            //2.2.3
            else if (transform.position.x <= -433f)
            {
                transform.position = new Vector3(-430.4f, 69.76829f, 7.5f);
                transform.localRotation = Quaternion.Euler(0, 90, 0);
            }


            //2.2.-1
        }
        else if (transform.position.z <= 10f && transform.position.z >= 5f)
        {
            if (transform.position.x >= -406.6f && transform.position.x <= -405f)
            {
                int a = Random.Range(0, 3);

                switch (a)
                {
                    case 1:
                        transform.Translate(new Vector3(0, 0, 1f));
                        Di = 1;
                        break;
                    case 2:
                        transform.Translate(new Vector3(0, 0, 7f));
                        Di = 2;
                        break;

                }
            }
            //2.2.-2
            else if (transform.position.x >= -326f && transform.position.x <= -325f)
            {
                int a = Random.Range(0, 4);


                switch (a)
                {
                    case 1:
                        transform.Translate(new Vector3(0f, 0, 1f));

                        Di = 1;
                        break;
                    case 2:
                        transform.Translate(new Vector3(0f, 0f, 4f));
                        Di = 2;
                        break;
                    case 3:
                        transform.Translate(new Vector3(0f, 0, 1f));
                        Di = 3;
                        break;
                    default:
                        transform.Translate(new Vector3(0f, 0, 5f));
                        Di = 2;
                        break;
                }
                //2.2.-3
            }
            else if (transform.position.x >= -213f && transform.position.x <= -212f)
            {


                int a = Random.Range(0, 3);

                if (a == 1)
                {
                    transform.Translate(new Vector3(0, 0, 2f));
                    Di = 3;
                }
                else if (a == 2)
                {
                    transform.Translate(new Vector3(0, 0, 7f));
                    Di = 2;
                }
            }
        }
        //1.2
        if (transform.position.x <= -320f && transform.position.x >= -323f)
        {
            //1.2.1

            if (transform.position.z >= 5f && transform.position.z <= 6f)
            {
                int a = Random.Range(0, 4);
                switch (a)
                {
                    case 1:
                        transform.Translate(new Vector3(0f, 0, 1f));

                        Di = 1;
                        break;
                    case 2:
                        transform.Translate(new Vector3(0f, 0f, 6f));
                        Di = 2;
                        break;
                    case 3:
                        transform.Translate(new Vector3(0f, 0, 1f));
                        Di = 3;
                        break;
                    default:
                        transform.Translate(new Vector3(0f, 0, 6f));
                        Di = 2;
                        break;
                }
                //1.2.2
            }
            else if (transform.position.z <= 46f && transform.position.z >= 45f)
            {
                transform.Translate(new Vector3(0f, 0, 8f));
                Di = 2;
            }
            //1.2.-2
        }
        else if (transform.position.x <= -324f && transform.position.x >= -327f)
        {
            if (transform.position.z >= 13f && transform.position.z <= 14f)
            {
                int a = Random.Range(0, 4);
                switch (a)
                {
                    case 1:
                        transform.Translate(new Vector3(0f, 0, 1f));

                        Di = 1;
                        break;
                    case 2:
                        transform.Translate(new Vector3(0f, 0f, 7.2f));
                        Di = 2;
                        break;
                    case 3:
                        transform.Translate(new Vector3(0f, 0, 1f));
                        Di = 3;
                        break;
                    default:
                        transform.Translate(new Vector3(0f, 0, 7.2f));
                        Di = 2;
                        break;
                }
            }
            else if (transform.position.z <= -72f)
            {
                transform.position = new Vector3(-321.6f, 69.76829f, -71f);
                transform.localRotation = Quaternion.Euler(0, 0, 0);
            }
        }
        //1.3
        if (transform.position.x <= -396f && transform.position.x >= -402f)
        {
            if (transform.position.z <= 46f && transform.position.z >= 45f)
            {
                int a = Random.Range(0, 3);

                if (a == 1)
                {
                    transform.Translate(new Vector3(0f, 0, 9f));
                    Di = 2;
                }
                else
                {
                    transform.Translate(new Vector3(0f, 0, 4f));
                    Di = 3;
                }

            }
        }
        else if (transform.position.x >= -407f && transform.position.x <= -401f)
        {
            if (transform.position.z <= 16f && transform.position.z >= 15f)
            {
                int a = Random.Range(0, 3);

                if (a == 1)
                {
                    transform.Translate(new Vector3(0f, 0, 9f));
                    Di = 2;
                }
                else
                {
                    transform.Translate(new Vector3(0f, 0, 4f));
                    Di = 3;
                }
            }
        }
        //2.1
        if (transform.position.z >= 48f && transform.position.z <= 51f)
        {

            if (transform.position.x >= -409f && transform.position.x <= -408f)
            {
                int a = Random.Range(0, 3);

                if (a == 1)
                {
                    Di = 1;
                }
                else
                {
                    transform.Translate(new Vector3(0f, 0, 4f));
                    Di = 3;
                }
            }
            else if (transform.position.x >= -329f && transform.position.x <= -328f)
            {
                int a = Random.Range(0, 3);

                if (a == 1)
                {

                }
                else
                {
                    transform.Translate(new Vector3(0f, 0, 4f));
                    Di = 3;
                }
            }
        }
        else if (transform.position.z >= 52f && transform.position.z <= 56f)
        {
            if (transform.position.x >= -318f && transform.position.x <= -317f)
            {
                int a = Random.Range(0, 3);
                if (a == 1)
                {
                    Di = 1;
                }
                else
                {
                    transform.Translate(new Vector3(0f, 0, 8f));
                    Di = 2;
                }
            }
            else if (transform.position.x >= -396f && transform.position.x <= -395f)
            {
                int a = Random.Range(0, 3);

                if (a == 1)
                {
                    Di = 1;
                }
                else
                {
                    transform.Translate(new Vector3(0f, 0, 8f));
                    Di = 2;
                }
            }
            else if (transform.position.x <= -490f)
            {
                transform.position = new Vector3(-489.687f, 69.76829f, 49.4f);
                transform.localRotation = Quaternion.Euler(0, 90, 0);
            }
        }

        if (transform.position.x < -500f)
        {
            transform.position = new Vector3(-489.687f, 69.76829f, 49.4f);
            transform.localRotation = Quaternion.Euler(0, 90, 0);
        }
        else if (transform.position.x > 67f)
        {
            transform.position = new Vector3(-489.687f, 69.76829f, 49.4f);
            transform.localRotation = Quaternion.Euler(0, 90, 0);
        }
        else if (transform.position.z > 131f)
        {
            transform.position = new Vector3(-489.687f, 69.76829f, 49.4f);
            transform.localRotation = Quaternion.Euler(0, 90, 0);
        }
        else if (transform.position.z < -66f)
        {
            transform.position = new Vector3(-489.687f, 69.76829f, 49.4f);
            transform.localRotation = Quaternion.Euler(0, 90, 0);
        }
    }


   
}
