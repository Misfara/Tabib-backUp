using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PickUp : MonoBehaviour //, IDataPersistence
{
    // [SerializeField] private string id;

    // [ContextMenu("Generate guid for id")]
    // private void GenerateGuid()
    // {
    //     id = System.Guid.NewGuid().ToString();
    // }
    private Inventory inventory;

    public GameObject itemButton;

    private void Start(){
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player")){
            for ( int i= 0 ; i <inventory.slots.Length;i++)
            {
                if(inventory.isFull[i]== false)
                {
                    inventory.isFull[i] = true;
                    Instantiate(itemButton, inventory.slots[i].transform,false);
                    Destroy(gameObject);
                    break;
                }
            }
        }
    }

    // public void LoadData(GameData data)
    // {
    //     data.itemButton.TryGetValue(id, out collected);
    //     if (collected)
    //     {
    //         visual.gameObject.SetActive(false);
    //     }
    // }

    // public void SaveData(ref GameData data)
    // {
    //     if (data.itemButton.ContainsKey(id))
    //     {
    //         data.itemButton.Remove(id);
    //     }
    //     data.itemButton.Add(id, collected);
    // }
}
