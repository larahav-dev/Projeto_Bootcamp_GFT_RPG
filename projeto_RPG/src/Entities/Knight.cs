namespace projeto_RPG.src.Entities
{
    public class Knight : Character
    {
        public Knight(string Name, int Level, string Class, int LifePoints, int ManaPoints) : base(Name, Level, Class, LifePoints, ManaPoints)
        {
            this.CharacterName = Name;
            this.CharacterLevel = Level;
            this.CharacterClass = Class;
            this.CharacterLifePoints = LifePoints;
            this.CharacterManaPoints = ManaPoints;
        }

        public string Attack()
        {
            return this.CharacterName + " atacou com sua espada.";
        }

        public string Attack(int Dano)
        {
            if(Dano > 6)
            {
                return this.CharacterName + " atacou com sua espada e foi super efetivo.";
            }

            else
            {
                return this.CharacterName + " atacou com sua espada e causou pouco dano.";
            }
            
        }
    }
}