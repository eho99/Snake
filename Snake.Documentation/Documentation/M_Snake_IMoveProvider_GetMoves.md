# IMoveProvider.GetMoves Method 
 

Gets a collection of moves for a given piece.

**Namespace:**&nbsp;<a href="N_Snake">Snake</a><br />**Assembly:**&nbsp;Snake (in Snake.dll) Version: 1.0.0

## Syntax

**C#**<br />
``` C#
IEnumerable<IMove> GetMoves(
	Piece piece
)
```

**VB**<br />
``` VB
Function GetMoves ( 
	piece As Piece
) As IEnumerable(Of IMove)
```

**C++**<br />
``` C++
IEnumerable<IMove^>^ GetMoves(
	Piece^ piece
)
```

**F#**<br />
``` F#
abstract GetMoves : 
        piece : Piece -> IEnumerable<IMove> 

```

**J#**<br />
``` J#
IEnumerable<IMove> GetMoves(
	Piece piece
)
```


#### Parameters
&nbsp;<dl><dt>piece</dt><dd>Type: <a href="T_Snake_Piece">Snake.Piece</a><br />The piece.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_blank" rel="noopener noreferrer">IEnumerable</a>(<a href="T_Snake_IMove">IMove</a>)<br />A collection of moves.

## See Also


#### Reference
<a href="T_Snake_IMoveProvider">IMoveProvider Interface</a><br /><a href="N_Snake">Snake Namespace</a><br />