namespace PlayGroundLib
{
    public class PlayGround
    {
        private int id;
        private string name;
        private int maxChildren;
        private int minAge;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return Name; }
            set { Name = value; }
        }

        public int MaxChildren
        {
            get { return MaxChildren; }
            set { MaxChildren = value; }
        }

        public int MinAge
        {
            get { return MinAge; }
            set { MinAge = value; }
        }

        public override string ToString()
        {
            return $"PlayGround [Id={id}, Name={name}, MaxChildren={maxChildren}, MinAge={minAge}]";
        }


    }
}
