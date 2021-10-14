// Project Snake: Piece.Values.cs
// Copyright (c) 2021 Project Snake Contributors,
// Ishan Pranav, Eric Ho, and Kaylee Kim. All rights reserved.

namespace Snake
{
	partial struct PieceType
	{
		/// <summary>
		///
		/// </summary>
		/// <value></value>
		/// <remarks>This property was auto-generated.</remarks>
		public static PieceType King
		{
			get
			{
				return new PieceType(1);
			}
		}

		/// <summary>
		///
		/// </summary>
		/// <value></value>
		/// <remarks>This property was auto-generated.</remarks>
		public static PieceType Queen
		{
			get
			{
				return new PieceType(2);
			}
		}

		/// <summary>
		///
		/// </summary>
		/// <value></value>
		/// <remarks>This property was auto-generated.</remarks>
		public static PieceType Rook
		{
			get
			{
				return new PieceType(3);
			}
		}

		/// <summary>
		///
		/// </summary>
		/// <value></value>
		/// <remarks>This property was auto-generated.</remarks>
		public static PieceType Bishop
		{
			get
			{
				return new PieceType(4);
			}
		}

		/// <summary>
		///
		/// </summary>
		/// <value></value>
		/// <remarks>This property was auto-generated.</remarks>
		public static PieceType Knight
		{
			get
			{
				return new PieceType(5);
			}
		}

		/// <summary>
		///
		/// </summary>
		/// <value></value>
		/// <remarks>This property was auto-generated.</remarks>
		public static PieceType Pawn
		{
			get
			{
				return new PieceType(6);
			}
		}

		/// <summary>
		///
		/// </summary>
		/// <value></value>
		public static PieceType None
		{
			get
			{
				return new PieceType();
			}
		}
	}
}