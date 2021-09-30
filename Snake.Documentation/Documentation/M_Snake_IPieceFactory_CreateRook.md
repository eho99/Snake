# IPieceFactory.CreateRook Method 
 

Creates a new instance of the <a href="T_Snake_Piece">Piece</a> class, initialized as a rook.

**Namespace:**&nbsp;<a href="N_Snake">Snake</a><br />**Assembly:**&nbsp;Snake (in Snake.dll) Version: 1.0.0

## Syntax

**C#**<br />
``` C#
Piece CreateRook(
	Player player
)
```

**VB**<br />
``` VB
Function CreateRook ( 
	player As Player
) As Piece
```

**VB Usage**<br />
``` VB Usage
Dim instance As IPieceFactory
Dim player As Player
Dim returnValue As Piece

returnValue = instance.CreateRook(player)
```

**C++**<br />
``` C++
Piece^ CreateRook(
	Player^ player
)
```

**F#**<br />
``` F#
abstract CreateRook : 
        player : Player -> Piece 

```

**J#**<br />
``` J#
Piece CreateRook(
	Player player
)
```

**JScript**<br />
``` JScript
function CreateRook(
	player : Player
) : Piece
```

**JavaScript**<br />
``` JavaScript
function CreateRook(player);
```


#### Parameters
&nbsp;<dl><dt>player</dt><dd>Type: <a href="T_Snake_Player">Snake.Player</a><br />The player that owns the piece.</dd></dl>

#### Return Value
Type: <a href="T_Snake_Piece">Piece</a><br />The new rook piece.

## See Also


#### Reference
<a href="T_Snake_IPieceFactory">IPieceFactory Interface</a><br /><a href="N_Snake">Snake Namespace</a><br />