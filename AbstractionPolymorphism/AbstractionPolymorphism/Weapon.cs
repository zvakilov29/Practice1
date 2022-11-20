using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractionPolymorphism
{
    public abstract class Weapon
    {
        public string Model { get; set; }
        public int Damage { get; set; }
        public int Range { get; set; }
        public abstract void Attack();
    }

    #region WeaponClasses
    public abstract class MeleeWeapon : Weapon
    {
        public int Durability { get; set; }
    }
    public abstract class MagicWeapon : Weapon
    {
        public int MagicPoints { get; set; }
        public abstract void Charge();
    }
    public abstract class RangeWeapon : Weapon
    {
        public int CartridgeCapacity { get; set; }
        public int CartridgeBalance { get; set; }
        public abstract void Reload();
    }
    #endregion

    #region ActualWeapons
    class Sword : MeleeWeapon
    {
        public override void Attack()
        {
            if (Durability > 0)
            {
                Console.WriteLine("Enemy's body is hit by the sword");
                Durability--;
            }
            else
                Console.WriteLine("Warning! The sword is broken and can't be used!");
        }
    }
    class MagicStaff : MagicWeapon
    {
        public override void Charge()
        {
            Console.WriteLine("The magic staff is charged with magic");
            MagicPoints++;
        }

        public override void Attack()
        {
            if (MagicPoints > 0)
            {
                Console.WriteLine("Enemy is hit by the magic spell");
                MagicPoints--;
            }
            else
                Console.WriteLine("Warning! The staff isn't charged with magic! No spell is produced");
        }
    }
    class Pistol : RangeWeapon
    {
        public override void Reload()
        {
            Console.WriteLine("Pistol is reloaded");
            CartridgeBalance = CartridgeCapacity;
        }
        public override void Attack()
        {
            if (CartridgeBalance > 0)
            {
                Console.WriteLine("Enemy is shot by the pistol");
                CartridgeBalance--;
            }
            else
                Console.WriteLine("Warning! The pistol has no bullets, the cartridge is empty!");
        }
    }
    #endregion
}
