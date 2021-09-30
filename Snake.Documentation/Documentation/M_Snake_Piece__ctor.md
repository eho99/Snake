# Piece Constructor 
 

Initializes a new instance of the <a href="T_Snake_Piece">Piece</a> class.

**Namespace:**&nbsp;<a href="N_Snake">Snake</a><br />**Assembly:**&nbsp;Snake (in Snake.dll) Version: 1.0.0

## Syntax

**C#**<br />
``` C#
public Piece(
	Player player,
	char symbol,
	IMoveProvider moveProvider
)
```

**VB**<br />
``` VB
Public Sub New ( 
	player As Player,
	symbol As Char,
	moveProvider As IMoveProvider
)
```

**VB Usage**<br />
``` VB Usage
Dim player As Player
Dim symbol As Char
Dim moveProvider As IMoveProvider

Dim instance As New Piece(player, 
	symbol, moveProvider)
```

**C++**<br />
``` C++
public:
Piece(
	Player^ player, 
	wchar_t symbol, 
	IMoveProvider^ moveProvider
)
```

**F#**<br />
``` F#
new : 
        player : Player * 
        symbol : char * 
        moveProvider : IMoveProvider -> Piece
```

**J#**<br />
``` J#
public Piece(
	Player player,
	char symbol,
	IMoveProvider moveProvider
)
```

**JScript**<br />
``` JScript
public function Piece(
	player : Player, 
	symbol : char, 
	moveProvider : IMoveProvider
)
```

**JavaScript**<br />
``` JavaScript
Snake.Piece = function(player, symbol, moveProvider);
```


#### Parameters
&nbsp;<dl><dt>player</dt><dd>Type: <a href="T_Snake_Player">Snake.Player</a><br />The player that owns the piece.</dd><dt>symbol</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.char" target="_blank" rel="noopener noreferrer">System.Char</a><br />The symbol for the piece in algebraic notation.</dd><dt>moveProvider</dt><dd>Type: <a href="T_Snake_IMoveProvider">Snake.IMoveProvider</a><br />The move provider that defines the piece's abilities and range of movement.</dd></dl>

## See Also


#### Reference
<a href="T_Snake_Piece">Piece Class</a><br /><a href="N_Snake">Snake Namespace</a><br />