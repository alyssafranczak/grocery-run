using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointCounter : MonoBehaviour
{
    int points;
    public Text pointText;
    public Text finalScoreText;
    public AudioClip pointSFX;

    // Start is called before the first frame update
    void Start()
    {
        points = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Item")
        {
            points++;
            pointText.text = points.ToString();
            finalScoreText.text = points.ToString();
            AudioSource.PlayClipAtPoint(pointSFX, Camera.main.transform.position);
        }
    }
}
