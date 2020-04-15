using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupItem : MonoBehaviour
{
    private Inventory inventory;
    public GameObject ItemButton;
    public Vector2 v;

    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            for (int i = 0; i < inventory.Slots.Length; i++)
            {
                if (inventory.IsFull[i] == false)
                {
                    inventory.IsFull[i] = true;
                    //GameObject ItemCopy = Instantiate(ItemButton, inventory.Slots[i].transform, false);//copy object, make child, worldspace
                    //ItemCopy.transform.position = inventory.Slots[i].transform.position;//set position
                    Instantiate(ItemButton, inventory.Slots[i].transform);
                    Destroy(gameObject);
                    break;
                }
            }
        }
    }
}
