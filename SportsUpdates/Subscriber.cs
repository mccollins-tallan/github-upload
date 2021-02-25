using System;
using System.Collections.Generic;
using System.Text;

namespace SportsUpdates
{
    class Subscriber
    {
        private string name;

        public string getName()
        {
            return name;
        }

        public Subscriber(string name)
        {
            this.name = name;
        }

        public void subscribe(Publisher p)
        {
            p.sportsUpdate += handleUpdate;
            UpdateLogger.getInstance().LogNewSubscription(p, this);
        }

        private void handleUpdate(object sender, string message)
        {
            UpdateLogger.getInstance().LogReception(this);
        }
    }
}
