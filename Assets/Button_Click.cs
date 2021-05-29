using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_Click : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] p;
    public GameObject[] button;
    public void Menu()
    {

        //button tiep tuc
        button[1].SetActive(false);
        //button tam dung
        button[0].SetActive(false);
        //button play
        button[2].SetActive(true);
        //button huong dan
        button[3].SetActive(true);
        //button nhien vu that bai
        button[4].SetActive(false);
        //button nhien vu thanh cong
        button[5].SetActive(false);
        //camera

        p[0].SetActive(true);
        p[1].transform.position = new Vector3(-308.6f, 69.87f, 17.73f);
        p[1].transform.localRotation = Quaternion.Euler(0, 0, 0);
    }
    public void play()
    {
        Time.timeScale = 1;
        Cursor.visible = false;
        p[0].SetActive(false);

        button[2].SetActive(false);
        //button huong dan
        button[3].SetActive(false);

        button[0].SetActive(true);
        button[1].SetActive(false);
        p[1].transform.position = new Vector3(-200.9936f, 69.87f, 20.22299f);
        p[1].transform.localRotation = Quaternion.Euler(0, -90, 0);
    }
    public void NhiemVuMoi()
    {
        Menu();
    }
    public void Thoat()
    {
        Application.Quit();
    }
    public void TamDung()
    {
        Time.timeScale = 0;
        button[0].SetActive(false);
        button[1].SetActive(true);
    }
    public void TiepTuc()
    {
        Time.timeScale = 1;
        button[0].SetActive(true);
        button[1].SetActive(false);
    }
    public void Update()
    {

        if (Input.GetKey(KeyCode.M))
        {
            Cursor.visible = true;
        }
        else if (Input.GetKey(KeyCode.N))
            Cursor.visible = false;
    }
}
