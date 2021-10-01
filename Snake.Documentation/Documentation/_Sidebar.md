- [Snake Namespace](N_Snake)
  - [Board Class](T_Snake_Board)
    - [Board Constructor](M_Snake_Board__ctor)
    - [Board Properties](Properties_T_Snake_Board)
      - [Board.Item Property](P_Snake_Board_Item)
    - [Board Methods](Methods_T_Snake_Board)
      - [Board.Insert Method](M_Snake_Board_Insert)
      - [Board.Move Method](M_Snake_Board_Move)
      - [Board.OnUpdated Method](M_Snake_Board_OnUpdated)
      - [Board.TryGetPiece Method](M_Snake_Board_TryGetPiece)
    - [Board Events](Events_T_Snake_Board)
      - [Board.Updated Event](E_Snake_Board_Updated)
  - [BoardFactory Class](T_Snake_BoardFactory)
    - [BoardFactory Constructor](M_Snake_BoardFactory__ctor)
    - [BoardFactory Methods](Methods_T_Snake_BoardFactory)
      - [BoardFactory.Create Method](M_Snake_BoardFactory_Create)
  - [Color Enumeration](T_Snake_Color)
  - [Direction Enumeration](T_Snake_Direction)
  - [IBoardFactory Interface](T_Snake_IBoardFactory)
    - [IBoardFactory Methods](Methods_T_Snake_IBoardFactory)
      - [IBoardFactory.Create Method](M_Snake_IBoardFactory_Create)
  - [IMove Interface](T_Snake_IMove)
    - [IMove Methods](Methods_T_Snake_IMove)
      - [IMove.Execute Method](M_Snake_IMove_Execute)
  - [IMoveProvider Interface](T_Snake_IMoveProvider)
    - [IMoveProvider Methods](Methods_T_Snake_IMoveProvider)
      - [IMoveProvider.GetMoves Method](M_Snake_IMoveProvider_GetMoves)
  - [IPieceFactory Interface](T_Snake_IPieceFactory)
    - [IPieceFactory Methods](Methods_T_Snake_IPieceFactory)
      - [IPieceFactory.CreateBishop Method](M_Snake_IPieceFactory_CreateBishop)
      - [IPieceFactory.CreateKnight Method](M_Snake_IPieceFactory_CreateKnight)
      - [IPieceFactory.CreatePawn Method](M_Snake_IPieceFactory_CreatePawn)
      - [IPieceFactory.CreateQueen Method](M_Snake_IPieceFactory_CreateQueen)
      - [IPieceFactory.CreateRook Method](M_Snake_IPieceFactory_CreateRook)
  - [Piece Class](T_Snake_Piece)
    - [Piece Constructor](M_Snake_Piece__ctor)
    - [Piece Properties](Properties_T_Snake_Piece)
      - [Piece.Board Property](P_Snake_Piece_Board)
      - [Piece.Player Property](P_Snake_Piece_Player)
      - [Piece.Square Property](P_Snake_Piece_Square)
      - [Piece.Symbol Property](P_Snake_Piece_Symbol)
    - [Piece Methods](Methods_T_Snake_Piece)
      - [Piece.GetMoves Method](M_Snake_Piece_GetMoves)
      - [Piece.ToString Method](M_Snake_Piece_ToString)
  - [PieceFactory Class](T_Snake_PieceFactory)
    - [PieceFactory Constructor](M_Snake_PieceFactory__ctor)
    - [PieceFactory Methods](Methods_T_Snake_PieceFactory)
      - [PieceFactory.CreateBishop Method](M_Snake_PieceFactory_CreateBishop)
      - [PieceFactory.CreateKnight Method](M_Snake_PieceFactory_CreateKnight)
      - [PieceFactory.CreatePawn Method](M_Snake_PieceFactory_CreatePawn)
      - [PieceFactory.CreateQueen Method](M_Snake_PieceFactory_CreateQueen)
      - [PieceFactory.CreateRook Method](M_Snake_PieceFactory_CreateRook)
  - [Player Class](T_Snake_Player)
    - [Player Constructor](M_Snake_Player__ctor)
    - [Player Properties](Properties_T_Snake_Player)
      - [Player.Color Property](P_Snake_Player_Color)
      - [Player.Direction Property](P_Snake_Player_Direction)
    - [Player Methods](Methods_T_Snake_Player)
  - [Square Structure](T_Snake_Square)
    - [Square Constructor](Overload_Snake_Square__ctor)
      - [Square Constructor (Char, Int32)](M_Snake_Square__ctor)
      - [Square Constructor (Int32, Int32)](M_Snake_Square__ctor_1)
    - [Square Properties](Properties_T_Snake_Square)
      - [Square.Color Property](P_Snake_Square_Color)
      - [Square.File Property](P_Snake_Square_File)
      - [Square.Rank Property](P_Snake_Square_Rank)
      - [Square.X Property](P_Snake_Square_X)
      - [Square.Y Property](P_Snake_Square_Y)
    - [Square Methods](Methods_T_Snake_Square)
      - [Square.Equals Method](Overload_Snake_Square_Equals)
        - [Square.Equals Method (Object)](M_Snake_Square_Equals_1)
        - [Square.Equals Method (Square)](M_Snake_Square_Equals)
      - [Square.GetHashCode Method](M_Snake_Square_GetHashCode)
      - [Square.GetValues Method](M_Snake_Square_GetValues)
      - [Square.ToString Method](M_Snake_Square_ToString)
      - [Square.TryCreate Method](M_Snake_Square_TryCreate)
    - [Square Operators](Operators_T_Snake_Square)
      - [Square.Equality Operator](M_Snake_Square_op_Equality)
      - [Square.Inequality Operator](M_Snake_Square_op_Inequality)
    - [Square Fields](Fields_T_Snake_Square)
      - [Square.Files Field](F_Snake_Square_Files)
      - [Square.Ranks Field](F_Snake_Square_Ranks)
  - [SquareEventArgs Class](T_Snake_SquareEventArgs)
    - [SquareEventArgs Constructor](M_Snake_SquareEventArgs__ctor)
    - [SquareEventArgs Properties](Properties_T_Snake_SquareEventArgs)
      - [SquareEventArgs.Value Property](P_Snake_SquareEventArgs_Value)
    - [SquareEventArgs Methods](Methods_T_Snake_SquareEventArgs)