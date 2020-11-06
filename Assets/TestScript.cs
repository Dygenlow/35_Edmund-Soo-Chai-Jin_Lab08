using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestScript : MonoBehaviour
{
    public GameObject scoreText;

    float spaceBarPressed = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            scoreText.GetComponent<Text>().text = ("SpaceBar: " + spaceBarPressed);

            print("SpaceBar Pressed: " + spaceBarPressed);

            ++spaceBarPressed;
        }
    }
}
