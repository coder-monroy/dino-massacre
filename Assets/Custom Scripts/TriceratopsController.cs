using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriceratopsController : MonoBehaviour
{
    public GameObject thisDino;
    public Animator anim;
    private Polyperfect.Dinos.Dino_WanderScript dinoMaster;
    public AudioSource source;
    public AudioClip shotSound;
    private float destroyTimer = 3.5f;
    private float health = 80f; // matches the health/toughness of the AI Stats given to this Dinosaur

    void Start()
    {
        // Anim is not used here, but can be used to force animations regardless of 
        // the state the Dinosaur is in (See Polyperfect.Common.Common_WanderScript)
        anim = thisDino.GetComponent<Animator>();
        dinoMaster = thisDino.GetComponent<Polyperfect.Dinos.Dino_WanderScript>();
    }
    void Update() {

        // If health is at or below 0, destroy the Dinosaur
        if(health <= 0f) {
            Destroy(gameObject, destroyTimer);
        }

    }

    // method called whenever hitbox has collision
    private void OnCollisionEnter(Collision other) {
        // if colliding object is a bullet...
        if(other.gameObject.tag.Equals("Bullet")) {
            // play shot sound
            if(health > 0f) {
                source.PlayOneShot(shotSound);
            }
            // destroy bullet and update health
            Destroy(other.gameObject);
            dinoMaster.TakeDamage(20f);
            health = health - 20f;
        }
    }
}
