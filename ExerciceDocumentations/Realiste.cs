namespace ExerciceDocumentations
{
    /// <summary>
    /// permet d'écrire et aussi du code peut entrer dedans
    /// <code>
    /// Realiste maClasse = new Realiste();
    /// maClasse.
    /// </code>
    /// </summary>
    public class Realiste
    {       /// <summary> est une classe nomme Realiste</summary>
        private string nom;
        private string prenom;
        private int age;
        public event EventHandler<int> eventChanged;

        /// <summary>
        /// Prérequis
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="age"></param>
        public Realiste(string nom, string prenom, int age)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;
        }   
        /// <summary>Fait un teste d'âge</summary>
        public string test()
        {
            if (age >= 18)
            {
                return age + ", vous êtes un adulte";
            }
            else
            {
                return age + ", vous n'êtes pas un adulte ";
            }
        }
        public int monterAge() {
            age++;
            eventChanged?.Invoke(this, age);
            return age;
        }

        public override string ToString()
        {
            return nom + " " + prenom + ", " + test();
        }
    }
}