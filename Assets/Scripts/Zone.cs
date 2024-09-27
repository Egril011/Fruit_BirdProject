using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Zone : MonoBehaviour
{
    public int zoneId;
    private Score currentScore;
    [SerializeField] AudioSource goodZone;
    [SerializeField] AudioSource badZone;

    public void Start()
    {
        currentScore = FindAnyObjectByType<Score>();
    }


    public void OnTriggerEnter2D(Collider2D collision)
    {
       
        Fruit fruit = collision.gameObject.GetComponent<Fruit>();

        if (zoneId == fruit.fruitID)
        {
            if (!fruit.fruitActive)
            {
                goodZone.Play();
                fruit.fruitActive = true;
                currentScore.AddScore();
            }
        }
        else if (zoneId != fruit.fruitID)
        {
            if (!fruit.fruitActive)
            {
               badZone.Play();
                fruit.fruitActive = true;
                currentScore.LostPoint();
            }
                
        }


    }     
}
