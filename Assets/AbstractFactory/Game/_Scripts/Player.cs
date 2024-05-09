using System;
using UnityEngine;

namespace SDurlanik.AbstractFactory
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private EquipmentFactory equipmentFactory;

        private void Start()
        {
            Attack();
            Defend();
        }

        private void Attack()
        {
            equipmentFactory.ProvideWeapon().Attack();
        }
        
        private void Defend()
        {
            equipmentFactory.ProvideShield().Defend();
        }
    }
}