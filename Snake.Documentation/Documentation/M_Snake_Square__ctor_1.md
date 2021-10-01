# Square Constructor (Int32, Int32)
 

Initializes a new instance of the <a href="T_Snake_Square">Square</a> struct.

**Namespace:**&nbsp;<a href="N_Snake">Snake</a><br />**Assembly:**&nbsp;Snake (in Snake.dll) Version: 1.0.0

## Syntax

**C#**<br />
``` C#
public Square(
	int x,
	int y
)
```

**VB**<br />
``` VB
Public Sub New ( 
	x As Integer,
	y As Integer
)
```

**C++**<br />
``` C++
public:
Square(
	int x, 
	int y
)
```

**F#**<br />
``` F#
new : 
        x : int * 
        y : int -> Square
```

**J#**<br />
``` J#
public Square(
	int x,
	int y
)
```


#### Parameters
&nbsp;<dl><dt>x</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.int32" target="_blank" rel="noopener noreferrer">System.Int32</a><br />The zero-based horizontal coordinate.</dd><dt>y</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.int32" target="_blank" rel="noopener noreferrer">System.Int32</a><br />The zero-based vertical coordinate.</dd></dl>

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.argumentoutofrangeexception" target="_blank" rel="noopener noreferrer">ArgumentOutOfRangeException</a></td><td>The value of the *x* or *y* parameter is less than `0` or greater than `7`.</td></tr></table>

## See Also


#### Reference
<a href="T_Snake_Square">Square Structure</a><br /><a href="Overload_Snake_Square__ctor">Square Overload</a><br /><a href="N_Snake">Snake Namespace</a><br />