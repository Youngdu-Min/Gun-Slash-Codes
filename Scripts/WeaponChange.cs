using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.CorgiEngine;
using MoreMountains.Tools;

public class WeaponChange : MonoBehaviour
{

    public Weapon weapondata;

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            var characterWeapon = collision.GetComponent<CharacterHandleWeapon>();
            characterWeapon.ChangeWeapon(weapondata,"1",false);
            if (characterWeapon !=null)
            {
                Debug.Log("Weapon Chaned: " + weapondata.name);
            }
            this.gameObject.SetActive(false);
        }
    }

    private void OnEnable()
    {
        Destroy(this, 30);
    }
}
