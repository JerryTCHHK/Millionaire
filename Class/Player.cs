using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Millionaire.Enum;

namespace Millionaire.Class {

    public partial class Player {

        public Boolean used5050;

        public Boolean usedAskAudience;

        public Boolean usedPhoneCall;

        public int currentLadderLevel;

        public int takeOutPriceLevel ;

        public int safePriceLevel;

        public PlayerStatus status; 


        public Player() {

            used5050 = false;

            usedAskAudience = false;

            usedPhoneCall = false;

            currentLadderLevel = 1; 

            takeOutPriceLevel = 0 ;

            safePriceLevel = 0;

            this.status = PlayerStatus.IN; 


        }


    }
}
