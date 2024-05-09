using UnityEngine;

namespace SDurlanik.Factory
{
    [CreateAssetMenu(fileName = "SwordFactory", menuName = "Factory/SwordFactory")]
    public class SwordFactory : WeaponFactory
    {
        public override IWeapon CreateWeapon()
        {
            return new Sword();
        }
    }
}