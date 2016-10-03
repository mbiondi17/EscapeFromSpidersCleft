using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

    public Text text;
    private enum States
    {
        caveMouth, WebWall_0, DarkTunnel, DimlyLitRoom, WebWall_investigate, TorchGlassInvestigate, FindRockSlide, GlassInvestigate, TorchInvestigate, EmptySkeleton, TorchLitRoom, TreasureRoom,
        TrapLever, TreasureChest, TreasureGet, InspectChest, TrapSprung, TrapDisarmed, LeverPulled, WebWall_Burn, OrkRoom, OrkFight, OrkDeath, OrkKill, SpiderCaveFromOrk, SneakingFromOrk,
        AttackingFromOrk, Escape, wellLitTunnel, AttackingFromTunnel, SneakingFromTunnel
    };
    private States myState;

    private bool hasTorch = false;
    private bool litTorch = false;
    private bool hasSword = false;
    private bool hasMagnifyingGlass = false;
    private bool foundTreasure = false;
    private bool trapDisarmed = false;
    private bool removedRockslide = false;

	// Use this for initialization
	void Start () {
        myState = States.caveMouth;
        text.alignment = TextAnchor.UpperCenter;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }


        if (myState == States.caveMouth)
        {
            state_caveMouth();
        }
        else if (myState == States.WebWall_0)
        {
            state_WebWall_0();
        }
        else if (myState == States.WebWall_investigate)
        {
            state_WebWall_investigate();
        }
        else if (myState == States.DarkTunnel)
        {
            state_DarkTunnel();
        }
        else if (myState == States.DimlyLitRoom)
        {
            state_DimlyLitRoom();
        }
        else if (myState == States.TorchGlassInvestigate)
        {
            state_TorchGlassInvestigate();
        }
        else if (myState == States.GlassInvestigate)
        {
            state_GlassInvestigate();
        }
        else if (myState == States.TorchInvestigate)
        {
            state_TorchInvestigate();
        }
        else if (myState == States.EmptySkeleton)
        {
            state_EmptySkeleton();
        }
        else if (myState == States.TorchLitRoom)
        {
            state_TorchLitRoom();
        }
        else if (myState == States.FindRockSlide)
        {
            state_FindRockSlide();
        }
        else if (myState == States.TreasureRoom) 
        {
            state_TreasureRoom();
        }
        else if (myState == States.TreasureChest)
        {
            state_TreasureChest();
        }
        else if (myState == States.InspectChest)
        {
            state_InspectChest();
        }
        else if (myState == States.TrapSprung)
        {
            state_TrapSprung();
        }
        else if (myState == States.TrapLever)
        {
            state_TrapLever();
        }
        else if (myState == States.TrapDisarmed)
        {
            state_TrapDisarmed();
        }
        else if (myState == States.TreasureGet)
        {
            state_TreasureGet();
        }
        else if (myState == States.LeverPulled)
        {
            state_LeverPulled();
        }
        else if (myState == States.WebWall_Burn) 
        {
            state_WebWall_Burn();
        }
        else if (myState == States.OrkRoom)
        {
            state_OrkRoom();
        }
        else if (myState == States.OrkFight)
        {
            state_OrkFight();
        }
        else if (myState == States.OrkDeath)
        {
            state_OrkDeath();
        }
        else if (myState == States.OrkKill)
        {
            state_OrkKill();
        }
        else if (myState == States.SpiderCaveFromOrk)
        {
            state_SpiderCaveFromOrk();
        }
        else if (myState == States.SneakingFromOrk)
        {
            state_SneakingFromOrk();
        }
        else if (myState == States.AttackingFromOrk)
        {
            state_AttackingFromOrk();
        }
        else if (myState == States.wellLitTunnel)
        {
            state_WellLitTunnel();
        }
        else if (myState == States.AttackingFromTunnel)
        {
            state_AttackingFromTunnel();
        }
        else if (myState == States.SneakingFromTunnel)
        {
            state_SneakingFromTunnel();
        }
        else if (myState == States.Escape)
        {
            state_Escape();
        }

    }

    void state_caveMouth()
    {
        text.text = "It is dark, and the air wet. Your hands graze the walls of the cave as you grasp your way around another corner. " +
            "You hear something skitter across rock. The echoing of each sound off the cave walls makes the judgment of distance " +
            "difficult. You can barely see, but your eyes can make out three paths diverging in front of you. They are, for all " +
            "you can tell, utterly indistinguishable from each other.\n\n" +

            "L to take Left path, M to take Middle path, R to take Right path";
        if (Input.GetKeyDown(KeyCode.L) && !litTorch)
        {
            myState = States.WebWall_0;
        }

        else if (Input.GetKeyDown(KeyCode.L) && litTorch)
        {
            myState = States.WebWall_Burn;
        }

        else if (Input.GetKeyDown(KeyCode.M) && !litTorch)
        {
            myState = States.DarkTunnel;
        }

        else if (Input.GetKeyDown(KeyCode.M) && litTorch)
        {
            myState = States.wellLitTunnel;
        }

        else if (Input.GetKeyDown(KeyCode.R) && !litTorch)
        {
            myState = States.DimlyLitRoom;
        }
        else if (Input.GetKeyDown(KeyCode.R) && litTorch)
        {
            myState = States.TorchLitRoom;
        }
    }

    void state_WebWall_0()
    {

        text.text = "You huff a deep breath and head down the left path. You don't get very far before the hand you use for guidance " +
                    "comes in contact with something thick and sticky. A spider web. Wonderful. You pull back your hand slowly and " + 
                    "dislodge it. \n\n" + 
                    
                    "I to Investigate the web, R to Return to the cave's mouth";
        if (Input.GetKeyDown(KeyCode.I))
        {
            myState = States.WebWall_investigate;
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.caveMouth;
        }
    }

    void state_WebWall_investigate()
    {
        text.text = "It's too dark to see how far the web stretches. However, the air here is dry, and you know that spider web melts " +
                    "on contact with fire. If only you had a torch or something...\n\n" +

                    "R to Return to the cave's mouth";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.caveMouth;
        }
    }

    void state_WebWall_Burn()
    {
        text.text = "You find yourself face-to-face with an enormous web. In the torchlight, you can see that the webbing continues for " + 
                    "10, maybe 15 feet. You bring the torch close to a small section and, sure enough, it flares up and melts away. \n\n" + 
                    
                    "B to Burn the web, R to Return to the mouth of the cave.";

        if (Input.GetKeyDown(KeyCode.B))
        {
            myState = States.OrkRoom;
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.caveMouth;
        }
    }

    void state_OrkRoom()
    {
        text.text = "You pick your way over the remains of the enormous web, shoes sticking to the melted silk. You emerge into a cavernous " +
                    "room with stalactites reaching almost to your face. In the light of your torch, you spy another skeleton, this one broader " +
                    "then the previous, and covered in plate armor. By his side rests a sword, plain but still sturdy.\n\n" +

                    "S to take the Sword, I to Investigate, R to Return to the cave mouth";

        if (Input.GetKeyDown(KeyCode.S))
        {
            hasSword = true;
            myState = States.OrkFight;
        }
        else if (Input.GetKeyDown(KeyCode.I))
        {
            myState = States.OrkDeath;
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.caveMouth;
        }
    }

    void state_OrkFight()
    {
        text.text = "No sooner have you picked up the sword and turned around then you find yourself face-to-face with a hideous creature. " +
                    "It is humanoid in form, but its skin is a sickening gray, and it stands far larger and broader than any man... an Orc. " +
                    "You expect it to shriek, but it simply stalks forward, raising its hooked sword above its head in preparation to strike... \n\n" +

                    "R to Run away, F to stand and Fight the Orc";

        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.OrkDeath;
        }
        else if (Input.GetKeyDown(KeyCode.F))
        {
            myState = States.OrkKill;
        }
    }

    void state_OrkDeath()
    {
        text.text = "The ghastly visage of an Orc staring you down, weapon raised, terrifies you. You turn and run, but in the slick remains of the burned web, " + 
                    "you fall to the ground. Your breath comes in gasps as you hear the Orc's footsteps halt. Suddenly, an explosion of pain " + 
                    "erupts from your back, and then you feel nothing. Your eyes dim, and the world fades to nothingness. \n GAME OVER \n\n" + 
            
                    "Press R to Restart";

        if (Input.GetKeyDown(KeyCode.R))
        {
            hasTorch = false;
            litTorch = false;
            hasSword = false;
            hasMagnifyingGlass = false;
            foundTreasure = false;
            trapDisarmed = false;
            removedRockslide = false;

            myState = States.caveMouth;
        }
    }

    void state_OrkKill()
    {
        text.text = "The Orc swings his sword, but you turn aside and the blade strikes harmlessly agains the gold and jewels in your backpack. Using the weight on " +
                    "your back, you shove against the Orc with all your might, and he falls over. As he makes to cut at you again, you plunge the sword into his torso, " +
                    "and black blood pours out. He roars in fury, and strikes again. Again you block the blow with your backpack, and this time your blade finds his throat. \n\n" +

                    "R to Return to the cave's mouth, F to press Forward";

        if (Input.GetKeyDown(KeyCode.R)) 
        {
            myState = States.caveMouth;
        }
        else if (Input.GetKeyDown(KeyCode.F))
        {
            myState = States.SpiderCaveFromOrk;
        }
    }

    void state_SpiderCaveFromOrk()
    {
        text.text = "You move forward through another narrow tunnel, torch held aloft. The tunnel starts to widen, and you hear a rhythmic clicking ahead. You set the torch down. " +
                    "As you creep slowly forward, you see a room open up before you. There is light filtering from a tunnel across the room, but in front of that tunnel stands an " +
                    "unbelievably large arachnid. It hasn't noticed you yet, but your heart is racing. There's no turning back now. \n\n" +

                    "S to Sneak around the spider, A to Attack it";

        if (Input.GetKeyDown(KeyCode.S))
        {
            myState = States.SneakingFromOrk;
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            myState = States.AttackingFromOrk;
        }
        
    }

    void state_SneakingFromOrk()
    {
        text.text = "You creep out of the narrow tunnel slowly, and keep to the very edge of the cave as you circle toward the exit. You are very " +
                    "near to the exit now, and you begin to feel the warmth from the sunlight. In your glee, you don't see the skeleton in front of " + 
                    "you. Your foot lands on its arm with a sickening CRUNCH. Before you even see the spider turn around, its fangs grip you and split you apart as you wail in agony. \n " + 
                    
                    "GAME OVER \n\n" + 
            
                    "Press R to Restart";

        if (Input.GetKeyDown(KeyCode.R))
        {
            hasTorch = false;
            litTorch = false;
            hasSword = false;
            hasMagnifyingGlass = false;
            foundTreasure = false;
            trapDisarmed = false;
            removedRockslide = false;

            myState = States.caveMouth;
        }
    }

    void state_AttackingFromOrk()
    {
        text.text = "Emboldened by the sight of the exit, you take your torch back up and charge the monster. The spider is caught off guard. It rears back " + 
                    "from the harsh light of the torch, and scrambles for you with its front legs. You avoid its groping claws, and thrust your sword into its " + 
                    "underbelly, then step forward and pierce its throat. The creature falls to the ground and curls up, unmoving. Covered in spider blood, you turn towards the glowing exit. \n\n" +

                    "E to Escape from Spider's Cleft";

        if (Input.GetKeyDown(KeyCode.E))
        {
            myState = States.Escape;
        }
    }

    void state_DarkTunnel()
    {
        text.text = "As you set off on the middle path, you are immediately enveloped in was seems an almost supernatural darkness." +
                    "You are unable to see even your own feet. Your breath echoes off the walls, joined by a small skittering noise " +
                    "from somewhere farther down the tunnel, and a slow, rythmic thumping...\n\n" +
                    
                    "R to Return to the cave's mouth";

        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.caveMouth;
        }
    }

    void state_WellLitTunnel()
    {
        text.text = "The center hallway, once dark, is now brightly illuminated by your torch, and you can see clearly. This path is arrow-straight, " +
                    "and you follow it for only half a minute before it abruptly opens into an enormous cavern. At the opposite end, you see the outline " +
                    "of an enormous figure with many legs. You set the torch down, and hope it didn't see you...\n\n" +

                    "A to Attack the creature, S to Sneak by it";

        if (Input.GetKeyDown(KeyCode.A))
        {
            myState = States.AttackingFromTunnel;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            myState = States.SneakingFromTunnel;
        }
    }

    void state_AttackingFromTunnel()
    {
        if(hasSword)
        {
            text.text = "You pick up the torch, and rush the spider. As you approach, it reaches for you " + 
                        "with its front legs. You hack at the exposed limbs with your sword, and remove one completely. Then the spider lunges forward, " +
                        "shoving you under its body with its head. Then, the spider is on you. As it crushes you beneath " + 
                        "its weight, your last sight is of the salvation that may have been... \n GAME OVER \n\n Press R to Restart";
        }
        else 
        {
            text.text = "You pick up the torch, and rush the spider. As you approach, it reaches for you " + 
                        "with its front legs. You wish you had something with which to defend yourself. Then the spider lunges forward, " +
                        "shoving you under its body with its head. Then, the spider is on you. As it crushes you beneath " + 
                        "its weight, your last sight is of the salvation that may have been... \n GAME OVER \n\n Press R to Restart";
        }
        
        if (Input.GetKeyDown(KeyCode.R))
        {
            hasTorch = false;
            litTorch = false;
            hasSword = false;
            hasMagnifyingGlass = false;
            foundTreasure = false;
            trapDisarmed = false;
            removedRockslide = false;

            myState = States.caveMouth;
        }
        
    }

    void state_SneakingFromTunnel()
    {
        text.text = "You decide to sneak around the spider. You smother the torch and begin to creep forward. You spy some loose rocks on the cave " +
                    "floor and have an idea! You scoop them up and throw one. The spider screeches and skitters over to the noise, and you move forward. " +
                    "you continue this all the way around the cavernous room, until finally you are by the exit! You throw one last rock down the tunnel " +
                    "through which you entered.\n\n" +

                    "Press E to Escape from Spider's Cleft";

        if (Input.GetKeyDown(KeyCode.E))
        {
            myState = States.Escape;
        }
    }

    void state_DimlyLitRoom()
    {
        if (!hasMagnifyingGlass || !hasTorch)
        {
            text.text = "The path to the right is faintly illuminated by an unseen source. You creep slowly down the passage, ears alert for " +
                        "any unexpected sound. You emerge in a small chamber where the cave ceiling has partially collapsed, and sunlight filters " +
                        "through the hole. The halo of light illuminates a human skeleton, perhaps once a lost traveler like yourself. \n\n" +

                        "S to investigate the Skeleton, I to Investigate the room, R to Return.";

        }

        else
        {
            text.text = "As you look toward the shaft of light coming through the roof, you realize that now you have a way to light your path! " + 
                        "You thank Eru briefly, and then begin to plan your next move... \n\n" + 
                        
                        "L to Light the torch, S to investigate the Skeleton, I to Investigate the room, R to Return";
        }
        
        if(Input.GetKeyDown(KeyCode.R)) {
            myState = States.caveMouth;
        }
        else if (Input.GetKeyDown(KeyCode.S) && !hasTorch && !hasMagnifyingGlass) 
        {
            myState = States.TorchGlassInvestigate;
        }
        else if (Input.GetKeyDown(KeyCode.S) && !hasTorch && hasMagnifyingGlass)
        {
            myState = States.TorchInvestigate;
        }
        else if (Input.GetKeyDown(KeyCode.S) && hasTorch && !hasMagnifyingGlass)
        {
            myState = States.GlassInvestigate;
        }
        else if (Input.GetKeyDown(KeyCode.S) && hasTorch && hasMagnifyingGlass)
        {
            myState = States.EmptySkeleton;
        }
        else if(Input.GetKeyDown(KeyCode.I)) {
            myState = States.FindRockSlide;
        }
        else if (Input.GetKeyDown(KeyCode.L) && hasTorch && hasMagnifyingGlass)
        {
            litTorch = true;
            myState = States.TorchLitRoom;
        }
    }

    void state_TorchGlassInvestigate()
    {
        text.text = "You approach the skeleton. You can see that it was clearly humanoid in life, but shorter than you would expect of a man. " +
                    "Did some poor child venture into this place unwittingly? You say a quick prayer, and then see the torch and shard of glass" +
                    "that lay by the remains. \n\n" +

                    "T to take the Torch, G to take the Glass, R to Return to the room at large.";

        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.DimlyLitRoom;
        }
        else if (Input.GetKeyDown(KeyCode.T)) 
        {
            hasTorch = true;
            myState = States.GlassInvestigate;
        }
        else if (Input.GetKeyDown(KeyCode.G))
        {
            hasMagnifyingGlass = true;
            myState = States.TorchInvestigate;
        }

    }

    void state_TorchInvestigate()
    {
        text.text = "You approach the skeleton. You can see that it was clearly humanoid in life, but shorter than you would expect of a man. " +
                    "Did some poor child venture into this place unwittingly? You say a quick prayer, and then see the torch and shard of glass" +
                    "that lay by the remains. \n\n" +

                    "T to take the Torch, R to Return to the room at large.";

        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.DimlyLitRoom;
        }
        else if (Input.GetKeyDown(KeyCode.T))
        {
            hasTorch = true;
            myState = States.DimlyLitRoom;
        }
    }

    void state_GlassInvestigate()
    {
        text.text = "You approach the skeleton. You can see that it was clearly humanoid in life, but shorter than you would expect of a man. " +
                    "Did some poor child venture into this place unwittingly? You say a quick prayer, and then see the torch and shard of glass" +
                    "that lay by the remains. \n\n" +

                    "G to take the Glass, R to Return to the room at large.";

        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.DimlyLitRoom;
        }
        else if (Input.GetKeyDown(KeyCode.G))
        {
            hasMagnifyingGlass = true;
            myState = States.DimlyLitRoom;
        }
    }

    void state_EmptySkeleton()
    {
        text.text = "You peer again at the skeleton after taking everything of use. It appears undamaged, as though whoever it belonged to " +
                    "did not die violently. Though the skeleton is unclothed, as you look closer, you notice a small ring dangling from a " +
                    "chain about its neck. You reach out for it, but suddenly feel a massive presence of evil, and recoil back. You breathe heavily. \n\n" +

                    "R to Return to the room.";
        if (Input.GetKeyDown(KeyCode.R) && !litTorch)
        {
            myState = States.DimlyLitRoom;
        }
        else if (Input.GetKeyDown(KeyCode.R) && litTorch)
        {
            myState = States.TorchLitRoom;
        }
    }

    void state_TorchLitRoom()
    {
        if (removedRockslide)
        {
            text.text = "Finally, you have a lit torch! Now, let's see what the rest of this cave has to offer! \n\n" +

                    "S to investigate the Skeleton, H to go to the hidden room, R to Return.";
        }

        else {
            text.text = "Finally, you have a lit torch! Now, let's see what the rest of this cave has to offer! \n\n" +
        
                    "S to investigate the Skeleton, I to Investigate the room, R to Return.";
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.caveMouth;
        }
        else if (Input.GetKeyDown(KeyCode.S) && hasTorch && hasMagnifyingGlass) //shouldn't be a case where they DON'T have these, but just in case.
        {
            myState = States.EmptySkeleton;
        }
        else if (Input.GetKeyDown(KeyCode.I))
        {
            myState = States.FindRockSlide;
        }
        else if(Input.GetKeyDown(KeyCode.H) && removedRockslide) 
        {
            myState = States.TreasureRoom;
        }

    }

    void state_FindRockSlide()
    {
        text.text = "You circle the room, looking for anything else of interest. At the end of the room opposite the tunnel through which you " +
                    "entered, you notice that the wall looks peculiar. You get closer, and realize that part of the wall is actually a rock slide, " +
                    "and seems to be blocking another tunnel. \n\n" +

                    "H to hit the rock wall, R to Return to the room at large.";

        if (Input.GetKeyDown(KeyCode.R) && !litTorch)
        {
            myState = States.DimlyLitRoom;
        }
        else if (Input.GetKeyDown(KeyCode.R) && litTorch)
        {
            myState = States.TorchLitRoom;
        }
        else if (Input.GetKeyDown(KeyCode.H))
        {
            myState = States.TreasureRoom;
        }
    }

    void state_TreasureRoom()
    {
        if (!removedRockslide)
        {
            text.text = "You pound on the impeding rocks for what seems like ages as they slowly tumble to the floor, until you see a weak point and thrust against " +
                    "it with your whole body. The rocks give way, revealing a passage into a room beyond. You venture in, and see a large chest in " +
                    "the center of the room. \n\n" +

                    "T to approach the Chest, I to Investigate the Room, R to Return to the last room.";
        }
        else
        {
            text.text = "The treasure room expands before you. A large mahogany chest sits invitingly in the center of the room, and the walls here are " + 
                        "smoother than anywhere else you've been in the cave. Coins of spectacular and varied colors cover the floor, and gems adorn small " + 
                        "divets in the walls. \n\n" +

                        "T to approach the Chest, I to Investigate the Room, R to Return to the last room.";

        }
        if (Input.GetKeyDown(KeyCode.R) && !litTorch)
        {
            removedRockslide = true;
            myState = States.DimlyLitRoom;
        }
        else if (Input.GetKeyDown(KeyCode.R) && litTorch)
        {
            removedRockslide = true;
            myState = States.TorchLitRoom;
        }
        else if (Input.GetKeyDown(KeyCode.T))
        {
            removedRockslide = true;
            myState = States.TreasureChest;
        }
        else if (Input.GetKeyDown(KeyCode.I) && !trapDisarmed) 
        {
            removedRockslide = true;
            myState = States.TrapLever;
        }
        else if (Input.GetKeyDown(KeyCode.I) && trapDisarmed)
        {
            removedRockslide = true;
            myState = States.LeverPulled;
        }
    }

    void state_TreasureChest()
    {

        if (!trapDisarmed)
        {
            text.text = "You approach the treasure chest. The musky smell of ancient wood fills your nostrils. You run your hand along the lid, and draw your finger away, " +
                        "leaving a clear trail in the thick dust covering the chest. It seems no one has been here for a long while. You notice that the entire room is quite " +
                        "barren of cobwebs, even though every other room has been littered with them. \n\n" +

                        "O to Open the chest, I to Investigate it closely, R to Return to the room.";
        }
        else
        {
            text.text = "You approach the treasure chest. The musky smell of ancient wood fills your nostrils. You run your hand along the lid, and draw your finger away, " +
                        "leaving a clear trail in the thick dust covering the chest. It seems no one has been here for a long while. You notice that the entire room is quite " +
                        "barren of cobwebs, even though every other room has been littered with them. \n\n" +

                        "O to Open the chest, R to Return to the room.";
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.TreasureRoom;
        }
        else if (Input.GetKeyDown(KeyCode.I) && !trapDisarmed)
        {
            myState = States.InspectChest;
        }
        else if (Input.GetKeyDown(KeyCode.O) && !trapDisarmed)
        {
            myState = States.TrapSprung;
        }
        else if (Input.GetKeyDown(KeyCode.O) && trapDisarmed)
        {
            myState = States.TreasureGet;
        }
    }

    void state_InspectChest()
    {
        text.text = "On closer investigation, you notice a chain attached to the chest's latch that diappears into the floor. You recognize " +
                    "it immediately as a simple trap. You look around, and see a lever on the wall that may disarm it. You also spy a small " +
                    "hole in the wall directly in front of you, probably to dispense whatever punishment awaited someone foolhardy enough " +
                    "to blindly open the chest.\n\n" +

                    "L to approach the Lever, R to return to the room";

        if (Input.GetKeyDown(KeyCode.L))
        {
            myState = States.TrapLever;
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.TreasureRoom;
        }
    }

    void state_TrapSprung()
    {
        text.text = "You go for the latch hastily, with a gleam in your eye. Too late you notice the chain that disappears into the floor " +
                    "snap taut. A spear fires from a slit in the wall you hadn't seen, and buries itself deep in your chest. Blood stains " + 
                    "your tunic and drips onto the floor. As your eyes lose focus, you fall to your knees. You see the lever that would have " + 
                    "disarmed the trap... Just before your eyes shut forever.\n" +

                    "GAME OVER\n\n" +

                    "Press R to Restart";

        if (Input.GetKeyDown(KeyCode.R))
        {
            hasTorch = false;
            litTorch = false;
            hasSword = false;
            hasMagnifyingGlass = false;
            foundTreasure = false;
            trapDisarmed = false;
            removedRockslide = false;

            myState = States.caveMouth;
        }
    }

    void state_TrapLever()
    {
        text.text = "You walk towards the back wall of the cave, and approach a lever. It is a plain lever, and would blend in well with the cave walls, " + 
                    "were it not for the years of rust caked onto it. \n\n" + 
                    
                    "D to Disarm the trap, R to Return to the room";

        if (Input.GetKeyDown(KeyCode.D))
        {
            myState = States.TrapDisarmed;
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.TreasureRoom;
        }
    }

    void state_TrapDisarmed()
    {
        text.text = "You hear a solid clicking sound come from the hole in the wall. A hearbeat later, a spear fires across the room into the " +
                    "stone on the other side. The chain that was connected to the latch on the chest drops to the floor, and all is silent.\n\n" +

                    "R to Return to the room, T to approach the Treasure chest.";
        trapDisarmed = true;
        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.TreasureRoom;
        }
        else if (Input.GetKeyDown(KeyCode.T))
        {
            myState = States.TreasureChest;
        }
    }

    void state_TreasureGet()
    {
        if(!foundTreasure) {
            text.text = "You lift the lid of the chest, carefully at first, listening to make sure the trap is really disarmed. Hearing nothing, " + 
                        "you abandon caution and throw open the chest. The sight that meets your eyes is glorious. Mountains of gold, so much that " + 
                        "counting it would dimish its glory. Gems as large as your hand, in every color and shape imaginable. You remove your pack and " + 
                        "begin to fill it to the brim with everything that will fit.\n\n" + 
                        
                        "R to return to the room";
        }
        else
        {
            text.text = "You lift the lid of the chest once more to behold the glory inside. A slight sadness comes over you that you cannot carry more, " +
                        "and you vow to return again one day to collect what remains... \n\n" +

                        "R to return to the room";
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            foundTreasure = true;
            myState = States.TreasureRoom;
        }
    }

    void state_LeverPulled()
    {
        text.text = "The lever has already been pulled, and there seems to be nothing else of interest in the room... That is, except for the massive piles " +
                    "of treasure and the amazing chest ahead.\n\n" +

                    "R to Return to the room";

        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.TreasureRoom;
        }
    }

    void state_Escape()
    {
        text.text = "You dash through the tunnel towards the sunlight. You hear the spider screech behind you, but it it too wide to fit through the narrow passage. " +
                    "You burst into the daylight and feel the warmth of the sun on your skin. A smile spreads across your face. How long you spent climbing that " +
                    "mountain, you do not know. But the sight that greets you from the summit is grand and beautiful. Now, the real adventure awaits! \n\n" +
                     //How it could have ended: And you see... Cthulu. And he eats yo ass. Fuck off, life is meaningless and everyone dies.\n\n"

                    "Thanks for playing! Press R to Replay or Esc to Exit!";

        if (Input.GetKeyDown(KeyCode.R))
        {
            hasTorch = false;
            litTorch = false;
            hasSword = false;
            hasMagnifyingGlass = false;
            foundTreasure = false;
            trapDisarmed = false;
            removedRockslide = false;

            myState = States.caveMouth;
        }
    }
}
