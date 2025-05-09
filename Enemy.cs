using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public Transform target;
    public int playerDamage = 2;

    void Update()
    {
        //������ ������ ���� ������� NPC �� �����
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        //������������� ������ ���� NPC ����� � ����
        transform.LookAt(target.position);
    }
    public void OnTriggerEnter(Collider other)
    {
        // ���������, ���� �� � ������� ��������� Player
        Player player = other.GetComponent<Player>();

        // ���� ��������� ������, ������� ����
        if (player != null)
        {
            player.TakeDamage(playerDamage);
        }

    }
}
