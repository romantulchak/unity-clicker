using System.IO;

namespace Model
{
    public class Monster
    {
        public string Name { get; set; }
        public int FullHealth { get; set; }
        public int CurrentHealth { get; set; }
        public string FileName { get; set; }

        public Monster(string name, int fullHealth, string fileName)
        {
            Name = name;
            FullHealth = fullHealth;
            FileName = $"Game/Levels/Monsters/{fileName}";
            CurrentHealth = fullHealth;
        }
    }
}