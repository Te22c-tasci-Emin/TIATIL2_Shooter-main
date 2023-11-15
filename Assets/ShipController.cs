using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class ShipController : MonoBehaviour
{

  [SerializeField]
  float speed = 4.1f;

  [SerializeField]
  GameObject boltPrefab;

  [SerializeField]
  GameObject gun;

  [SerializeField]
  float timeBetweenShots = 0.5f;
  float timeSinceLastShot = 0;

  [SerializeField]
  GameObject Enemycombatent;

  float timeBetweenPowerup = 80f;
  float timeSinceLastPowerup = 20;
  bool isPoweredUp = true;



  // Update is called once per frame
  void Update()
  {

    // Om vi just nu har powerup (boolen är true): dra av från timern
    // Om timern < 0: sätt boolen till false
    if (isPoweredUp == true)
    {
      timeSinceLastPowerup -= Time.deltaTime;
    }

    if (timeSinceLastPowerup < 0)

    {
      isPoweredUp = false;

    }





    float moveX = Input.GetAxisRaw("Horizontal");
    float moveY = Input.GetAxisRaw("Vertical");

    Vector2 movementX = new Vector2(moveX, 0);
    Vector2 movementY = new Vector2(0, moveY);

    Vector2 movement = movementX + movementY;

    transform.Translate(movement * speed * Time.deltaTime);

    if (Mathf.Abs(transform.position.x) > 8.5f)
    {
      transform.Translate(-movementX * speed * Time.deltaTime);
    }

    if (Mathf.Abs(transform.position.y) > 4.5f)
    {
      transform.Translate(-movementY * speed * Time.deltaTime);
    }

    timeSinceLastShot += Time.deltaTime;
    if (Input.GetAxisRaw("Fire1") > 0 && timeSinceLastShot > timeBetweenShots)
    {
      timeSinceLastShot = 0;
      // Om boolen är true, skjut det bättre skottet
      // Annars skjut det vanliga
      Instantiate(boltPrefab, gun.transform.position, Quaternion.identity);
    }
  }

  public void powerup()
  {

    // sätt boolen till true
    // sätt timern till 5

    timeSinceLastPowerup -= Time.deltaTime;

    if (timeSinceLastPowerup > timeBetweenPowerup)
    {
      timeSinceLastPowerup = 80;
    }

    if (timeSinceLastPowerup > timeBetweenPowerup)
    {

    }
  }
}
/*
- Skjuta skott
- Fiender
- Liv
- Score
- Startmeny
*/
//yuh