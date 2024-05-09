using UnityEngine;

namespace SDurlanik.AbstractFactory
{
    public interface IShield
    {
        void Defend();
        
        static IShield CreateDefaultShield()
        {
            return new Shield();
        }
    }
    
    public class Shield : IShield
    {
        public void Defend()
        {
            Debug.Log("Shield Defend");
        }
    }
    public abstract class ShieldFactory : ScriptableObject
    {
        public abstract IShield ProvideShield();
    }
}