# PieceFactory.CreatePawn Method 
 

Creates a new instance of the <a href="T_Snake_Piece">Piece</a> class, initialized as a pawn.

**Namespace:**&nbsp;<a href="N_Snake">Snake</a><br />**Assembly:**&nbsp;Snake (in Snake.dll) Version: 1.0.0

## Syntax

**C#**<br />
``` C#
public Piece CreatePawn(
	Player player
)
```

**VB**<br />
``` VB
Public Function CreatePawn ( 
	player As Player
) As Piece
```

**C++**<br />
``` C++
public:
virtual Piece^ CreatePawn(
	Player^ player
) sealed
```

**F#**<br />
``` F#
abstract CreatePawn : 
        player : Player -> Piece 
override CreatePawn : 
        player : Player -> Piece 
```

**J#**<br />
``` J#
public final Piece CreatePawn(
	Player player
)
```


#### Parameters
&nbsp;<dl><dt>player</dt><dd>Type: <a href="T_Snake_Player">Snake.Player</a><br />The player that owns the piece.</dd></dl>

#### Return Value
Type: <a href="T_Snake_Piece">Piece</a><br />The new pawn piece.

#### Implements
<a href="M_Snake_IPieceFactory_CreatePawn">IPieceFactory.CreatePawn(Player)</a><br />

## See Also


#### Reference
<a href="T_Snake_PieceFactory">PieceFactory Class</a><br /><a href="N_Snake">Snake Namespace</a><br />