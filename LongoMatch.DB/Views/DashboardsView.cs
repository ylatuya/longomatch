﻿//
//  Copyright (C) 2015 Fluendo S.A.
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
using System.Collections.Generic;
using Couchbase.Lite;
using LongoMatch.Core.Store.Templates;

namespace LongoMatch.DB.Views
{
	public class DashboardsView: GenericView <Dashboard>
	{
		public DashboardsView (Database db) : base (db)
		{
		}

		protected override List<string> FilterProperties {
			get {
				return new List<string> { "Name" };
			}
		}

		protected override List<string> PreviewProperties {
			get {
				return new List<string> { "Name" };
			}
		}

		protected override string ViewVersion {
			get {
				return "1";
			}
		}
	}
}
