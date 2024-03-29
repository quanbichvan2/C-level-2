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

namespace ASM_PS28709_QuanBichVan_SD18322.Data
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Asingment_C#2")]
	public partial class YunDBDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertClass(Class instance);
    partial void UpdateClass(Class instance);
    partial void DeleteClass(Class instance);
    partial void InsertStudent(Student instance);
    partial void UpdateStudent(Student instance);
    partial void DeleteStudent(Student instance);
    #endregion
		
		public YunDBDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public YunDBDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public YunDBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public YunDBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Class> Classes
		{
			get
			{
				return this.GetTable<Class>();
			}
		}
		
		public System.Data.Linq.Table<Student> Students
		{
			get
			{
				return this.GetTable<Student>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Class")]
	public partial class Class : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idClass;
		
		private string _NameClass;
		
		private EntitySet<Student> _Students;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidClassChanging(int value);
    partial void OnidClassChanged();
    partial void OnNameClassChanging(string value);
    partial void OnNameClassChanged();
    #endregion
		
		public Class()
		{
			this._Students = new EntitySet<Student>(new Action<Student>(this.attach_Students), new Action<Student>(this.detach_Students));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idClass", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int idClass
		{
			get
			{
				return this._idClass;
			}
			set
			{
				if ((this._idClass != value))
				{
					this.OnidClassChanging(value);
					this.SendPropertyChanging();
					this._idClass = value;
					this.SendPropertyChanged("idClass");
					this.OnidClassChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NameClass", DbType="NVarChar(50)")]
		public string NameClass
		{
			get
			{
				return this._NameClass;
			}
			set
			{
				if ((this._NameClass != value))
				{
					this.OnNameClassChanging(value);
					this.SendPropertyChanging();
					this._NameClass = value;
					this.SendPropertyChanged("NameClass");
					this.OnNameClassChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Class_Student", Storage="_Students", ThisKey="idClass", OtherKey="idClass")]
		public EntitySet<Student> Students
		{
			get
			{
				return this._Students;
			}
			set
			{
				this._Students.Assign(value);
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
		
		private void attach_Students(Student entity)
		{
			this.SendPropertyChanging();
			entity.Class = this;
		}
		
		private void detach_Students(Student entity)
		{
			this.SendPropertyChanging();
			entity.Class = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Student")]
	public partial class Student : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _StID;
		
		private string _Name;
		
		private System.Nullable<double> _Mark;
		
		private string _Email;
		
		private System.Nullable<int> _idClass;
		
		private EntityRef<Class> _Class;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnStIDChanging(int value);
    partial void OnStIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnMarkChanging(System.Nullable<double> value);
    partial void OnMarkChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnidClassChanging(System.Nullable<int> value);
    partial void OnidClassChanged();
    #endregion
		
		public Student()
		{
			this._Class = default(EntityRef<Class>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int StID
		{
			get
			{
				return this._StID;
			}
			set
			{
				if ((this._StID != value))
				{
					this.OnStIDChanging(value);
					this.SendPropertyChanging();
					this._StID = value;
					this.SendPropertyChanged("StID");
					this.OnStIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Mark", DbType="Float")]
		public System.Nullable<double> Mark
		{
			get
			{
				return this._Mark;
			}
			set
			{
				if ((this._Mark != value))
				{
					this.OnMarkChanging(value);
					this.SendPropertyChanging();
					this._Mark = value;
					this.SendPropertyChanged("Mark");
					this.OnMarkChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(50)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idClass", DbType="Int")]
		public System.Nullable<int> idClass
		{
			get
			{
				return this._idClass;
			}
			set
			{
				if ((this._idClass != value))
				{
					if (this._Class.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidClassChanging(value);
					this.SendPropertyChanging();
					this._idClass = value;
					this.SendPropertyChanged("idClass");
					this.OnidClassChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Class_Student", Storage="_Class", ThisKey="idClass", OtherKey="idClass", IsForeignKey=true)]
		public Class Class
		{
			get
			{
				return this._Class.Entity;
			}
			set
			{
				Class previousValue = this._Class.Entity;
				if (((previousValue != value) 
							|| (this._Class.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Class.Entity = null;
						previousValue.Students.Remove(this);
					}
					this._Class.Entity = value;
					if ((value != null))
					{
						value.Students.Add(this);
						this._idClass = value.idClass;
					}
					else
					{
						this._idClass = default(Nullable<int>);
					}
					this.SendPropertyChanged("Class");
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
