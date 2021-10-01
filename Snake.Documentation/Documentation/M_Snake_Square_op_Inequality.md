# Square.Inequality Operator 
 

Determines whether two specified instances of <a href="T_Snake_Square">Square</a> are not equal.

**Namespace:**&nbsp;<a href="N_Snake">Snake</a><br />**Assembly:**&nbsp;Snake (in Snake.dll) Version: 1.0.0

## Syntax

**C#**<br />
``` C#
public static bool operator !=(
	Square left,
	Square right
)
```

**VB**<br />
``` VB
Public Shared Operator <> ( 
	left As Square,
	right As Square
) As Boolean
```

**C++**<br />
``` C++
public:
static bool operator !=(
	Square left, 
	Square right
)
```

**F#**<br />
``` F#
static let inline (<>)
        left : Square * 
        right : Square  : bool
```

**J#**<br />
``` J#

```


#### Parameters
&nbsp;<dl><dt>left</dt><dd>Type: <a href="T_Snake_Square">Snake.Square</a><br />The first object to compare.</dd><dt>right</dt><dd>Type: <a href="T_Snake_Square">Snake.Square</a><br />The second object to compare.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_blank" rel="noopener noreferrer">Boolean</a><br />`true` (`True` in Visual Basic) if *left* and *right* do not represent the same square; otherwise, `false` (`False` in Visual Basic).

## See Also


#### Reference
<a href="T_Snake_Square">Square Structure</a><br /><a href="N_Snake">Snake Namespace</a><br />