// Project.cs
//
//  Copyright (C) 2007 Andoni Morales Alastruey
//
// This program is free software; you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation; either version 2 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA 02111-1307 USA
//
//

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Gtk;
using Gdk;
using LongoMatch.TimeNodes;

namespace LongoMatch.DB
{
	
	[Serializable]
	public class Project : IComparable
	{
		
		private MediaFile file;
		
		
		private string title;
				
		private string localName;

		private string visitorName;

		private int localGoals;

		private int visitorGoals;
		
		private DateTime matchDate;
		
		private string season;
		
		private string competition;
		
		private Sections sections;

		private List<List<MediaTimeNode>> sectionPlaysList;
		
		private List<List<MediaTimeNode>> localTeamPlaysList;
		
		private List<List<MediaTimeNode>> visitorTeamPlaysList;
		
		private TeamTemplate visitorTeamTemplate;
		
		private TeamTemplate localTeamTemplate;
		
	
		
		public Project(MediaFile file, String localName, String visitorName, String season, String competition, int localGoals,
		                int visitorGoals, DateTime matchDate, Sections sections, TeamTemplate localTeamTemplate, TeamTemplate visitorTeamTemplate) {
			List<MediaTimeNode> tnArray;
			
			this.file = file;
			this.localName = localName;
			this.visitorName = visitorName;
			this.localGoals = localGoals;
			this.visitorGoals = visitorGoals;
			this.matchDate = matchDate;	
			this.season = season;
			this.competition = competition;
			this.localTeamTemplate = localTeamTemplate;
			this.visitorTeamTemplate = visitorTeamTemplate;
			this.sections = sections;
			this.sectionPlaysList = new List<List<MediaTimeNode>>(); 
			this.visitorTeamPlaysList = new List<List<MediaTimeNode>>();
			this.localTeamPlaysList = new List<List<MediaTimeNode>>();
			
			for (int i=0;i<sections.Count;i++){
				sectionPlaysList.Add(new List<MediaTimeNode>());
			}
			
			for (int i=0;i<localTeamTemplate.PlayersCount;i++){
				localTeamPlaysList.Add(new List<MediaTimeNode>());
			}
			
			for (int i=0;i<visitorTeamTemplate.PlayersCount;i++){
				visitorTeamPlaysList.Add(new List<MediaTimeNode>());
			}
			
			this.Title = System.IO.Path.GetFileNameWithoutExtension(this.file.FilePath);			
			System.IO.Directory.CreateDirectory(MainClass.ThumbnailsDir()+"/"+title);	
		}
	
		public Sections Sections{
			get{ return this.sections;}
			set {this.sections = value;}			
		}
		
		public TeamTemplate LocalTeamTemplate{
			get{return localTeamTemplate;}
			set{localTeamTemplate=value;}
		}
		
		public TeamTemplate VisitorTeamTemplate{
			get{return visitorTeamTemplate;}
			set{visitorTeamTemplate=value;}
		}
		
		public void AddSection(SectionsTimeNode tn){
			AddSectionAtPos(tn,sections.Count);
		}
		
		public void AddSectionAtPos(SectionsTimeNode tn,int sectionIndex){
			sectionPlaysList.Insert(sectionIndex,new List<MediaTimeNode>());
			sections.AddSectionAtPos(tn,sectionIndex);
		}
		
		public void DeleteSection(int sectionIndex){
			if (sections.Count == 1)
				throw new Exception ("You can't remove the last Section");
			sections.RemoveSection(sectionIndex);
			sectionPlaysList.RemoveAt(sectionIndex);			
		}
		
		public string[] GetSectionsNames(){
			return sections.GetSectionsNames();
				
		}
		
		public Time[] GetSectionsStartTimes(){
			return sections.GetSectionsStartTimes();
		}
		
		public Time[] GetSectionsStopTimes(){
			return sections.GetSectionsStopTimes();
		}

		public MediaTimeNode AddTimeNode(int dataSection, Time start, Time stop,Pixbuf thumbnail) {
			MediaTimeNode tn ;
			List<MediaTimeNode> playsList= sectionPlaysList[dataSection];
			int count= playsList.Count+1;
			string name = sections.GetName(dataSection) + " " +count;

			tn = new MediaTimeNode(name, start, stop,"",file.Fps,thumbnail);
			playsList.Add(tn);			
			return tn;

		}

		public void DelTimeNode(MediaTimeNode tNode,int section) {
			sectionPlaysList[section].Remove(tNode);			
		}
		
		public TreeStore GetModel (){
			Gtk.TreeStore dataFileListStore = new Gtk.TreeStore (typeof (MediaTimeNode));
			for (int i=0;i<sections.Count;i++){
				Gtk.TreeIter iter = dataFileListStore.AppendValues (sections.GetTimeNode(i));
				foreach(MediaTimeNode tNode in sectionPlaysList[i]){
						dataFileListStore.AppendValues (iter,tNode);
				}						
			}
			return dataFileListStore;
		}
		
		public TreeStore GetLocalTeamModel (){
			Gtk.TreeStore dataFileListStore = new Gtk.TreeStore (typeof (object));
			for (int i=0;i<localTeamTemplate.PlayersCount;i++){
				Gtk.TreeIter iter = dataFileListStore.AppendValues (localTeamTemplate.GetPlayer(i));
				foreach(MediaTimeNode tNode in localTeamPlaysList[i]){
						dataFileListStore.AppendValues (iter,tNode);
				}						
			}
			return dataFileListStore;
		}
		
		public TreeStore GetVisitorTeamModel (){
			Gtk.TreeStore dataFileListStore = new Gtk.TreeStore (typeof (object));
			for (int i=0;i<visitorTeamTemplate.PlayersCount;i++){
				Gtk.TreeIter iter = dataFileListStore.AppendValues (visitorTeamTemplate.GetPlayer(i));
				foreach(MediaTimeNode tNode in visitorTeamPlaysList[i]){
						dataFileListStore.AppendValues (iter,tNode);
				}						
			}
			return dataFileListStore;
		}

		public List<List<MediaTimeNode>> GetDataArray() {
			return sectionPlaysList;
		}
	

		public MediaFile File {
			get{return file;}
			set{file=value;}
		}
		
	
		
		public String Title {
			get{return title;}
			set{title=value;}
		}
		
		public String Season{
			get{return season;}
			set{season = value;}
		}
		
		public String Competition{
			get{return competition;}
			set{competition= value;}
		}
		
		public String LocalName {
			get{ return localName;}
			set{localName=value;}
		}
		
		public String VisitorName {
			get{ return visitorName;}
			set{visitorName=value;}
		}
		
		public int LocalGoals {
			get{ return localGoals;}
			set{localGoals=value;}
		}
		
		public int VisitorGoals {
			get{ return visitorGoals;}
			set{visitorGoals=value;}
		}
	
		
		public DateTime MatchDate {
			get{ return matchDate;}
			set{ matchDate=value;}
		}

		public bool Equals(Project project){
			return this.File.FilePath.Equals(project.File.FilePath);
		}
		
		public int CompareTo(object obj) {
			if(obj is Project) {
				Project project = (Project) obj;

				return this.File.FilePath.CompareTo(project.File.FilePath);
			}
			else
				throw new ArgumentException("object is not a Project and cannot be compared");    
		}
	}
}
