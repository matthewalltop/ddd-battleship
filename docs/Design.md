# Battleship
----

- Two Players
- Game
    - Rounds
    - Players
    - Boards
- Game Board
  - 2 - 10 x 10 grid
    - Target Grid
    - Ocean Grid
  - X-Axis = A-J
  - Y-Axis = 1-10
- Ships
   - Battleship - 4
   - Carrier - 5
   - Cruiser - 3
   - Submarine - 3
   - Destroyer - 2

Players take turns guessing points on the game board.
A hit to an enemy ship places a damage marker corresponding to the guessed point on the ship
A miss places a 'miss' marker on the friendly game board
When the number of damage markers exceeds the size of the ship
The player owning must state 'You sank my `{nameOfShip}`'
The game continues until one player has lost all of their remaining ships


Game = Aggregate
- Players
   - Only two players
   - Players place ships on their own board
   - 
- Boards
   - A board is assigned to a player
   - Only two
- CurrentPlayer
- GameOver
- Winner


Board = Entity
  - Grid - VO
    - GridType - VO
      - Target
      - Ocean
    - GridCells - VO
        - X
        - Y
  - Ships - VO
     - Limited to 5 ships, 1 of each type
     - Ships have a size
     - Ships occupy a number of grid cells equal to their size
     - Ships are placed on the grid by the player
    


Player = Entity
  - Name - 
  - Board - 
  - NumberOfShips -

Ships = Value Objects

