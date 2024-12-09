using UnityEngine;

public class cone : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        //jesli player dotknie obiektu cube1 (1) to cone znika
        if (collision.gameObject.tag == "Player" && collision.gameObject.name == "cube1")
        {
            //gameobject z tagiem "cone" znika
            gameObject.SetActive(false);
        }
    }
}
