using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] int hitPoints = 5;
    [SerializeField] ParticleSystem onHitvfx;
    [SerializeField] ParticleSystem enemyDeathvfx;
    void Start()
    {
        //gameObject.AddComponent<Rigidbody>().useGravity = false;
    }

    private void OnParticleCollision(GameObject other)
    {
        ScoreOnHit();
            if (hitPoints < 1)
            {
                KillEnemy(other);
            }
           
    }
    
    private void KillEnemy(GameObject other)
    {
        Debug.Log($"{name}Im hit by {other.gameObject.name}");
        //GameObject enemyvfx = Instantiate(enemyDeathvfx, transform.position, Quaternion.identity);

        //enemyDeathvfx.Play();
        //scoreBoard.UpdateScore(pointValue);
        //GameObject enemyvfx = Instantiate(enemydeath, transform.position, Quaternion.identity);
        // enemyvfx.transform.parent = parent.transform;
        DestroyGameObject();
    }
    private void ScoreOnHit()
    {
        //onHitvfx.Play();
        hitPoints--;
    }
    void DestroyGameObject()
    {
        Destroy(gameObject);
    }
}
