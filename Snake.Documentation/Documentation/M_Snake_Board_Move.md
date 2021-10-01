# Board.Move Method 
 

Moves a given piece from its current square onto an empty destination square.

**Namespace:**&nbsp;<a href="N_Snake">Snake</a><br />**Assembly:**&nbsp;Snake (in Snake.dll) Version: 1.0.0

## Syntax

**C#**<br />
``` C#
public void Move(
	Piece piece,
	Square square
)
```

**VB**<br />
``` VB
Public Sub Move ( 
	piece As Piece,
	square As Square
)
```

**C++**<br />
``` C++
public:
void Move(
	Piece^ piece, 
	Square square
)
```

**F#**<br />
``` F#
member Move : 
        piece : Piece * 
        square : Square -> unit 

```

**J#**<br />
``` J#
public void Move(
	Piece piece,
	Square square
)
```


#### Parameters
&nbsp;<dl><dt>piece</dt><dd>Type: <a href="T_Snake_Piece">Snake.Piece</a><br />The piece.</dd><dt>square</dt><dd>Type: <a href="T_Snake_Square">Snake.Square</a><br />The destination square.</dd></dl>

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.invalidoperationexception" target="_blank" rel="noopener noreferrer">InvalidOperationException</a></td><td>The given *square* is not empty.</td></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.argumentnullexception" target="_blank" rel="noopener noreferrer">ArgumentNullException</a></td><td>The given *piece* is a null reference (`Nothing` in Visual Basic).</td></tr></table>

## See Also


#### Reference
<a href="T_Snake_Board">Board Class</a><br /><a href="N_Snake">Snake Namespace</a><br />