using DesignPattern.Models.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    //State
    public abstract class ConnectionState
    {
        public abstract void Open(Connection context);
        public abstract void Close(Connection context);
    }

    //Concrete State
    public class ConnectionClosed:ConnectionState
    {
        public override void Open(Connection context)
        {
            context.State = new ConnectionOpened();
        }

        public override void Close(Connection context)
        {
            context.State = new ConnectionClosed();
        }
    }

    //Concrete State
    public class ConnectionOpened : ConnectionState
    {
        public override void Open(Connection context)
        {
            context.State = new ConnectionOpened();
        }

        public override void Close(Connection context)
        {
            context.State = new ConnectionClosed();
        }
    }

    //Context
    public class Connection
    {
        private ConnectionState _state;//delega as conexoes para o obj state

        public Connection(ConnectionState state)
        {
            this._state = state;
        }

        public ConnectionState State
        {
            get 
            {
                return _state;
            }
            set
            {
                _state = value;
                WriterMessages.AmarzenaMSG(this, "State: " + _state.GetType().Name);
            }
        }

        public void Open()
        {
            _state.Open(this);
        }

        public void Close()
        {
            _state.Close(this);
        }
    }

}
