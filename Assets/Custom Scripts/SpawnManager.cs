using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] dinos;
    public GameObject screen;
    public Polyperfect.Dinos.Dino_WanderManager manager;
    public TMP_Text clock;
    private bool spawnActive = false;
    private float spawnTime1 = 15f;
    private float spawnTime2 = 12f;
    private float timer = 0f;
    private float totalTime = 0f;
    private float countDown = 180f;
    private float spawnRangeXLeft = -81.3f;
    private float spawnRangeXRight = 71f;
    private float spawnRangeZUp = 123.8f;
    private float spawnRangeZDown = 30.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(spawnActive) {
            if(totalTime < 120f) {
                if(timer <= spawnTime1) {
                    timer += Time.deltaTime;
                    totalTime += Time.deltaTime;
                    clock.text = (countDown - totalTime).ToString();
                }
                else {
                    timer = 0;
                    int dinoProb = Random.Range(1, 10);
                    int dinoIndex = 0;
                    if(dinoProb == 1) {
                        dinoIndex = 3; // spawn T-Rex
                    }
                    else if ((dinoProb == 2) | (dinoProb == 3)) {
                        dinoIndex = 2; // spawn Brachiosaurus
                    }
                    else if (((dinoProb == 4) | (dinoProb == 5)) | (dinoProb == 6)) {
                        dinoIndex = 1; // spawn Triceratops
                    }
                    else {
                        dinoIndex = 0; // spawn Velociraptor
                    }
                    // get spawn position
                    Vector3 spawnPos = new Vector3(Random.Range(spawnRangeXLeft, spawnRangeXRight), 0, Random.Range(spawnRangeZDown, spawnRangeZUp));
                    // actually spawn dino
                    Instantiate(dinos[dinoIndex], spawnPos, dinos[dinoIndex].transform.rotation);
                }
            }
            else if(totalTime < 180f) {
                if(timer <= spawnTime2) {
                    timer += Time.deltaTime;
                    totalTime += Time.deltaTime;
                    clock.text = (countDown - totalTime).ToString();
                }
                else {
                    timer = 0;
                    int dinoProb = Random.Range(1, 10);
                    int dinoIndex = 0;
                    if((dinoProb == 1) | (dinoProb == 2)) {
                        dinoIndex = 3; // spawn T-Rex
                    }
                    else if ((dinoProb == 3) | (dinoProb == 4)) {
                        dinoIndex = 2; // spawn Brachiosaurus
                    }
                    else if ((dinoProb == 5) | (dinoProb == 6)) {
                        dinoIndex = 1; // spawn Triceratops
                    }
                    else {
                        dinoIndex = 0; // spawn Velociraptor
                    }
                    // get spawn position
                    Vector3 spawnPos = new Vector3(Random.Range(spawnRangeXLeft, spawnRangeXRight), 0, Random.Range(spawnRangeZDown, spawnRangeZUp));
                    // actually spawn dino
                    Instantiate(dinos[dinoIndex], spawnPos, dinos[dinoIndex].transform.rotation);
                }
            }
            else {
                ToggleSpawn();
                screen.SetActive(true);
                manager.SwitchPeaceTime(true);
            }
            
        }
        
    }

    public void ToggleSpawn() {
        if(spawnActive) {
            spawnActive = false;
        }
        else {
            spawnActive = true;
        }
    }

    // for testing purposes
    public void Spawn() {
        Vector3 spawnPos = new Vector3(-10.6f, 0f, 22.35f);
        Instantiate(dinos[3], spawnPos, dinos[3].transform.rotation);
    }
}
