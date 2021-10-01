# PieceFactory.CreateBishop Method 
 

Creates a new instance of the <a href="T_Snake_Piece">Piece</a> class, initialized as a bishop.

**Namespace:**&nbsp;<a href="N_Snake">Snake</a><br />**Assembly:**&nbsp;Snake (in Snake.dll) Version: 1.0.0

## Syntax

**C#**<br />
``` C#
public Piece CreateBishop(
	Player player
)
```

**VB**<br />
``` VB
Public Function CreateBishop ( 
	player As Player
) As Piece
```

**C++**<br />
``` C++
public:
virtual Piece^ CreateBishop(
	Player^ player
) sealed
```

**F#**<br />
``` F#
abstract CreateBishop : 
        player : Player -> Piece 
override CreateBishop : 
        player : Player -> Piece 
```

**J#**<br />
``` J#
public final Piece CreateBishop(
	Player player
)
```


#### Parameters
&nbsp;<dl><dt>player</dt><dd>Type: <a href="T_Snake_Player">Snake.Player</a><br />The player that owns the piece.</dd></dl>

#### Return Value
Type: <a href="T_Snake_Piece">Piece</a><br />The new bishop piece.

#### Implements
<a href="M_Snake_IPieceFactory_CreateBishop">IPieceFactory.CreateBishop(Player)</a><br />

## See Also


#### Reference
<a href="T_Snake_PieceFactory">PieceFactory Class</a><br /><a href="N_Snake">Snake Namespace</a><br />