# Piece.Player Property 
 

Gets the player that owns the piece.

**Namespace:**&nbsp;<a href="N_Snake">Snake</a><br />**Assembly:**&nbsp;Snake (in Snake.dll) Version: 1.0.0

## Syntax

**C#**<br />
``` C#
public Player Player { get; }
```

**VB**<br />
``` VB
Public ReadOnly Property Player As Player
	Get
```

**VB Usage**<br />
``` VB Usage
Dim instance As Piece
Dim value As Player

value = instance.Player

```

**C++**<br />
``` C++
public:
property Player^ Player {
	Player^ get ();
}
```

**F#**<br />
``` F#
member Player : Player with get

```

**J#**<br />
``` J#
/** @property */
public Player get_Player()

```

**JScript**<br />
``` JScript
function get Player () : Player

```

**JavaScript**<br />
``` JavaScript
function get_Player();

```


#### Property Value
Type: <a href="T_Snake_Player">Player</a><br />The player that owns the piece.

## See Also


#### Reference
<a href="T_Snake_Piece">Piece Class</a><br /><a href="N_Snake">Snake Namespace</a><br />