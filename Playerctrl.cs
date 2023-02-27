using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerctrl : MonoBehaviour
{  

   static public Playerctrl instance;

   public Damagereceiver damagereceiver ;
   public Playerstatus playerstatus;
   protected void Awake()
   {
      Playerctrl.instance =this;
     this.damagereceiver = GetComponent<Damagereceiver>();
    this.playerstatus = GetComponent<Playerstatus>();
       //  ngno lành 

       //???kj
   }
}
