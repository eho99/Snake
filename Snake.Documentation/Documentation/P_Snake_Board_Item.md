# Board.Item Property 
 

Gets the piece on the given square.

**Namespace:**&nbsp;<a href="N_Snake">Snake</a><br />**Assembly:**&nbsp;Snake (in Snake.dll) Version: 1.0.0

## Syntax

**C#**<br />
``` C#
public Piece this[
	Square square
] { get; }
```

**VB**<br />
``` VB
Public ReadOnly Default Property Item ( 
	square As Square
) As Piece
	Get
```

**C++**<br />
``` C++
public:
property Piece^ default[Square square] {
	Piece^ get (Square square);
}
```

**F#**<br />
``` F#
member Item : Piece with get

```

**J#**<br />
``` J#
/** @property */
public Piece get_Item(
	Square square
)

```


#### Parameters
&nbsp;<dl><dt>square</dt><dd>Type: <a href="T_Snake_Square">Snake.Square</a><br />The square that contains the piece.</dd></dl>

#### Property Value
Type: <a href="T_Snake_Piece">Piece</a><br />The piece on the given square or a null reference (`Nothing` in Visual Basic) if the square is empty.

## See Also


#### Reference
<a href="T_Snake_Board">Board Class</a><br /><a href="N_Snake">Snake Namespace</a><br />