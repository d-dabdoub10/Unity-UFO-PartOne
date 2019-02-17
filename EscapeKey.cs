using UnityEngine;
using System.Collections;

public class EscapeKey : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }
}
