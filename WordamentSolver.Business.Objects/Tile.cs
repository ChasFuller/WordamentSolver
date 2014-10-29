using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordamentSolver.Business.Interfaces;

namespace WordamentSolver.Business.Objects
{
    public class Tile : ITile
    {
        private char _letter = '\0';
        private List<ITile> _connectedTiles = new List<ITile>();
        private bool _isUsed = false;

        public Tile()
        {
        }

        public Tile(char letter)
        {
            _letter = letter;
        }

        public char Letter
        {
            get
            {
                return _letter;
            }
            set
            {
                _letter = value;
            }
        }

        public IList<ITile> ConnectedTiles
        {
            get
            {
                return _connectedTiles;
            }
            set
            {
                _connectedTiles = (List<ITile>) value;
            }
        }

        public bool IsUsed
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public void addConnectedTile(ITile newConnectedTile)
        {
            _connectedTiles.Add(newConnectedTile);
        }
    }
}
