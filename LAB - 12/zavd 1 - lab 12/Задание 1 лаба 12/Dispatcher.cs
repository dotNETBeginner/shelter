using System;
using System.Collections.Generic;
using System.Text;

namespace Задание_1_лаба_12
{
    public delegate void NameChangeEventHandler(object sender,NameChangeEventArgs args);

    class Dispatcher
    {

        private string _name;
        
        public string Name 
        { 
          get
          { return _name; }

          set
          {
            OnNameChange(new NameChangeEventArgs(value));
                _name = value; 
          } 
        }

        public event NameChangeEventHandler NameChange;

        public Dispatcher(string name, Handler someHandler)
        {
            NameChange += someHandler.OnDispatcherNameChange;
            Name = name;
        }

        public void OnNameChange(NameChangeEventArgs args) => NameChange.Invoke(this,args);
    }
}
