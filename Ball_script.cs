using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class Ball_script : MonoBehaviour {


    public Text CollisionText;



	void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            CollisionText.text = "You Died!";

        }
    }
}

