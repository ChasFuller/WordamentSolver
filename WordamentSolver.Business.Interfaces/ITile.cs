using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordamentSolver.Business.Interfaces
{
    public interface ITile
    {
        char Letter
        {
            get;
            set;
        }

        IList<ITile> ConnectedTiles
        {
            get;
            set;
        }

        bool IsUsed
        {
            get;
            set;
        }

        void addConnectedTile(ITile newTile);
    }
}
