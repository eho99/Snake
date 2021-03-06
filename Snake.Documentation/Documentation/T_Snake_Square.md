# Square Structure
 

Represents a square on a board.

**Namespace:**&nbsp;<a href="N_Snake">Snake</a><br />**Assembly:**&nbsp;Snake (in Snake.dll) Version: 1.0.0

## Syntax

**C#**<br />
``` C#
public readonly struct Square : IEquatable<Square>
```

**VB**<br />
``` VB
Public Structure Square
	Implements IEquatable(Of Square)
```

**C++**<br />
``` C++
public value class Square : IEquatable<Square>
```

**F#**<br />
``` F#
[<SealedAttribute>]
type Square =  
    struct
        interface IEquatable<Square>
    end
```

**J#**<br />
``` J#
public final class Square extends ValueType implements IEquatable<Square>
```

The Square type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Snake_Square__ctor">Square(Char, Int32)</a></td><td>
Initializes a new instance of the Square struct.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Snake_Square__ctor_1">Square(Int32, Int32)</a></td><td>
Initializes a new instance of the Square struct.</td></tr></table>&nbsp;
<a href="#square-structure">Back to Top</a>

## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Snake_Square_Color">Color</a></td><td>
Gets the color of the square.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Snake_Square_File">File</a></td><td>
Gets the file letter of the square.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Snake_Square_Rank">Rank</a></td><td>
Gets the rank number of the square.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Snake_Square_X">X</a></td><td>
Gets the zero-based horizontal coordinate of the square.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Snake_Square_Y">Y</a></td><td>
Gets the zero-based vertical coordinate of the square.</td></tr></table>&nbsp;
<a href="#square-structure">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Snake_Square_Equals_1">Equals(Object)</a></td><td>
Indicates whether this instance and a specified object are equal.
 (Overrides <a href="https://docs.microsoft.com/dotnet/api/system.valuetype.equals#System_ValueType_Equals_System_Object_" target="_blank" rel="noopener noreferrer">ValueType.Equals(Object)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Snake_Square_Equals">Equals(Square)</a></td><td>
Indicates whether the current object is equal to another object of the same type.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Snake_Square_GetHashCode">GetHashCode</a></td><td>
Returns the hash code for this instance.
 (Overrides <a href="https://docs.microsoft.com/dotnet/api/system.valuetype.gethashcode#System_ValueType_GetHashCode" target="_blank" rel="noopener noreferrer">ValueType.GetHashCode()</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="https://docs.microsoft.com/dotnet/api/system.object.gettype#System_Object_GetType" target="_blank" rel="noopener noreferrer">GetType</a></td><td>
Gets the <a href="https://docs.microsoft.com/dotnet/api/system.type" target="_blank" rel="noopener noreferrer">Type</a> of the current instance.
 (Inherited from <a href="https://docs.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Snake_Square_GetValues">GetValues</a></td><td>
Gets a collection of new Square instances that represent all the possible values.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Snake_Square_ToString">ToString</a></td><td>
Returns the fully qualified type name of this instance.
 (Overrides <a href="https://docs.microsoft.com/dotnet/api/system.valuetype.tostring#System_ValueType_ToString" target="_blank" rel="noopener noreferrer">ValueType.ToString()</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Snake_Square_TryCreate">TryCreate</a></td><td>
Converts the zero-based horizontal and vertical coordinates of a number to a Square instance. A return value indicates whether the operation succeeded.</td></tr></table>&nbsp;
<a href="#square-structure">Back to Top</a>

## Operators
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public operator](media/puboperator.gif "Public operator")![Static member](media/static.gif "Static member")</td><td><a href="M_Snake_Square_op_Equality">Equality</a></td><td>
Determines whether two specified instances of Square are equal.</td></tr><tr><td>![Public operator](media/puboperator.gif "Public operator")![Static member](media/static.gif "Static member")</td><td><a href="M_Snake_Square_op_Inequality">Inequality</a></td><td>
Determines whether two specified instances of Square are not equal.</td></tr></table>&nbsp;
<a href="#square-structure">Back to Top</a>

## Fields
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public field](media/pubfield.gif "Public field")![Static member](media/static.gif "Static member")</td><td><a href="F_Snake_Square_Files">Files</a></td><td>
Specifies the number of files.</td></tr><tr><td>![Public field](media/pubfield.gif "Public field")![Static member](media/static.gif "Static member")</td><td><a href="F_Snake_Square_Ranks">Ranks</a></td><td>
Specifies the number of ranks.</td></tr></table>&nbsp;
<a href="#square-structure">Back to Top</a>

## See Also


#### Reference
<a href="N_Snake">Snake Namespace</a><br />