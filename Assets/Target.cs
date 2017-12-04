using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class Target : MonoBehaviour {

    public float health = 50f;
    public GameObject target;
    public Score score;
    private NavMeshAgent nav;

    private FlashLight flashLightScript;

    public void TakeDamage(float amount)
    {
        health -= amount;
        if(health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Vector2 distance = Random.insideUnitCircle;
        distance.Normalize();
        distance *= 20f;

        float x = target.transform.position.x + distance.x;
        float z = transform.transform.position.z + distance.y;
        transform.position = new Vector3(x, 0, z);
        
    }

    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
        flashLightScript = target.transform.GetComponentInChildren<FlashLight>();
    }

    void FixedUpdate()
    {
        nav.SetDestination(target.transform.position);
        nav.speed = flashLightScript.Intensity;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            PlayerPrefs.SetFloat("Score", score.score);
            SceneManager.LoadScene(0);
        }
    }
}
