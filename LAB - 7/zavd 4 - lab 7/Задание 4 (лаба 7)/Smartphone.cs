using System;
using System.Collections.Generic;
using System.Text;

namespace Задание_4__лаба_7_
{
    class Smartphone : ICallProperty, IBrowseProperty
    {
        public delegate void SmartphoneHandler(object sender, SmartphoneEventArgs sea);
        public event SmartphoneHandler Notify;

        public Smartphone() { }

        public void Call(string number) => Notify?.Invoke(this, new SmartphoneEventArgs($"Calling... {number}"));
        public void Browse(string url)
        {
            bool IsDigit = false;
            for(int i=0;i<url.Length;i++)
            {
                IsDigit = int.TryParse(Convert.ToString(url[i]),out int n);
                if (IsDigit) { Notify?.Invoke(this, new SmartphoneEventArgs("Invalid URL!")); break; }
            }
            if (!IsDigit) { Notify?.Invoke(this, new SmartphoneEventArgs($"Browsing: {url}!")); }
        }
    }
}
