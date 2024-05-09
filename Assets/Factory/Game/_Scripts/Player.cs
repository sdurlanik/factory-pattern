using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SDurlanik.Factory
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private WeaponFactory weaponFactory;
        private IWeapon _weapon = new Sword();

        private void Start()
        {
            if( weaponFactory != null )
            {
                _weapon = weaponFactory.CreateWeapon();
            }
            
            Attack();
        }
        
        public void Attack()
        {
            _weapon?.Attack();
        }
    }
}