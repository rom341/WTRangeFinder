When you launch a program, you will see
![image](https://github.com/rom341/WTRangeFinder/assets/119180627/455bbc0b-b72d-49ab-a879-1625610f66f4)

To use this program correctly, you need to change the "Distance per Cell" value to the number in the bottom right corner of your map in the game.
Then, if you do not see overlay, you need to click on "Show overlay" checkbox. Overlay is visible when it is checked.
Overlay must be cover you minimap in game. If it is not the case - use "Open overlay settings" and point overlay to your minimap. 
The border of the square on the overlay should match the border of the minimap.

When this steps completed, you finaly can use it.
This program can work in 2 states:
1) Automatic detection of point (unstable)
      You place the mark of squad (yellow circle) in the game and click LMB on "Distance" text of overlay (you shoud use 'Alt' button to use cursor) or check the "Detec mark automaticly" checkbox, then program will scan your minimap itself every 5 seconds.
      Your cursor should change to your standart cursor, when it hover text.
      Then overlay text should be changed to one of 
        "Distance: X" what is good
        "Distance: (infinity)" what is bad.

2) Manual pointing
      Click RMB on "Distance" text of overlay
      Then you have around 7 seconde to click LMB and RMB on your map to place 2 points.
      Program will calculate distance between this 2 points and show you a result.

In any case,  If you see "Distance: (infinity)" text, then program cant detect size of one cell ![image](https://github.com/rom341/WTRangeFinder/assets/119180627/4da98acd-9029-43d7-ad25-dd3d40c0d884) You need to check the border of square on overlay, or try on other map
