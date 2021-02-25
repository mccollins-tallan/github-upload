using System;
using System.Collections.Generic;
using System.Text;

namespace SportsUpdates
{
    class Publisher
    {

        private string sport;
        public EventHandler<string> sportsUpdate;

        public string getSport()
        {
            return sport;
        }

        public Publisher(string sport)
        {
            this.sport = sport;
        }

        public void publish(string update)
        {
            onUpdate(update);
            UpdateLogger.getInstance().LogUpdate(update, this);
        }

        private void onUpdate(string message)
        {
            sportsUpdate?.Invoke(this, message);
        }
    }
}
