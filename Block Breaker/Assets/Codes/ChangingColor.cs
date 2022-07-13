using UnityEngine;

public class ChangingColor : MonoBehaviour
{
    void OnCollisionEnter(Collision coll)
    {
        if(coll.collider.tag == "Ball")
        {
            GetComponent<Renderer>().material.color = new Color(255, 255, 0);
        }
    }
}
