using System;

namespace SportsUpdates
{
    class Program
    {
        static void Main(string[] args)
        {
            Publisher football = new Publisher("football");
            Publisher baseball = new Publisher("baseball");
            Publisher soccer = new Publisher("soccer");

            Subscriber footballfan = new Subscriber("footballfan");
            Subscriber baseballfan = new Subscriber("baseballfan");
            Subscriber soccerfan = new Subscriber("soccerfan");
            Subscriber fbfan = new Subscriber("fbfan");
            Subscriber sbfan = new Subscriber("sbfan");
            Subscriber fsfan = new Subscriber("fsfan");
            Subscriber allsportsfan = new Subscriber("allsportsfan");
            Subscriber felix = new Subscriber("Felix Football");
            Subscriber betty = new Subscriber("Betty Baseball");
            Subscriber stewart = new Subscriber("Stewart Soccer");

            footballfan.subscribe(football);
            baseballfan.subscribe(baseball);
            soccerfan.subscribe(soccer);
            fbfan.subscribe(football);
            fbfan.subscribe(baseball);
            sbfan.subscribe(baseball);
            sbfan.subscribe(soccer);
            fsfan.subscribe(football);
            fsfan.subscribe(soccer);
            felix.subscribe(football);
            betty.subscribe(baseball);
            stewart.subscribe(soccer);
            allsportsfan.subscribe(football);
            allsportsfan.subscribe(baseball);
            allsportsfan.subscribe(soccer);

            football.publish("A football game is occuring");
            baseball.publish("A baseball game is occuring");
            soccer.publish("A soccer game is occuring");

            soccer.publish("The soccer game is over");
            football.publish("The football game is over");
            baseball.publish("The baseball game is over");
        }
    }
}
