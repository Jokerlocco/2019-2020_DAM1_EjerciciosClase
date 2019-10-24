//DAVID BERENGUER ANTON
// Boolean
using System;

class ContactWithBooleans
{
    static void Main()
    {
        bool gameFinished = false;
        int lives = 8;
        int level = 99;

        if(lives > 0 && level <= 100)
        {
            gameFinished = true;
        }
        else
        {
            gameFinished = false;
        }
        

        gameFinished = 
            lives > 0 && level <= 100 ? true 
            : false;
        
        //  --------------
        
        if(lives > 0 && level <= 100)
        {
            gameFinished = true;
        }
        

        gameFinished = lives > 0 && level <= 100;
    }
}
