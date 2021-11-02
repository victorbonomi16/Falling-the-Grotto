using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gasoline : MonoBehaviour
{
    public Image gasol;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxisRaw("Horizontal")>0)
        {
           gasol.fillAmount -= 0.0003000f; 
        }

        if (gasol.fillAmount <= 0f)
        {
            SceneManager.LoadScene("Menu");
        }
       
    }

    public void AddFuel()
    {
        gasol.fillAmount += 0.9f;
    }
}

