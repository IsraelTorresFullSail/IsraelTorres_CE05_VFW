using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsraelTorres_CE05
{
    public class Spaceship
    {
        private string _name;
        private decimal _crewSize;
        private bool _activeDuty;
        private bool _cruiser;
        private bool _destroyer;
        private bool _freighter;
        private int _imageIndex;
        private string _typeOfShip;

        public string Name
        {
            get { return _name; }
            set{ _name = value; }
        }
        public decimal CrewSize
        {
            get { return _crewSize; }
            set { _crewSize = value; }
        }
        public bool ActiveDuty
        {
            get { return _activeDuty; }
            set { _activeDuty = value; }
        }
        public bool Cruiser
        {
            get{ return _cruiser; }
            set { _cruiser = value; }
        }
        public bool Destroyer
        {
            get { return _destroyer; }
            set { _destroyer = value; }
        }
        public bool Freighter
        {
            get { return _freighter; }
            set { _freighter = value; }
        }
        public int ImageIndex
        {
            get { return _imageIndex; }
            set { _imageIndex = value; }
        }
        public string TypeOfShip
        {
            get { return _typeOfShip; }
            set { _typeOfShip = value; }
        }
        

        public override string ToString()
        {
            string item = TypeOfShip + ": " + Name + ".";

            return item;
        }
    }
}
