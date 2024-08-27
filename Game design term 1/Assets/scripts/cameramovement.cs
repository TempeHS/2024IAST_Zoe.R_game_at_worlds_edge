using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramovement : MonoBehaviour
{
[SerializeField] private Transform player;

private void Update()
{
    //follow player
    transform.position = new Vector3(player.position.x, player.position.y, transform.position.z);
}

}
