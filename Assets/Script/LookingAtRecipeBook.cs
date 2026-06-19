using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookingAtRecipeBook : MonoBehaviour
{
   
    public GameObject Canvas;
    bool canClosed = false;
    public GameObject recipeBook;

    public GameObject Fever ,Cold,Cough,SoreThroat,Furuncle,Constipation,TineaVersicolor,Smallpox;
    
    void Awake()
    {
       
    }

    // Update is called once per frame
  public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Tab) && canClosed == false)
        {
            if (!recipeBook.activeInHierarchy )
            {
                recipeBook.SetActive(true);
                Fever.SetActive(true);
                 Cold.SetActive(false);
                 Cough.SetActive(false);
                SoreThroat.SetActive(false);
                Furuncle.SetActive(false);
                Constipation.SetActive(false);
                TineaVersicolor.SetActive(false);
                Smallpox.SetActive(false);
                canClosed = true;
   
            }

            

            
        }
        if(recipeBook.activeInHierarchy && canClosed == true )
        {
            if (Input.GetKeyUp(KeyCode.Tab) )
            {
                recipeBook.SetActive(false);
                canClosed = false;
   
            }
        
    }
    }
}
