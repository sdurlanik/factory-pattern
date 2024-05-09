using UnityEngine;

namespace SDurlanik.AbstractFactory
{
    [CreateAssetMenu(fileName = "SwordFactory", menuName = "AbstractFactory/SwordFactory")]
    public class SwordFactory : WeaponFactory
    {
        IWeapon _weapon;

        public override IWeapon ProvideWeapon()
        {
            if (_weapon == null)
            {
                _weapon = new Sword();
            }

            return _weapon;
        }
    }
}