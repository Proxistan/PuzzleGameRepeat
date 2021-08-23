ReadMe For PuzzleWuzzleBuzzle

3rd Party Assets/sources - 
1. Meshtint free tile map mega toon series- used some color pallets and a star image to convert box into star box - https://assetstore.unity.com/packages/3d/environments/meshtint-free-tile-map-mega-toon-series-153619
2. Meshtint free Boximon fiery mega toon series - used some color pallets and trap image - https://assetstore.unity.com/packages/3d/characters/meshtint-free-boximon-fiery-mega-toon-series-153958
3. Retro Games Sound FX - Free sound effects used for buttons etc. - https://assetstore.unity.com/packages/audio/sound-fx/retro-games-sound-fx-27280
4. 5 free background tracks - background track for scenes - https://assetstore.unity.com/packages/audio/music/5-free-background-tracks-67932
5. pressstart.vip background menu image

6. used some guides for tips Jonas Tyroller and Brackeys.
 Brackeys youtube channel : https://www.youtube.com/channel/UCYbK_tjZ2OrIZFBvU6CCMiA
 healthbar sprites and script from brackeys - https://github.com/Brackeys/Health-Bar
 Tyroller youtube channel : https://www.youtube.com/channel/UC_p_9arduPuxM8DHTGIuSOg
 
 7. Everything else was from the unity create with code course or unity itself
 
 Game Description : Puzzle Ball
 Goal : collect star cubes and avoid traps, once star cubes collect move to pill to move to next level.
 
 Difficulties : traps will reduce health on collision
                limited time to complete level
                Falling from platforms would mean death/loss

-------------- Code Taken from Brackeys ------------------

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

    public Slider slider;
    
    public void SetMaxHealth(int health)

    {
        slider.maxValue = health;
        slider.value = health;
    }

    public void SetHealth(int health)
    {
        slider.value = health;
    }


}

 
 
 


