# Board.Updated Event
 

Occurs when the board is updated.

**Namespace:**&nbsp;<a href="N_Snake">Snake</a><br />**Assembly:**&nbsp;Snake (in Snake.dll) Version: 1.0.0

## Syntax

**C#**<br />
``` C#
public event EventHandler<SquareEventArgs> Updated
```

**VB**<br />
``` VB
Public Event Updated As EventHandler(Of SquareEventArgs)
```

**C++**<br />
``` C++
public:
 event EventHandler<SquareEventArgs^>^ Updated {
	void add (EventHandler<SquareEventArgs^>^ value);
	void remove (EventHandler<SquareEventArgs^>^ value);
}
```

**F#**<br />
``` F#
member Updated : IEvent<EventHandler<SquareEventArgs>,
    SquareEventArgs>

```

**J#**<br />
``` J#
/** @event */
public void add_Updated (EventHandler<SquareEventArgs> value)
/** @event */
public void remove_Updated (EventHandler<SquareEventArgs> value)

```


#### Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.eventhandler-1" target="_blank" rel="noopener noreferrer">System.EventHandler</a>(<a href="T_Snake_SquareEventArgs">SquareEventArgs</a>)

## See Also


#### Reference
<a href="T_Snake_Board">Board Class</a><br /><a href="N_Snake">Snake Namespace</a><br />