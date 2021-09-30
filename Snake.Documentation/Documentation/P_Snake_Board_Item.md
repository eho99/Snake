# Board.Item Property 
 

Gets or sets the piece on the given square. When reassiging an existing piece to a new square, the piece is removed from its original square. Any existing piece on the destination square is removed from the board.

**Namespace:**&nbsp;<a href="N_Snake">Snake</a><br />**Assembly:**&nbsp;Snake (in Snake.dll) Version: 1.0.0

## Syntax

**C#**<br />
``` C#
public Piece this[
	Square square
] { get; set; }
```

**VB**<br />
``` VB
Public Default Property Item ( 
	square As Square
) As Piece
	Get
	Set
```

**C++**<br />
``` C++
public:
property Piece^ default[Square square] {
	Piece^ get (Square square);
	void set (Square square, Piece^ value);
}
```

**F#**<br />
``` F#
member Item : Piece with get, set

```

**J#**<br />
``` J#
/** @property */
public Piece get_Item(
	Square square
)
/** @property */
public void set_Item(Piece value)

```


#### Parameters
&nbsp;<dl><dt>square</dt><dd>Type: <a href="T_Snake_Square">Snake.Square</a><br /></dd></dl>

#### Property Value
Type: <a href="T_Snake_Piece">Piece</a><br />The piece on the given square or a null reference (`Nothing` in Visual Basic) if the square is empty.

## See Also


#### Reference
<a href="T_Snake_Board">Board Class</a><br /><a href="N_Snake">Snake Namespace</a><br />