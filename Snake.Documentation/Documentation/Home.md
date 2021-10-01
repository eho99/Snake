# Snake Namespace
 

Contains types that define the Chess object model.


## Classes
&nbsp;<table><tr><th></th><th>Class</th><th>Description</th></tr><tr><td>![Public class](media/pubclass.gif "Public class")</td><td><a href="T_Snake_Board">Board</a></td><td>
Represents a rectangular board.</td></tr><tr><td>![Public class](media/pubclass.gif "Public class")</td><td><a href="T_Snake_BoardFactory">BoardFactory</a></td><td>
An <a href="T_Snake_IBoardFactory">IBoardFactory</a> that creates instances of the <a href="T_Snake_Board">Board</a> class.</td></tr><tr><td>![Public class](media/pubclass.gif "Public class")</td><td><a href="T_Snake_Piece">Piece</a></td><td>
Represents a playing piece.</td></tr><tr><td>![Public class](media/pubclass.gif "Public class")</td><td><a href="T_Snake_PieceFactory">PieceFactory</a></td><td>
An <a href="T_Snake_IPieceFactory">IPieceFactory</a> that creates instances of the <a href="T_Snake_Piece">Piece</a> class.</td></tr><tr><td>![Public class](media/pubclass.gif "Public class")</td><td><a href="T_Snake_Player">Player</a></td><td>
Represents a player.</td></tr><tr><td>![Public class](media/pubclass.gif "Public class")</td><td><a href="T_Snake_SquareEventArgs">SquareEventArgs</a></td><td>
Provides data for the <a href="E_Snake_Board_Updated">Updated</a> event.</td></tr></table>

## Structures
&nbsp;<table><tr><th></th><th>Structure</th><th>Description</th></tr><tr><td>![Public structure](media/pubstructure.gif "Public structure")</td><td><a href="T_Snake_Square">Square</a></td><td>
Represents a square on a board.</td></tr></table>

## Interfaces
&nbsp;<table><tr><th></th><th>Interface</th><th>Description</th></tr><tr><td>![Public interface](media/pubinterface.gif "Public interface")</td><td><a href="T_Snake_IBoardFactory">IBoardFactory</a></td><td>
Defines a method for creating instances of the <a href="T_Snake_Board">Board</a> class.</td></tr><tr><td>![Public interface](media/pubinterface.gif "Public interface")</td><td><a href="T_Snake_IMove">IMove</a></td><td>
Defines a move.</td></tr><tr><td>![Public interface](media/pubinterface.gif "Public interface")</td><td><a href="T_Snake_IMoveProvider">IMoveProvider</a></td><td>
Defines a method for creating collections of moves.</td></tr><tr><td>![Public interface](media/pubinterface.gif "Public interface")</td><td><a href="T_Snake_IPieceFactory">IPieceFactory</a></td><td>
Defines methods for creating instances of the <a href="T_Snake_Piece">Piece</a> class.</td></tr></table>

## Enumerations
&nbsp;<table><tr><th></th><th>Enumeration</th><th>Description</th></tr><tr><td>![Public enumeration](media/pubenumeration.gif "Public enumeration")</td><td><a href="T_Snake_Color">Color</a></td><td>
Specifies a color.</td></tr><tr><td>![Public enumeration](media/pubenumeration.gif "Public enumeration")</td><td><a href="T_Snake_Direction">Direction</a></td><td>
Specifies a direction of motion.</td></tr></table>&nbsp;
