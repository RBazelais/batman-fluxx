using System;

namespace batmanFluxx 
{
    public class CreeperCard : Card 
    {
        public CreeperCard(int id, int category_ID, string name): base(id, category_ID, name) 
        {
            this.id = id;
            this.category_ID = category_ID;
            this.name = name;

        }

        public void drawCreeper()
        {
        //if player hand contains 
        }
    }



}