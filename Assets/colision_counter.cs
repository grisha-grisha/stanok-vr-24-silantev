using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class colision_counter : MonoBehaviour
{
    public int x = 0;
    public Text myText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //myText.text = x.ToString();
    }

    public void OnCollisionEnter(Collision other)
    {
        Debug.Log("столкновение");
        x++;
        myText.text = x.ToString();
       
    }

}
