# IPieceFactory.CreateKnight Method 
 

Creates a new instance of the <a href="T_Snake_Piece">Piece</a> class, initialized as a knight.

**Namespace:**&nbsp;<a href="N_Snake">Snake</a><br />**Assembly:**&nbsp;Snake (in Snake.dll) Version: 1.0.0

## Syntax

**C#**<br />
``` C#
Piece CreateKnight(
	Player player
)
```

**VB**<br />
``` VB
Function CreateKnight ( 
	player As Player
) As Piece
```

**C++**<br />
``` C++
Piece^ CreateKnight(
	Player^ player
)
```

**F#**<br />
``` F#
abstract CreateKnight : 
        player : Player -> Piece 

```

**J#**<br />
``` J#
Piece CreateKnight(
	Player player
)
```


#### Parameters
&nbsp;<dl><dt>player</dt><dd>Type: <a href="T_Snake_Player">Snake.Player</a><br />The player that owns the piece.</dd></dl>

#### Return Value
Type: <a href="T_Snake_Piece">Piece</a><br />The new knight piece.

## See Also


#### Reference
<a href="T_Snake_IPieceFactory">IPieceFactory Interface</a><br /><a href="N_Snake">Snake Namespace</a><br />