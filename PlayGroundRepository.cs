using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayGroundLib
{
    public class PlayGroundRepository
    {

        private int _nextId = 1;

        private List<PlayGround> playGrounds = new List<PlayGround>()
        {
            new PlayGround { Id = 1, Name = "Millpark", MaxChildren = 10, MinAge = 5 },
            new PlayGround { Id = 2, Name = "Secret Playground", MaxChildren = 12, MinAge = 4 },
            new PlayGround { Id = 3, Name = "Library", MaxChildren = 8, MinAge = 3 },
            new PlayGround { Id = 4, Name = "School", MaxChildren = 15, MinAge = 7 }
        };

        public List<PlayGround> GetAll()
        {
            return playGrounds;
        }


        public PlayGround GetById(int id)
        {
            return playGrounds.FirstOrDefault(pg => pg.Id == id);
        }
        public void AddP(PlayGround playGr)
        {
            playGr.Id = _nextId++;
            playGrounds.Add(playGr);
        }

        public void UpdateP(PlayGround playGr)
        {
            var existingPlayGr = GetById(playGr.Id);
            if (existingPlayGr != null)
            {
                existingPlayGr.Name = playGr.Name;
                existingPlayGr.MaxChildren = playGr.MaxChildren;
                existingPlayGr.MinAge = playGr.MinAge;
            }
        }
    }
}
