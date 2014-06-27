//
//  Copyright (C) 2014 Andoni Morales Alastruey
//
//  This program is free software; you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation; either version 2 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program; if not, write to the Free Software
//  Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA 02110-1301, USA.
//
using System;
using LongoMatch.Store.Drawables;
using LongoMatch.Interfaces.Drawing;
using LongoMatch.Interfaces;
using LongoMatch.Common;

namespace LongoMatch.Drawing.CanvasObject
{
	public class TextObject: CanvasDrawableObject<Text>, ICanvasSelectableObject
	{
		public TextObject ()
		{
		}

		public TextObject (Text text)
		{
			Drawable = text;
		}
		
		public override void Draw (IDrawingToolkit tk, Area area) {
			tk.Begin ();
			tk.FillColor = Drawable.FillColor;
			tk.StrokeColor = Drawable.StrokeColor;
			tk.LineWidth = Drawable.LineWidth;
			tk.DrawRectangle (Drawable.TopLeft, Drawable.Width, Drawable.Height);
			tk.DrawArea (Drawable.TopLeft, Drawable.TopRight,
			             Drawable.BottomRight, Drawable.BottomLeft);
			tk.StrokeColor = Drawable.TextColor;
			tk.DrawText (Drawable.TopLeft, Drawable.Width, Drawable.Height,
			             Drawable.Value);
			DrawSelectionArea (tk);
			tk.End ();
		}
	}
}

