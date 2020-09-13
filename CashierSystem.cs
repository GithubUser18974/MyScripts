using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CashierSystem : MonoBehaviour
{
    public GameObject[] PlayerPrivateSlots;
    int total = 0;
    GameObject basket;
    bool isThereIsBasket = false;
    public UiManager uimanager;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Items")
        {
            total += other.gameObject.GetComponent<ItemData>().price;
            uimanager.SetTotal(total);
            uimanager.SetDebug(other.name + "  " + total);

        }
        else
        {

        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Items")
        {
            total -= other.gameObject.GetComponent<ItemData>().price;
            uimanager.SetTotal(total);
            uimanager.SetDebug(other.name + "  " + total);

        }
    }

    //public void BuyNow()
    //{
    //     total = 0;

    //    foreach (GameObject slot in PlayerPrivateSlots)
    //    {
    //        if (slot.GetComponentInChildren<ItemData>())
    //        {
    //            total += slot.GetComponentInChildren<ItemData>().price;
    //            uimanager.SetDebugSystem(slot.name + "T_" + total + "    ");
    //        }
    //        else
    //        {
    //        }
    //    }
    //    if (isThereIsBasket)
    //    {
    //        CalculateFromBasketSlots(basket);
    //    }
    //    uimanager.SetTotalPrice(total);
    //}

    //public void CalculateFromBasketSlots(GameObject basket)
    //{
    //    GameObject firstChild = basket.transform.GetChild(0).gameObject;
    //    GameObject[] slots = firstChild.GetComponentsInChildren<GameObject>();
    //    foreach(GameObject slot in slots)
    //    {
    //        if (slot.GetComponentInChildren<ItemData>())
    //        {
    //            total += slot.GetComponentInChildren<ItemData>().price;
    //                            uimanager.SetDebugSystem(slot.name + "T_" + total + "    ");

    //        }
    //        else
    //        {
    //        }
    //    }

    //}
}
