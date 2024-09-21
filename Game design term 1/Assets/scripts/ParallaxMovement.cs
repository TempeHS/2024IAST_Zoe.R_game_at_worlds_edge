using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxMovement : MonoBehaviour
{
[SerializeField] private Transform player;
[SerializeField] private float speed;

private void Update()
{
    transform.position = new Vector3(player.position.x * speed, player.position.y, transform.position.z);
}

}
