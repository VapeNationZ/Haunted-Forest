using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class collision_script : MonoBehaviour {
    

    public Text CollisionText; 

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Ball")
        {
            CollisionText.text = "You Died!";
            GameObject.Find("Player").SendMessage("Finnish");
            
        }
    }
}
