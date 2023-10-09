namespace COD
{
    public class Weapon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public Muzzle Muzzle { get; set; }

        public Barrel Barrel { get; set; }

        public Weapon()
        {
            
        }

        public void ValidateName()
        {
            if (Name == null) 
            {
                throw new ArgumentNullException();            
            }
            if (Name.Length < 3) 
            {
                throw new ArgumentException("Must be longer than 3");                        
            } 
        }


    }
}