﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UsersViewer.Models.DB
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="User")]
	public partial class UsersDBDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertPosition(Position instance);
    partial void UpdatePosition(Position instance);
    partial void DeletePosition(Position instance);
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    #endregion
		
		public UsersDBDataContext() : 
				base(global::UsersViewer.Properties.Settings.Default.UsersConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public UsersDBDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public UsersDBDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public UsersDBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public UsersDBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Position> Positions
		{
			get
			{
				return this.GetTable<Position>();
			}
		}
		
		public System.Data.Linq.Table<User> Users
		{
			get
			{
				return this.GetTable<User>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Positions")]
	public partial class Position : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _ID;
		
		private string _PositionName;
		
		private string _PositionDescription;
		
		private EntitySet<User> _Users;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(long value);
    partial void OnIDChanged();
    partial void OnPositionNameChanging(string value);
    partial void OnPositionNameChanged();
    partial void OnPositionDescriptionChanging(string value);
    partial void OnPositionDescriptionChanged();
    #endregion
		
		public Position()
		{
			this._Users = new EntitySet<User>(new Action<User>(this.attach_Users), new Action<User>(this.detach_Users));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PositionName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string PositionName
		{
			get
			{
				return this._PositionName;
			}
			set
			{
				if ((this._PositionName != value))
				{
					this.OnPositionNameChanging(value);
					this.SendPropertyChanging();
					this._PositionName = value;
					this.SendPropertyChanged("PositionName");
					this.OnPositionNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PositionDescription", DbType="NVarChar(MAX)")]
		public string PositionDescription
		{
			get
			{
				return this._PositionDescription;
			}
			set
			{
				if ((this._PositionDescription != value))
				{
					this.OnPositionDescriptionChanging(value);
					this.SendPropertyChanging();
					this._PositionDescription = value;
					this.SendPropertyChanged("PositionDescription");
					this.OnPositionDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Position_User", Storage="_Users", ThisKey="ID", OtherKey="PositionID")]
		public EntitySet<User> Users
		{
			get
			{
				return this._Users;
			}
			set
			{
				this._Users.Assign(value);
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
		
		private void attach_Users(User entity)
		{
			this.SendPropertyChanging();
			entity.Position = this;
		}
		
		private void detach_Users(User entity)
		{
			this.SendPropertyChanging();
			entity.Position = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Users")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _ID;
		
		private string _FirstName;
		
		private string _LastName;
		
		private string _Email;
		
		private System.Data.Linq.Binary _Picture;
		
		private string _Description;
		
		private long _PositionID;
		
		private EntityRef<Position> _Position;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(long value);
    partial void OnIDChanged();
    partial void OnFirstNameChanging(string value);
    partial void OnFirstNameChanged();
    partial void OnLastNameChanging(string value);
    partial void OnLastNameChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnPictureChanging(System.Data.Linq.Binary value);
    partial void OnPictureChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnPositionIDChanging(long value);
    partial void OnPositionIDChanged();
    #endregion
		
		public User()
		{
			this._Position = default(EntityRef<Position>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string FirstName
		{
			get
			{
				return this._FirstName;
			}
			set
			{
				if ((this._FirstName != value))
				{
					this.OnFirstNameChanging(value);
					this.SendPropertyChanging();
					this._FirstName = value;
					this.SendPropertyChanged("FirstName");
					this.OnFirstNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string LastName
		{
			get
			{
				return this._LastName;
			}
			set
			{
				if ((this._LastName != value))
				{
					this.OnLastNameChanging(value);
					this.SendPropertyChanging();
					this._LastName = value;
					this.SendPropertyChanged("LastName");
					this.OnLastNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Picture", DbType="VarBinary(MAX)", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary Picture
		{
			get
			{
				return this._Picture;
			}
			set
			{
				if ((this._Picture != value))
				{
					this.OnPictureChanging(value);
					this.SendPropertyChanging();
					this._Picture = value;
					this.SendPropertyChanged("Picture");
					this.OnPictureChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NVarChar(MAX)")]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PositionID", DbType="BigInt NOT NULL")]
		public long PositionID
		{
			get
			{
				return this._PositionID;
			}
			set
			{
				if ((this._PositionID != value))
				{
					if (this._Position.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnPositionIDChanging(value);
					this.SendPropertyChanging();
					this._PositionID = value;
					this.SendPropertyChanged("PositionID");
					this.OnPositionIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Position_User", Storage="_Position", ThisKey="PositionID", OtherKey="ID", IsForeignKey=true)]
		public Position Position
		{
			get
			{
				return this._Position.Entity;
			}
			set
			{
				Position previousValue = this._Position.Entity;
				if (((previousValue != value) 
							|| (this._Position.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Position.Entity = null;
						previousValue.Users.Remove(this);
					}
					this._Position.Entity = value;
					if ((value != null))
					{
						value.Users.Add(this);
						this._PositionID = value.ID;
					}
					else
					{
						this._PositionID = default(long);
					}
					this.SendPropertyChanged("Position");
				}
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