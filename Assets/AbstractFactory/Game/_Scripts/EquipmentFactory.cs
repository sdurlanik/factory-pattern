using UnityEngine;

namespace SDurlanik.AbstractFactory
{
    [CreateAssetMenu(fileName = "EquipmentFactory", menuName = "AbstractFactory/EquipmentFactory")]
    public class EquipmentFactory : ScriptableObject
    {
        public WeaponFactory weaponFactory;
        public ShieldFactory shieldFactory;

        public IWeapon ProvideWeapon()
        {
            return weaponFactory == null ? IWeapon.CreateDefaultWeapon() : weaponFactory.ProvideWeapon();
        }

        public IShield ProvideShield()
        {
            return shieldFactory == null ? IShield.CreateDefaultShield() : shieldFactory.ProvideShield();
        }
    }
}