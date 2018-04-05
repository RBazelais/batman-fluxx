using System;
using System.Collections.Generic;

namespace batmanFluxx 
{
    public class GoalCard : Card 
    {
        public GoalCard(int id, int category_ID, string name): base(id, category_ID, name) 
        {
            this.id = id;
            this.category_ID = category_ID;
            this.name = name;
        }

        public void WinCheck(List<Card> table)
        {
            //is this a villian or hero win? (aka is this goal 1-16 or higher)
//if 101-16
//condition of keepers id on table match and NO TABLE contains villain ids

	//if 101(to the bat cave) 
// batcave and Robin OR batman
	//if 102(those wonderful toys)
// cuffs AND computer || cuffs and mobile || cuffs and batarang || comuter and mobile || computer and batanrang || mobile and batarang
	//if 103(I'll take care of that, sir)
// alfred AND batman || alfred AND BW
	//if 104(Bat-fam)
// man AND girl || man AND boy || boy AND girl

//if 117 - 123
//check condition


//if 124 (Rogue's gallery)
// table has 4+ neg id cards

//if 125 (Crimespree)
// table has batsignal AND ALL tables added together have 5+ neg ids

//if 126 (bank robbery)
// table has batsignal AND bank AND one neg

//if 127 (Sirens)
// table has (PI and HQ) or (PI and CW) or (HQ and CW) or (all three)

//if 128 (backed into a corner)
// table has robin AND 3+ neg ids

        }
    }
}