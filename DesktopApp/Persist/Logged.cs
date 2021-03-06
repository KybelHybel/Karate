﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp.Persist
{
    class Logged
    {
        public static Logged Instance => _instance ?? (_instance = new Logged());
        public event EventHandler Changed;
        public bool PersonT { get; set; }
        public bool PersonO { get; set; }
        public bool LoggedState
        {
            get { return _state; }
            set
            {
                _state = value;
                OnChanged();
            }
        }
        private static Logged _instance;
        private bool _state;
        private Logged() { }
        private void OnChanged()
        {
            Changed?.Invoke(this, EventArgs.Empty);
        }
    }
}
