﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour {
	
	public int level = 1;
    public Text levelText;
    public Text playerHpText;
    public Text enemyHpText;
	public Text playerXP;

    private Player playerScript;
    private Enemy enemyScript;

    // Use this for initialization
    void Start () {
        //healthPoints = GameManager.instance;
        levelText.text = string.Format("Level: {0}", level);
        playerHpText.text = string.Format("{0}", "");
        playerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        playerHpText.text = string.Format("Level: {0}", level);


    //enemyScript = GameObject.FindGameObjectWithTag("Enemy").GetComponent<Enemy>();
}

// Update is called once per frame
void Update () {
		
	}

    void FixedUpdate()
    {
        //if(string.IsNullOrEmpty(playerMaxHpText.text))
        //    playerMaxHpText.text = string.Format("{0}", playerScript.playerStats.MaxHealth);

        //if (playerScript.isEnemyAlive)
        //    enemyHpText.text = string.Format("Enemy: {0}", playerScript.currentEnemy.stats.Health );

        //if (playerScript.currentEnemy.stats != null)
        //    if (playerScript.currentEnemy.stats.Health <= 0 && playerScript.speed == 0)
        //        enemyHpText.text = string.Format("Enemy: {0}", "0");


        if (playerScript.isEnemyDestroyed && playerScript.currentEnemy.stats.Health <= 0) {
            level++;
            playerScript.level = level;
            enemyHpText.text = string.Format("{0}", "");
            playerScript.isEnemyDestroyed = false;
        }
    }
}
