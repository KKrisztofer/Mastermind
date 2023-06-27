# Mastermind Játék

A **Mastermind** egy logikai társasjáték, amelyben egy játékosnak el kell találnia a másik játékos által előre kiválasztott színsorozatot. Az én megvalósításomban ez a színsorozat random generált színekből áll. Tehát ebben az esetben ez egy egyszemélyes játék.

## Játékmenet:

1. A program véletlenszerűen generál egy négy színből álló színsorozatot, amit a játékosnak kell kitalálnia.
2. A játékos megad egy négy színből álló tippet.
3. A program visszajelzést ad a tipp alapján:
   - Ha a játékos tippje megegyezik a generált színekkel, a játék véget ér és nyert.
   - Ha a játékos tippje tartalmaz olyan színeket, amelyek megtalálhatóak a generált színsorozatban, de nem a megfelelő helyen vannak, a játékos fehér visszajelzést kap.
   - Ha a játékos tippje tartalmaz olyan színeket, amelyek megtalálhatóak a generált színsorozatban és a megfelelő helyen vannak, a játékos fekete visszajelzést kap.
4. A játék addig folytatódik, amíg a játékos el nem találja a színsorozatot vagy a próbálkozások száma eléri a 10-et.

# Mastermind Game

Mastermind is a logic board game where one player must guess the color sequence preselected by another player. In my implementation, this color sequence is randomly generated. It is a single-player game.

## Gameplay:

1. The program randomly generates a color sequence consisting of four colors, which the player has to guess.
2. The player provides a guess consisting of four colors.
3. The program provides feedback based on the guess:
   - If the player's guess matches the generated colors, the game ends and the player wins.
   - If the player's guess contains colors that are present in the generated color sequence but are not in the correct position, the player receives a white feedback.
   - If the player's guess contains colors that are present in the generated color sequence and are in the correct position, the player receives a black feedback.
4. The game continues until the player correctly guesses the color sequence or the number of attempts reaches 10.
