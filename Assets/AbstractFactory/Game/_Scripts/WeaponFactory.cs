using UnityEngine;

namespace SDurlanik.AbstractFactory
{
    public interface IWeapon
    {
        void Attack();
        
        static IWeapon CreateDefaultWeapon()
        {
            return new Sword();
        }
    }

    public class Sword : IWeapon
    {
        public void Attack()
        {
            Debug.Log("Sword Attack");
        }
    }

    public class Gun : IWeapon
    {
        public void Attack()
        {
            Debug.Log("Gun Attack");
        }
    }

    public abstract class WeaponFactory : ScriptableObject
    {
        public abstract IWeapon ProvideWeapon();
    }
}