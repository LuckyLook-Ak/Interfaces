using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Models
{
    abstract class AutoMobile
    {
        //field always private
        private bool _isOn;
        //property always public except 
        //set couse we have a method for this 
        public bool IsOn
        {
            get { return _isOn; }
            private protected set { _isOn = value; }
        }
        public AutoMobile()
        {

        }

        public AutoMobile(bool IsOn)
        {
            this._isOn = IsOn;
        }
        public void Start()
        {
            this._isOn = true;

        }
        public void Stop()
        {
            this._isOn = false;
        }
        abstract public void SteerLeft();
        //abstract public void SteerRight();
        //abstract public void Steer(bool steerLeft);

        
    }
}
