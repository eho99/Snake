# BoardFactory.Create Method 
 

Creates a new instance of the <a href="T_Snake_Board">Board</a> class.

**Namespace:**&nbsp;<a href="N_Snake">Snake</a><br />**Assembly:**&nbsp;Snake (in Snake.dll) Version: 1.0.0

## Syntax

**C#**<br />
``` C#
public Board Create(
	Player first,
	Player second
)
```

**VB**<br />
``` VB
Public Function Create ( 
	first As Player,
	second As Player
) As Board
```

**C++**<br />
``` C++
public:
virtual Board^ Create(
	Player^ first, 
	Player^ second
) sealed
```

**F#**<br />
``` F#
abstract Create : 
        first : Player * 
        second : Player -> Board 
override Create : 
        first : Player * 
        second : Player -> Board 
```

**J#**<br />
``` J#
public final Board Create(
	Player first,
	Player second
)
```


#### Parameters
&nbsp;<dl><dt>first</dt><dd>Type: <a href="T_Snake_Player">Snake.Player</a><br />The first player.</dd><dt>second</dt><dd>Type: <a href="T_Snake_Player">Snake.Player</a><br />The second player.</dd></dl>

#### Return Value
Type: <a href="T_Snake_Board">Board</a><br />The new board.

#### Implements
<a href="M_Snake_IBoardFactory_Create">IBoardFactory.Create(Player, Player)</a><br />

## See Also


#### Reference
<a href="T_Snake_BoardFactory">BoardFactory Class</a><br /><a href="N_Snake">Snake Namespace</a><br />