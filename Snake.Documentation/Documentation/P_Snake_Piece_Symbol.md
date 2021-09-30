# Piece.Symbol Property 
 

Gets the symbol for the piece in algebraic notation.

**Namespace:**&nbsp;<a href="N_Snake">Snake</a><br />**Assembly:**&nbsp;Snake (in Snake.dll) Version: 1.0.0

## Syntax

**C#**<br />
``` C#
public char Symbol { get; }
```

**VB**<br />
``` VB
Public ReadOnly Property Symbol As Char
	Get
```

**VB Usage**<br />
``` VB Usage
Dim instance As Piece
Dim value As Char

value = instance.Symbol

```

**C++**<br />
``` C++
public:
property wchar_t Symbol {
	wchar_t get ();
}
```

**F#**<br />
``` F#
member Symbol : char with get

```

**J#**<br />
``` J#
/** @property */
public char get_Symbol()

```

**JScript**<br />
``` JScript
function get Symbol () : char

```

**JavaScript**<br />
``` JavaScript
function get_Symbol();

```


#### Property Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.char" target="_blank" rel="noopener noreferrer">Char</a><br />The symbol for the piece.

## See Also


#### Reference
<a href="T_Snake_Piece">Piece Class</a><br /><a href="N_Snake">Snake Namespace</a><br />