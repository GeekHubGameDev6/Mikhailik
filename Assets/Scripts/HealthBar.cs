﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{

    public GameObject ship;
    public GameObject player;
    public GameObject healthbar;
    public float Health = 100f;
    public float curHealth;

    public GameObject Lives3;
    public GameObject Lives2;
    public GameObject Lives1;

    // Use this for initialization
    void Start ()
	{
	    curHealth = Health;
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
    }

    void SetHealthBar(float myHealth)
    {
        healthbar.transform.localScale = new Vector3(Mathf.Clamp(myHealth,0f ,1f), healthbar.transform.localScale.y, healthbar.transform.localScale.z);
        if (curHealth == 0)
        {
            PlayerKilled();
        }
    }

    public void DecreaseHealth()
    {
            curHealth -= 25f;
            float calc_Health = curHealth / Health;
            SetHealthBar(calc_Health);
            Debug.Log(curHealth);
        
    }

    void PlayerKilled()
    {
        ship.GetComponent<Transform>().position = new Vector2(-5.27f, -4.27f);
        Debug.Log("Player Killed!");
        var rotationVector = player.transform.rotation.eulerAngles;
        rotationVector.z = 12.107f;
        player.transform.rotation = Quaternion.Euler(rotationVector);
        player.GetComponent<Transform>().position = new Vector3(-5.594f, -3.958f);
        
    }
}
