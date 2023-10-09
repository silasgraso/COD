using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COD
{
    public class WeaponRepository
    {
        private int _nextId = 1;
        private List<Weapon> _weapons = new List<Weapon>();
        public WeaponRepository() 
        {
            _weapons.Add(new Weapon() { Id = _nextId++, Name = "M4A1", Type = "Assault Rifle", Muzzle = new Muzzle("Muzzle Brake", 0.19, 0.25), Barrel = new Barrel("Corvus Custom Marksman", 0.99, 0.65) });
            _weapons.Add(new Weapon() { Id = _nextId++, Name = "M13", Type = "Assault Rifle", Muzzle = new Muzzle("Muzzle Brake", 0.19, 0.25), Barrel = new Barrel("Tempus Marksman", 0.99, 0.65) });
            _weapons.Add(new Weapon() { Id = _nextId++, Name = "Kilo 141", Type = "Assault Rifle", Muzzle = new Muzzle("Muzzle Brake", 0.19, 0.25), Barrel = new Barrel("Singuard Arms 19.8 Prowler", 0.99, 0.65) });
            _weapons.Add(new Weapon() { Id = _nextId++, Name = "FAL", Type = "SMG", Muzzle = new Muzzle("Muzzle Brake", 0.19, 0.25), Barrel = new Barrel("13.0 OSW Para", 0.99, 0.65) });
            _weapons.Add(new Weapon() { Id = _nextId++, Name = "MP5", Type = "SMG", Muzzle = new Muzzle("Muzzle Brake", 0.19, 0.25), Barrel = new Barrel("FTAC Collapsible", 0.99, 0.65) });
        }

        public IEnumerable<Weapon> GetAll(string? weaponType = null)
        {
            IEnumerable<Weapon> weapons = new List<Weapon>(_weapons);

            switch (weaponType)
            {
                case null:
                    return weapons;
                    break;

                case "assault rifle":
                   weapons = weapons.Where(w => w.Type == "Assault Rifle");
                    break;
            }
            return _weapons;
        }

        public Weapon GetById(int id)
        {
            return _weapons.FirstOrDefault(w => w.Id == id);
        }

        public Weapon Add(Weapon weapon)
        {
            weapon.Id = _nextId++;
            _weapons.Add(weapon);
            return weapon;
        }

        public Weapon Remove(int id)
        {
            Weapon weapon = GetById(id);
            if (weapon == null)
            {
                return null;
            }
            _weapons.Remove(weapon);
            return weapon;
        }

        //public Weapon Update(int id, Weapon weapon) { }
    }
}
