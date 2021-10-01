# Board.TryGetPiece Method 
 

Gets the piece on the given square. A return value indicates whether the operation succeeded.

**Namespace:**&nbsp;<a href="N_Snake">Snake</a><br />**Assembly:**&nbsp;Snake (in Snake.dll) Version: 1.0.0

## Syntax

**C#**<br />
``` C#
public bool TryGetPiece(
	Square square,
	out Piece result
)
```

**VB**<br />
``` VB
Public Function TryGetPiece ( 
	square As Square,
	<OutAttribute> ByRef result As Piece
) As Boolean
```

**C++**<br />
``` C++
public:
bool TryGetPiece(
	Square square, 
	[OutAttribute] Piece^% result
)
```

**F#**<br />
``` F#
member TryGetPiece : 
        square : Square * 
        result : Piece byref -> bool 

```

**J#**<br />
``` J#
public boolean TryGetPiece(
	Square square,
	/** @attribute OutAttribute */ /** @ref */Piece result
)
```


#### Parameters
&nbsp;<dl><dt>square</dt><dd>Type: <a href="T_Snake_Square">Snake.Square</a><br />The square that contains the piece.</dd><dt>result</dt><dd>Type: <a href="T_Snake_Piece">Snake.Piece</a><br />When this method returns, contains the piece on the square, if a piece occupies the square, or a null reference (`Nothing` in Visual Basic) if square is empty. This parameter is treated as uninitialized.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_blank" rel="noopener noreferrer">Boolean</a><br />`true` (`True` in Visual Basic) if a piece occupies the square; otherwise, `false` (`False` in Visual Basic).

## See Also


#### Reference
<a href="T_Snake_Board">Board Class</a><br /><a href="N_Snake">Snake Namespace</a><br />