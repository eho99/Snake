# Square.TryCreate Method 
 

Converts the zero-based horizontal and vertical coordinates of a number to a <a href="T_Snake_Square">Square</a> instance. A return value indicates whether the operation succeeded.

**Namespace:**&nbsp;<a href="N_Snake">Snake</a><br />**Assembly:**&nbsp;Snake (in Snake.dll) Version: 1.0.0

## Syntax

**C#**<br />
``` C#
public static bool TryCreate(
	int x,
	int y,
	out Square result
)
```

**VB**<br />
``` VB
Public Shared Function TryCreate ( 
	x As Integer,
	y As Integer,
	<OutAttribute> ByRef result As Square
) As Boolean
```

**C++**<br />
``` C++
public:
static bool TryCreate(
	int x, 
	int y, 
	[OutAttribute] Square% result
)
```

**F#**<br />
``` F#
static member TryCreate : 
        x : int * 
        y : int * 
        result : Square byref -> bool 

```

**J#**<br />
``` J#
public static boolean TryCreate(
	int x,
	int y,
	/** @attribute OutAttribute */ /** @ref */Square result
)
```


#### Parameters
&nbsp;<dl><dt>x</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.int32" target="_blank" rel="noopener noreferrer">System.Int32</a><br />The zero-based horizontal coordinate.</dd><dt>y</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.int32" target="_blank" rel="noopener noreferrer">System.Int32</a><br />The zero-based vertical coordinate.</dd><dt>result</dt><dd>Type: <a href="T_Snake_Square">Snake.Square</a><br />When this method returns, contains the square equivalent to the coordinates contained in *x* and *y*, if the conversion succeeded, or the default <a href="T_Snake_Square">Square</a> instance if the conversion failed. The conversion fails if the *x* parameter is negative or greater than one less than the number of <a href="F_Snake_Square_Files">Files</a> or if the *y* parameter is negative or greater than one less than the number of <a href="F_Snake_Square_Ranks">Ranks</a>. This parameter is treated as uninitialized.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_blank" rel="noopener noreferrer">Boolean</a><br />`true` (`True` in Visual Basic) if the square was created successfully; otherwise, `false` (`False` in Visual Basic).

## See Also


#### Reference
<a href="T_Snake_Square">Square Structure</a><br /><a href="N_Snake">Snake Namespace</a><br />