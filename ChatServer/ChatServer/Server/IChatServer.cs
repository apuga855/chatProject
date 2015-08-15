using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatServer.Server
{

    /// <summary>
    /// Represents a server instance
    /// </summary>
    public interface IChatServer
    {
        /// <summary>
        /// Action that starts the server
        /// </summary>
        event Action ServerStart;

        /// <summary>
        /// Action that initializes the server 
        /// </summary>
        event Action ServerInitialize;

        /// <summary>
        /// Action to shutdown server
        /// </summary>
        event Action ServerShutDown;

    }
}
