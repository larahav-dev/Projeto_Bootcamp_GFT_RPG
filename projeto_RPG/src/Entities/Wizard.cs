namespace projeto_RPG.src.Entities
{
    public class Wizard : Character
    {
        public Wizard(string Name, int Level, string Class, int LifePoints, int ManaPoints) : base(Name, Level, Class, LifePoints, ManaPoints)
        {
            this.CharacterName = Name;
            this.CharacterLevel = Level;
            this.CharacterClass = Class;
            this.CharacterLifePoints = LifePoints;
            this.CharacterManaPoints = ManaPoints;
        }

        public string Attack()
        {
            return this.CharacterName + " atacou com sua magia.";
        }

        public string Attack(int Dano)
        {
            if(Dano > 6)
            {
                return this.CharacterName + " atacou com sua magia e foi super efetivo.";
            }

            else
            {
                return this.CharacterName + " atacou com sua magia e causou pouco dano.";
            }
            
        }
    }
}