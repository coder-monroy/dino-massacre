using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public GameObject thisDino;
    private Polyperfect.Dinos.Dino_WanderScript dinoMaster;
    public TMP_Text healthCounter;
    private float health;
    // Start is called before the first frame update
    void Start()
    {
        dinoMaster = thisDino.GetComponent<Polyperfect.Dinos.Dino_WanderScript>();
    }

    // Update is called once per frame
    void Update()
    {
        // updates player health counter
        health = dinoMaster.GetHealth();
        healthCounter.text = "+ " + health.ToString();
    }
}
