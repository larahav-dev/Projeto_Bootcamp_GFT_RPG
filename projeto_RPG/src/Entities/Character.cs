namespace projeto_RPG.src.Entities
{
    public class Character
    {
        #region "Object Properties"
        //Declarando variaveis/propriedades de um objeto:
        public string CharacterName { get; set; }
        public int CharacterLevel { get; set; }
        public string CharacterClass { get; set; }
        public int CharacterLifePoints { get; set; }
        public int CharacterManaPoints { get; set; }
        
        #endregion

        #region "Constructor"
        //Criando um método construtor:
        public Character(string Name, int Level, string Class, int LifePoints, int ManaPoints)
        {
            this.CharacterName          = Name;
            this.CharacterLevel         = Level;
            this.CharacterClass         = Class;
            this.CharacterLifePoints    = LifePoints;
            this.CharacterManaPoints    = ManaPoints;
        } 
        
        public Character(string Name, int Level, string Class)
        {
            this.CharacterName  = Name;
            this.CharacterLevel = Level;
            this.CharacterClass = Class;
        } 

        #endregion

        #region "Functions"
        /*Declarando uma função para retornar as informações 
        do personagem e sobrepondo o "ToString" original*/
        public override string ToString()
        {
            return 
                "Nome: "        + this.CharacterName        + 
                "\nLevel: "     + this.CharacterLevel       +
                "\nClasse: "    + this.CharacterClass       +
                "\nHP: "        + this.CharacterLifePoints  +
                "\nMP: "        + this.CharacterManaPoints  ;
        }

        #endregion

    }
}