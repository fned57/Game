using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Meo : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Button;
   
    void Start()
    {
        Button.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("oto"))
        {
            Button.SetActive(true);
            Time.timeScale = 0;
            Cursor.visible = true;
        }
        
    }
    
}
