﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LinQ_projct
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Dropthebass")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertBand(Band instance);
    partial void UpdateBand(Band instance);
    partial void DeleteBand(Band instance);
    partial void InsertRecord(Record instance);
    partial void UpdateRecord(Record instance);
    partial void DeleteRecord(Record instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::LinQ_projct.Properties.Settings.Default.DropthebassConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Band> Bands
		{
			get
			{
				return this.GetTable<Band>();
			}
		}
		
		public System.Data.Linq.Table<Record> Records
		{
			get
			{
				return this.GetTable<Record>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Band")]
	public partial class Band : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Band_ID;
		
		private string _Band_Name;
		
		private string _Startyear;
		
		private string _From_Location;
		
		private string _Info;
		
		private System.Nullable<int> _Members;
		
		private EntitySet<Record> _Records;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnBand_IDChanging(int value);
    partial void OnBand_IDChanged();
    partial void OnBand_NameChanging(string value);
    partial void OnBand_NameChanged();
    partial void OnStartyearChanging(string value);
    partial void OnStartyearChanged();
    partial void OnFrom_LocationChanging(string value);
    partial void OnFrom_LocationChanged();
    partial void OnInfoChanging(string value);
    partial void OnInfoChanged();
    partial void OnMembersChanging(System.Nullable<int> value);
    partial void OnMembersChanged();
    #endregion
		
		public Band()
		{
			this._Records = new EntitySet<Record>(new Action<Record>(this.attach_Records), new Action<Record>(this.detach_Records));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Band_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Band_ID
		{
			get
			{
				return this._Band_ID;
			}
			set
			{
				if ((this._Band_ID != value))
				{
					this.OnBand_IDChanging(value);
					this.SendPropertyChanging();
					this._Band_ID = value;
					this.SendPropertyChanged("Band_ID");
					this.OnBand_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Band_Name", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
		public string Band_Name
		{
			get
			{
				return this._Band_Name;
			}
			set
			{
				if ((this._Band_Name != value))
				{
					this.OnBand_NameChanging(value);
					this.SendPropertyChanging();
					this._Band_Name = value;
					this.SendPropertyChanged("Band_Name");
					this.OnBand_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Startyear", DbType="VarChar(255)")]
		public string Startyear
		{
			get
			{
				return this._Startyear;
			}
			set
			{
				if ((this._Startyear != value))
				{
					this.OnStartyearChanging(value);
					this.SendPropertyChanging();
					this._Startyear = value;
					this.SendPropertyChanged("Startyear");
					this.OnStartyearChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_From_Location", DbType="VarChar(255)")]
		public string From_Location
		{
			get
			{
				return this._From_Location;
			}
			set
			{
				if ((this._From_Location != value))
				{
					this.OnFrom_LocationChanging(value);
					this.SendPropertyChanging();
					this._From_Location = value;
					this.SendPropertyChanged("From_Location");
					this.OnFrom_LocationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Info", DbType="VarChar(255)")]
		public string Info
		{
			get
			{
				return this._Info;
			}
			set
			{
				if ((this._Info != value))
				{
					this.OnInfoChanging(value);
					this.SendPropertyChanging();
					this._Info = value;
					this.SendPropertyChanged("Info");
					this.OnInfoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Members", DbType="Int")]
		public System.Nullable<int> Members
		{
			get
			{
				return this._Members;
			}
			set
			{
				if ((this._Members != value))
				{
					this.OnMembersChanging(value);
					this.SendPropertyChanging();
					this._Members = value;
					this.SendPropertyChanged("Members");
					this.OnMembersChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Band_Record", Storage="_Records", ThisKey="Band_ID", OtherKey="Band")]
		public EntitySet<Record> Records
		{
			get
			{
				return this._Records;
			}
			set
			{
				this._Records.Assign(value);
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
		
		private void attach_Records(Record entity)
		{
			this.SendPropertyChanging();
			entity.Band1 = this;
		}
		
		private void detach_Records(Record entity)
		{
			this.SendPropertyChanging();
			entity.Band1 = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Record")]
	public partial class Record : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Record_ID;
		
		private System.Nullable<int> _Band;
		
		private string _Record_name;
		
		private string _Company_Name;
		
		private string _Releasedate;
		
		private EntityRef<Band> _Band1;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnRecord_IDChanging(int value);
    partial void OnRecord_IDChanged();
    partial void OnBandChanging(System.Nullable<int> value);
    partial void OnBandChanged();
    partial void OnRecord_nameChanging(string value);
    partial void OnRecord_nameChanged();
    partial void OnCompany_NameChanging(string value);
    partial void OnCompany_NameChanged();
    partial void OnReleasedateChanging(string value);
    partial void OnReleasedateChanged();
    #endregion
		
		public Record()
		{
			this._Band1 = default(EntityRef<Band>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Record_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Record_ID
		{
			get
			{
				return this._Record_ID;
			}
			set
			{
				if ((this._Record_ID != value))
				{
					this.OnRecord_IDChanging(value);
					this.SendPropertyChanging();
					this._Record_ID = value;
					this.SendPropertyChanged("Record_ID");
					this.OnRecord_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Band", DbType="Int")]
		public System.Nullable<int> Band
		{
			get
			{
				return this._Band;
			}
			set
			{
				if ((this._Band != value))
				{
					if (this._Band1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnBandChanging(value);
					this.SendPropertyChanging();
					this._Band = value;
					this.SendPropertyChanged("Band");
					this.OnBandChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Record_name", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
		public string Record_name
		{
			get
			{
				return this._Record_name;
			}
			set
			{
				if ((this._Record_name != value))
				{
					this.OnRecord_nameChanging(value);
					this.SendPropertyChanging();
					this._Record_name = value;
					this.SendPropertyChanged("Record_name");
					this.OnRecord_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Company_Name", DbType="VarChar(255)")]
		public string Company_Name
		{
			get
			{
				return this._Company_Name;
			}
			set
			{
				if ((this._Company_Name != value))
				{
					this.OnCompany_NameChanging(value);
					this.SendPropertyChanging();
					this._Company_Name = value;
					this.SendPropertyChanged("Company_Name");
					this.OnCompany_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Releasedate", DbType="VarChar(255)")]
		public string Releasedate
		{
			get
			{
				return this._Releasedate;
			}
			set
			{
				if ((this._Releasedate != value))
				{
					this.OnReleasedateChanging(value);
					this.SendPropertyChanging();
					this._Releasedate = value;
					this.SendPropertyChanged("Releasedate");
					this.OnReleasedateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Band_Record", Storage="_Band1", ThisKey="Band", OtherKey="Band_ID", IsForeignKey=true)]
		public Band Band1
		{
			get
			{
				return this._Band1.Entity;
			}
			set
			{
				Band previousValue = this._Band1.Entity;
				if (((previousValue != value) 
							|| (this._Band1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Band1.Entity = null;
						previousValue.Records.Remove(this);
					}
					this._Band1.Entity = value;
					if ((value != null))
					{
						value.Records.Add(this);
						this._Band = value.Band_ID;
					}
					else
					{
						this._Band = default(Nullable<int>);
					}
					this.SendPropertyChanged("Band1");
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
