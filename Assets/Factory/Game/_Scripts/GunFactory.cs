using UnityEngine;

namespace SDurlanik.Factory
{
    [CreateAssetMenu(fileName = "GunFactory", menuName = "Factory/GunFactory")]
    public class GunFactory : WeaponFactory
    {
        public override IWeapon CreateWeapon()
        {
            return new Gun();
        }
    }
}