
# tasks by person
- suzanne
  - assets (should be done by tomorrow hopefully) 
- ibrahim
    - level layouts, platform locations (essentially just the map)
- winnie
    - implement death upon contact with the eyes + win screen if necessary
- daniel
  - find out how to give the player a key : boxes on trigger change state to open, give player key


tasks for later : sfx , ui elements , put in and implement assets




# Notes (08/07/24)
- Suzanne can do art

- platforms = haunted house theme? (try not to get jumpscared)
  
[ suzanne brainstorming ]
- we could keep the storytelling from the session with Courtney --> you are the detectives in this version exploring her house
       - trying not to get jumpscared by the eyes?
       - eyes as obstacles
      - WIN if you find and successfully bring back her child (to "safety")

Possibility:
| __o__   ____o______ ___(child)____      |
| __o__    __oo_____oo__    __o__   ____  |
|      ____            __o__o__   __o__   |
| _oo___   ____o__o____        ____o____  |
|      __o__o__       __oo__o____o__      |



# General Task List:
1) Design + Planning
  a) Level Design
  b) UI Design
  c) Plan what assets necessary
3) Assets
4) Code

FIRST: UI that goes away after you press a key, tells you the story and what to avoid
Start on the porch + Forest scene (gloomy) 
Go into the house, have to dodge the eyes
level design --> jump over eyes
get to cage, don't have the key (and no lockpicking materials because video game logic) 
key in separate room
  - | __box__   ____o______ ___(key in box)____      |
    | __o__    __oo_____oo__    __o__   ____  |
    |      ____            __o__o__   __o__   |
    | _oo___   ____o__o____        ____o____  |
    |      __o__o__       __oo__o____o__      |

get the key get the kids and get out.


# Asset Planning:
1) tutorial + story screen "you are detective x, you need to rescue the children of julia potts, who you just arrested (play other game for backstory) use wasd and space to move and avoid the eyes julia potts plucked from her victims.
2) forest + porch assets (most likely will have to be a separate scene) --> figure this out later
    a) 2/3 trees done
4) forest + porch background
5) door
6) house (front)
7) floor tiles
8) cage
9) walls
10) key
11) detective sprites (including animations)
12) child sprites (including animations)
13) Exit + WIN UI
14) Death UI
15) EYES

# Implementation:
1) movement we have : finetune
2) eyes = trigger
3) UI elements we know
4) platforms we know
5) find out how to give the player a key : boxes on trigger change state to open, give player key
6) player interacts with cage by touching it
7) win + restart we can do



# SFX NOTES:
- soundmanager object
- soundmanager script + add as component
- create instance + getset , create audio source (source = GetComponent<audiosource>
- public void PlaySound(AudioClip _sound))
  {
    source.Playoneshot(_sound);
  }

- make parent to the soundmanager
- bg music play on awake and loop
