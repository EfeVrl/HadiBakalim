using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleporter : MonoBehaviour
{
    public GameObject Player;
    public GameObject TeleportTo;
    public GameObject TeleportStart;
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Teleporter"))
        {
            Player.transform.position = TeleportTo.transform.position;
            Player.transform.eulerAngles = new Vector3(0,180,0);
        }
        if (collision.gameObject.CompareTag("Second Teleporter"))
        {
            Player.transform.position = TeleportStart.transform.position;
        }
    }

}
