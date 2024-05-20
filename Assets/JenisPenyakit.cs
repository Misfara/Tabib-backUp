using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class JenisPenyakit : MonoBehaviour
{
     public GameObject Fever ,Cold,Cough,SoreThroat,Furuncle,Constipation,TineaVersicolor,Smallpox;
      public UnityEvent OnClick;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    public void FeverDisease()
    {
        Fever.SetActive(true);
        Cold.SetActive(false);
        Cough.SetActive(false);
        SoreThroat.SetActive(false);
        Furuncle.SetActive(false);
        Constipation.SetActive(false);
        TineaVersicolor.SetActive(false);
        Smallpox.SetActive(false);
    }

    public void ColdDisease()
    {
        Fever.SetActive(false);
        Cold.SetActive(true);
        Cough.SetActive(false);
        SoreThroat.SetActive(false);
        Furuncle.SetActive(false);
        Constipation.SetActive(false);
        TineaVersicolor.SetActive(false);
        Smallpox.SetActive(false);
    }

     public void CoughDisease()
    {
         Fever.SetActive(false);
        Cold.SetActive(false);
        Cough.SetActive(true);
        SoreThroat.SetActive(false);
        Furuncle.SetActive(false);
        Constipation.SetActive(false);
        TineaVersicolor.SetActive(false);
        Smallpox.SetActive(false);
    }

     public void SoreThroatDisease()
    {
        Fever.SetActive(false);
        Cold.SetActive(false);
        Cough.SetActive(false);
        SoreThroat.SetActive(true);
        Furuncle.SetActive(false);
        Constipation.SetActive(false);
        TineaVersicolor.SetActive(false);
        Smallpox.SetActive(false);
    }

     public void FuruncleDisease()
    {
        Fever.SetActive(false);
        Cold.SetActive(false);
        Cough.SetActive(false);
        SoreThroat.SetActive(false);
        Furuncle.SetActive(true);
        Constipation.SetActive(false);
        TineaVersicolor.SetActive(false);
        Smallpox.SetActive(false);
    }

     public void ConstipationDisease()
    {
        Fever.SetActive(false);
        Cold.SetActive(false);
        Cough.SetActive(false);
        SoreThroat.SetActive(false);
        Furuncle.SetActive(false);
        Constipation.SetActive(true);
        TineaVersicolor.SetActive(false);
        Smallpox.SetActive(false);
    }

     public void TineaVersicolorDisease()
    {
        Fever.SetActive(false);
        Cold.SetActive(false);
        Cough.SetActive(false);
        SoreThroat.SetActive(false);
        Furuncle.SetActive(false);
        Constipation.SetActive(false);
        TineaVersicolor.SetActive(true);
        Smallpox.SetActive(false);
    }

     public void SmallpoxDisease()
    {
        Fever.SetActive(false);
        Cold.SetActive(false);
        Cough.SetActive(false);
        SoreThroat.SetActive(false);
        Furuncle.SetActive(false);
        Constipation.SetActive(false);
        TineaVersicolor.SetActive(false);
        Smallpox.SetActive(true);
    }

     public void FevertoSmallPoxDisease()
    {
        Fever.SetActive(false);
        Cold.SetActive(false);
        Cough.SetActive(false);
        SoreThroat.SetActive(false);
        Furuncle.SetActive(false);
        Constipation.SetActive(false);
        TineaVersicolor.SetActive(false);
        Smallpox.SetActive(true);
    }

    
     public void SmallPoxtoFeverDisease()
    {
        Fever.SetActive(true);
        Cold.SetActive(false);
        Cough.SetActive(false);
        SoreThroat.SetActive(false);
        Furuncle.SetActive(false);
        Constipation.SetActive(false);
        TineaVersicolor.SetActive(false);
        Smallpox.SetActive(false);
    }


    
}
