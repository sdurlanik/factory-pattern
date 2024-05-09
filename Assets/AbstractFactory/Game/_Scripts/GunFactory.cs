using UnityEngine;

namespace SDurlanik.AbstractFactory
{
    [CreateAssetMenu(fileName = "GunFactory", menuName = "AbstractFactory/GunFactory")]
    public class GunFactory : WeaponFactory
    {
        IWeapon _weapon;

        public override IWeapon ProvideWeapon()
        {
            if (_weapon == null)
            {
                _weapon = new Gun();
            }

            return _weapon;
        }
    }
}