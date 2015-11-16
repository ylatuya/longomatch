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
using System.Linq;
using LongoMatch.Core.Store;

namespace LongoMatch.Core.Filters
{
	public class ProjectsFilter
	{
		public const string EMPTY_OR_NULL = "$%&EMPTY$%&NULL$$%&";
		readonly HashSet<string> competitions;
		readonly HashSet<string> seasons;
		readonly HashSet<string> teams;
		List<Project> projects;

		public ProjectsFilter ()
		{
			competitions = new HashSet<string> ();
			seasons = new HashSet<string> ();
			teams = new HashSet<string> ();
		}

		/// <summary>
		/// List of projects to filter
		/// </summary>
		public List<Project> Projects {
			get {
				return projects;
			}
			set {
				projects = value;
				VisibleProjects = new List<Project> ();
				Changed = true;
			}
		}

		/// <summary>
		/// List of visible projects after aplying the filters
		/// </summary>
		public List<Project> VisibleProjects {
			protected set;
			get;
		}

		/// <summary>
		/// List of available seasons to filter.
		/// </summary>
		public List<string> Seasons {
			get {
				return Projects.Select (p => p.Description.Season).Where (s => !String.IsNullOrEmpty (s)).
					Distinct ().OrderBy (s => s).ToList ();
			}
		}

		/// <summary>
		/// List of available competitions to filter.
		/// </summary>
		public List<string> Competitions {
			get {
				return Projects.Select (p => p.Description.Competition).Where (s => !String.IsNullOrEmpty (s)).
					Distinct ().OrderBy (s => s).ToList ();
			}
		}

		/// <summary>
		/// List of available teams to filter.
		/// </summary>
		public List<string> Teams {
			get {
				return Projects.SelectMany (p =>
					new [] { p.Description.LocalName, p.Description.VisitorName }).
					Distinct ().OrderBy (s => s).ToList ();
			}
		}

		bool Changed {
			get;
			set;
		}

		/// <summary>
		/// Filter a season.
		/// </summary>
		/// <param name="season">The name of the season.</param>
		/// <param name="isVisible">If set to <c>true</c>, projects with this season are visible.</param>
		public void FilterSeason (string season, bool isVisible)
		{
			Filter (seasons, season, isVisible);
		}

		/// <summary>
		/// Filter a competition.
		/// </summary>
		/// <param name="competition">The name of the season.</param>
		/// <param name="isVisible">If set to <c>true</c>, projects with this competition are visible.</param>
		public void FilterCompetition (string competition, bool isVisible)
		{
			Filter (competitions, competition, isVisible);
		}

		/// <summary>
		/// Filter a team.
		/// </summary>
		/// <param name="team">The name of the team.</param>
		/// <param name="isVisible">If set to <c>true</c>, projects with this team are visible.</param>
		public void FilterTeam (string team, bool isVisible)
		{
			Filter (teams, team, isVisible);
		}

		/// <summary>
		/// Applies the changes to the filter and updates the list of available projects.
		/// </summary>
		public void ApplyChanges ()
		{
			IEnumerable<Project> filteredProjects;
			if (!Changed) {
				return;
			}

			if (seasons.Count == 0 && competitions.Count == 0 && teams.Count == 0) {
				VisibleProjects = new List<Project> ();
				return;
			}

			filteredProjects = projects;
			if (seasons.Count > 0) {
				if (seasons.Contains (EMPTY_OR_NULL)) {
					filteredProjects = filteredProjects.Where
						(p => seasons.Contains (p.Description.Season) || String.IsNullOrEmpty (p.Description.Season));
				} else {
					filteredProjects = filteredProjects.Where (p => seasons.Contains (p.Description.Season));
				}
			}
			if (competitions.Count > 0) {
				if (competitions.Contains (EMPTY_OR_NULL)) {
					filteredProjects = filteredProjects.Where (p => competitions.Contains (p.Description.Competition) ||
					String.IsNullOrEmpty (p.Description.Competition));
				} else {
					filteredProjects = filteredProjects.Where (p => competitions.Contains (p.Description.Competition));
				}
			}
			if (teams.Count > 0) {
				filteredProjects = filteredProjects.Where (p =>
				teams.Contains (p.Description.LocalName) || teams.Contains (p.Description.VisitorName));
			}
			VisibleProjects = filteredProjects.ToList ();
		}

		void Filter (HashSet<string> list, string value, bool isVisible)
		{
			if (isVisible) {
				Changed |= list.Add (value);
			} else {
				Changed |= list.Remove (value);
			}
		}

	}
}

