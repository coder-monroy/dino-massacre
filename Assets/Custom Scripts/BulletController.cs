using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    private float destroyTimer = 6f;
    
    public void WasShot() {
        Destroy(this, destroyTimer);
    }
}
