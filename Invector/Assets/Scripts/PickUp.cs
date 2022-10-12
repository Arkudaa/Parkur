using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUp : MonoBehaviour
{
    public AudioSource coinmusic;
    public int score;
    public Text cointext;
    // Start is called before the first frame update
    void Start()
    {
        //cointext.text = "Score: " + score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "coin")
        {
            Destroy(collision.gameObject);
            score++;
           coinmusic.Play();
           cointext.text = "Score: " + score;
        }

        if (collision.gameObject.tag == "danger")
        {
            Application.LoadLevel(Application.loadedLevel);
        }
        
    }
}
