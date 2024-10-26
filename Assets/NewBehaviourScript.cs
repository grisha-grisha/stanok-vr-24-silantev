using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{

    public GameObject obj_to_deactivate;

    public void Deactivate()
    {
        obj_to_deactivate.SetActive(false);
    }
}


