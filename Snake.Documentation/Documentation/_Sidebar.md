- [Snake Namespace](N_Snake)
  - [Board Class](T_Snake_Board)
    - [Board Constructor](M_Snake_Board__ctor)
    - [Board Properties](Properties_T_Snake_Board)
      - [Board.Item Property](P_Snake_Board_Item)
    - [Board Methods](Methods_T_Snake_Board)
  - [Direction Enumeration](T_Snake_Direction)
  - [IMove Interface](T_Snake_IMove)
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
      - [Player.Direction Property](P_Snake_Player_Direction)
    - [Player Methods](Methods_T_Snake_Player)
  - [Square Structure](T_Snake_Square)
    - [Square Constructor](M_Snake_Square__ctor)
    - [Square Properties](Properties_T_Snake_Square)
      - [Square.File Property](P_Snake_Square_File)
      - [Square.Rank Property](P_Snake_Square_Rank)
      - [Square.X Property](P_Snake_Square_X)
      - [Square.Y Property](P_Snake_Square_Y)
    - [Square Methods](Methods_T_Snake_Square)
      - [Square.GetValues Method](M_Snake_Square_GetValues)
      - [Square.ToString Method](M_Snake_Square_ToString)
      - [Square.TryCreate Method](M_Snake_Square_TryCreate)
    - [Square Fields](Fields_T_Snake_Square)
      - [Square.Files Field](F_Snake_Square_Files)
      - [Square.MaxFile Field](F_Snake_Square_MaxFile)
      - [Square.MaxRank Field](F_Snake_Square_MaxRank)
      - [Square.Ranks Field](F_Snake_Square_Ranks)