using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    public Transform attackPoint;
    public GameObject fireballPrefab;
    public int health = 10;
    public void TakeDamage(int damage)
    {
        health -= damage;
        print("�������� ������: " + health); //healht ��� �������� �������� ������ 
        

    }
    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireballPrefab,attackPoint.position, attackPoint.rotation);
        }
    }
}
