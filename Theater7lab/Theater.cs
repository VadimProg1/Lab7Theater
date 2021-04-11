using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theater7lab
{
    class Theater
    {
        Random rand = new Random();
        public int ticketPrice = 100,
            amountOfAds = 0,
            adCost = 1000,
            adAttract = 100,
            amountOfActors = 5,
            theaterCapacity = 2000,
            actorsPopularity = 0,
            levelOfAttendacePerMonth = 1,
            amountOfPlays = 0,
            partOfActorsWhoWorksForMinSalary = 0,
            actorsSalary = 15000,
            budgetOfTheater = 50000,
            theaterFinancingPerMonth = 0,
            month = 1;


        public void MonthStep()
        {
            FindBudgetOfTheater();
            BuyAdOrNotAd();
            levelOfAttendacePerMonth = FindLevelOfAttendace();
            ticketPrice = FindTicketPrice();
            FindAmountOfActors();
            amountOfPlays = FindAmountOfPlays();

            month++;
        }

        public int FindAmountOfPlays()
        {
            int answ = (amountOfActors * levelOfAttendacePerMonth) / (theaterCapacity);
            if (answ >= amountOfPlays && actorsPopularity < 10)
                actorsPopularity++;
            else if (answ < amountOfPlays && actorsPopularity > 1)
                actorsPopularity--;

            if (answ <= 1)
                return 1;
            else if (answ >= 300)
                return 300;
            else
                return answ;
        }

        public void FindAmountOfActors()
        {
            while (budgetOfTheater * 0.7 / (amountOfActors + 1) >= actorsSalary)
            {
                amountOfActors++;
                actorsSalary += 1000;
            }
            while (budgetOfTheater * 0.7 / (amountOfActors + 1) < actorsSalary)
            {
                if (amountOfActors > 5)
                {
                    amountOfActors--;
                }
                actorsSalary -= 1000;
            }
        }

        public int FindTicketPrice()
        {
            int answ = ticketPrice * (levelOfAttendacePerMonth + 200) / theaterCapacity;
            if (answ < 50)
                return 50;
            else
                return answ;
        }
        public int FindLevelOfAttendace()
        {
            int answ = ((adAttract * amountOfAds) + rand.Next(theaterCapacity / ticketPrice, theaterCapacity))
                * actorsPopularity / 10;
            if (answ > theaterCapacity)
                return theaterCapacity;
            else
                return answ;
        }


        public void FindBudgetOfTheater()
        {
            budgetOfTheater += theaterFinancingPerMonth;
            budgetOfTheater -= amountOfAds * adCost;
            budgetOfTheater -= amountOfActors * actorsSalary;
            budgetOfTheater += levelOfAttendacePerMonth * ticketPrice;
        }
        public void BuyAdOrNotAd()
        {
            double percentOfBudgetToAd = 0.1;
            if(amountOfAds * adAttract > theaterCapacity)
            {
                return;
            }
            if ((budgetOfTheater * percentOfBudgetToAd) < (amountOfAds * adCost))
            {
                amountOfAds--;
            }
            else{
                amountOfAds++;
            }
        }

        public void Reset()
        {
            ticketPrice = 100;
            amountOfAds = 0;
            adCost = 1000;
            adAttract = 100;
            amountOfActors = 5;
            theaterCapacity = 2000;
            actorsPopularity = 0;
            levelOfAttendacePerMonth = 1;
            amountOfPlays = 0;
            partOfActorsWhoWorksForMinSalary = 0;
            actorsSalary = 15000;
            budgetOfTheater = 50000;
            theaterFinancingPerMonth = 0;
            month = 0;
        }
    }
}
