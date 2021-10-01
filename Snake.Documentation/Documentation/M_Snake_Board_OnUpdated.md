# Board.OnUpdated Method 
 

Raises the <a href="E_Snake_Board_Updated">Updated</a> event.

**Namespace:**&nbsp;<a href="N_Snake">Snake</a><br />**Assembly:**&nbsp;Snake (in Snake.dll) Version: 1.0.0

## Syntax

**C#**<br />
``` C#
protected virtual void OnUpdated(
	SquareEventArgs e
)
```

**VB**<br />
``` VB
Protected Overridable Sub OnUpdated ( 
	e As SquareEventArgs
)
```

**C++**<br />
``` C++
protected:
virtual void OnUpdated(
	SquareEventArgs^ e
)
```

**F#**<br />
``` F#
abstract OnUpdated : 
        e : SquareEventArgs -> unit 
override OnUpdated : 
        e : SquareEventArgs -> unit 
```

**J#**<br />
``` J#
protected void OnUpdated(
	SquareEventArgs e
)
```


#### Parameters
&nbsp;<dl><dt>e</dt><dd>Type: <a href="T_Snake_SquareEventArgs">Snake.SquareEventArgs</a><br />The event data.</dd></dl>

## See Also


#### Reference
<a href="T_Snake_Board">Board Class</a><br /><a href="N_Snake">Snake Namespace</a><br />