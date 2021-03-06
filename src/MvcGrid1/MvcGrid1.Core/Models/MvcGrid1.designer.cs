﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4927
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcGrid1.Core.Models
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[System.Data.Linq.Mapping.DatabaseAttribute(Name="MvcGrid1")]
	public partial class MvcGrid1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertName(Name instance);
    partial void UpdateName(Name instance);
    partial void DeleteName(Name instance);
    #endregion
		
		public MvcGrid1DataContext() : 
				base(global::MvcGrid1.Core.Properties.Settings.Default.MvcGrid1ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public MvcGrid1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MvcGrid1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MvcGrid1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MvcGrid1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Name> Names
		{
			get
			{
				return this.GetTable<Name>();
			}
		}
	}
	
	[Table(Name="dbo.Names")]
	public partial class Name : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _First;
		
		private string _Last;
		
		private System.DateTime _CreatedOn = default(System.DateTime);
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnFirstChanging(string value);
    partial void OnFirstChanged();
    partial void OnLastChanging(string value);
    partial void OnLastChanged();
    #endregion
		
		public Name()
		{
			OnCreated();
		}
		
		[Column(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[Column(Storage="_First", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string First
		{
			get
			{
				return this._First;
			}
			set
			{
				if ((this._First != value))
				{
					this.OnFirstChanging(value);
					this.SendPropertyChanging();
					this._First = value;
					this.SendPropertyChanged("First");
					this.OnFirstChanged();
				}
			}
		}
		
		[Column(Storage="_Last", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Last
		{
			get
			{
				return this._Last;
			}
			set
			{
				if ((this._Last != value))
				{
					this.OnLastChanging(value);
					this.SendPropertyChanging();
					this._Last = value;
					this.SendPropertyChanged("Last");
					this.OnLastChanged();
				}
			}
		}
		
		[Column(Storage="_CreatedOn", AutoSync=AutoSync.OnInsert, DbType="DateTime NOT NULL", IsDbGenerated=true, UpdateCheck=UpdateCheck.Never)]
		public System.DateTime CreatedOn
		{
			get
			{
				return this._CreatedOn;
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
