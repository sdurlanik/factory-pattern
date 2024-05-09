using UnityEngine;

namespace SDurlanik.AbstractFactory
{
    [CreateAssetMenu (fileName = "GenericShieldFactory", menuName = "AbstractFactory/GenericShieldFactory")]
    public class GenericShieldFactory : ShieldFactory
    {
        IShield _shield;
        public override IShield ProvideShield()
        {
            if ( _shield == null)
            {
                _shield = new Shield();
            }
            
            return new Shield();
        }
    }
}