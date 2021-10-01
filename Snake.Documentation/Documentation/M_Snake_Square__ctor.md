# Square Constructor (Char, Int32)
 

Initializes a new instance of the <a href="T_Snake_Square">Square</a> struct.

**Namespace:**&nbsp;<a href="N_Snake">Snake</a><br />**Assembly:**&nbsp;Snake (in Snake.dll) Version: 1.0.0

## Syntax

**C#**<br />
``` C#
public Square(
	char file,
	int rank
)
```

**VB**<br />
``` VB
Public Sub New ( 
	file As Char,
	rank As Integer
)
```

**C++**<br />
``` C++
public:
Square(
	wchar_t file, 
	int rank
)
```

**F#**<br />
``` F#
new : 
        file : char * 
        rank : int -> Square
```

**J#**<br />
``` J#
public Square(
	char file,
	int rank
)
```


#### Parameters
&nbsp;<dl><dt>file</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.char" target="_blank" rel="noopener noreferrer">System.Char</a><br />The file letter.</dd><dt>rank</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.int32" target="_blank" rel="noopener noreferrer">System.Int32</a><br />The rank number.</dd></dl>

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.argumentexception" target="_blank" rel="noopener noreferrer">ArgumentException</a></td><td>The value of the *file* parameter is not `'A'`, `'B'`, `'C'`, `'D'`, `'E'`, `'F'`, `'G'`, or `'H'`.</td></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.argumentoutofrangeexception" target="_blank" rel="noopener noreferrer">ArgumentOutOfRangeException</a></td><td>The value of the *rank* parameter is less than `1` or greater than `8`.</td></tr></table>

## See Also


#### Reference
<a href="T_Snake_Square">Square Structure</a><br /><a href="Overload_Snake_Square__ctor">Square Overload</a><br /><a href="N_Snake">Snake Namespace</a><br />