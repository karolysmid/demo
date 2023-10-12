using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class TextData 
{



    const int JODD_HELLO=0, JODD_IMALRIGHT = 1, JODD_TODD = 2, JODD_WHYYOURUN = 3, JODD_RAISESEYEBROWS = 4, JODD_NAME = 5, JODD_SECRET = 6;
   const int PLAYER_HOWAREYOU=0, PLAYER_GENERALKENOBI=1, PLAYER_FAMILIAR = 2, PLAYER_RUN = 3, PLAYER_ITJUSTWORKS = 4, PLAYER_SKYRIM=5, PLAYER_SECRET = 6;

    public static string opening ="Nobody remembers anything before the age of 3. Yet this period is crucial. You try to recall your earliest memories. What you remember is:";
    public static string[] openingbuttons={"A time your mother told you a fairy tale","Playing with toys", "Petting a dog"};
   public static string[] openingdesc = {"You are close to your mother but distant from the rest of the family", "Your parents loved you but lacked the time to properly spend time with you. They gave you dozens of the best toys there are but you were often on your own","Your earliest memory is with the family's dog"};
    
    

    const int HOWAREYOU =0; 
   public static string [] NPCDataSet1={"Hello there! I am the magic Game Director! Isn't game development wonderful?", 
   "I am alright. I have been playing a lot of Starfield recently", "Todd? I am not sure who that is. My name is Jodd","Why do you run?", "*raises eyebrows*I'm not sure", "My name is Jodd Boward, not someone else", "Okay, since you are here, I will tell you the secret. Jump down from the platform to enable 16 times the detail!"};
  public  static string [] answersDataSet1={"How are you?","General Kenobi", "You look familiar...Todd?", "run",
     "it just works?", "you really look like you want to sell me Skyrim", "there must be a secret!"};

     public static int[][] links ={new int[]{PLAYER_HOWAREYOU, JODD_IMALRIGHT}, new int[]{PLAYER_GENERALKENOBI,JODD_RAISESEYEBROWS}, };

    public static int[] state1_NPC_01 = {JODD_IMALRIGHT,JODD_HELLO,JODD_TODD,JODD_RAISESEYEBROWS, JODD_WHYYOURUN};
    public static int[] state1_NPC_02 = {JODD_NAME,JODD_WHYYOURUN};

   
    public static string [] NPCDataSet2={"Oh hi ", "Let's go eat huh?", "Let's play football", "You're just a chicken, cheep cheep cheep", "cheep cheep cheep"};
    public static string [] answersDataSet2={"Hi there", "No thanks", "In tuxedos?", "Stop", "No"};
   
   
    


}
