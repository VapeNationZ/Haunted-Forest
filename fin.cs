using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class fin : MonoBehaviour
{


    public Text CollisionText;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Ball")
        {
            GameObject.Find("Player").SendMessage("Finnish");


        }
    }
}
