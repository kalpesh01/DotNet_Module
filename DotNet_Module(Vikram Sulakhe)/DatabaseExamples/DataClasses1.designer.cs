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

namespace DatabaseExamples
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="emp")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertdept(dept instance);
    partial void Updatedept(dept instance);
    partial void Deletedept(dept instance);
    partial void Insertemployee(employee instance);
    partial void Updateemployee(employee instance);
    partial void Deleteemployee(employee instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::DatabaseExamples.Properties.Settings.Default.empConnectionString, mappingSource)
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
		
		public System.Data.Linq.Table<dept> depts
		{
			get
			{
				return this.GetTable<dept>();
			}
		}
		
		public System.Data.Linq.Table<employee> employees
		{
			get
			{
				return this.GetTable<employee>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.dept")]
	public partial class dept : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _deptId;
		
		private string _deptName;
		
		private EntitySet<employee> _employees;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OndeptIdChanging(int value);
    partial void OndeptIdChanged();
    partial void OndeptNameChanging(string value);
    partial void OndeptNameChanged();
    #endregion
		
		public dept()
		{
			this._employees = new EntitySet<employee>(new Action<employee>(this.attach_employees), new Action<employee>(this.detach_employees));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_deptId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int deptId
		{
			get
			{
				return this._deptId;
			}
			set
			{
				if ((this._deptId != value))
				{
					this.OndeptIdChanging(value);
					this.SendPropertyChanging();
					this._deptId = value;
					this.SendPropertyChanged("deptId");
					this.OndeptIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_deptName", DbType="VarChar(50)")]
		public string deptName
		{
			get
			{
				return this._deptName;
			}
			set
			{
				if ((this._deptName != value))
				{
					this.OndeptNameChanging(value);
					this.SendPropertyChanging();
					this._deptName = value;
					this.SendPropertyChanged("deptName");
					this.OndeptNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="dept_employee", Storage="_employees", ThisKey="deptId", OtherKey="deptId")]
		public EntitySet<employee> employees
		{
			get
			{
				return this._employees;
			}
			set
			{
				this._employees.Assign(value);
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
		
		private void attach_employees(employee entity)
		{
			this.SendPropertyChanging();
			entity.dept = this;
		}
		
		private void detach_employees(employee entity)
		{
			this.SendPropertyChanging();
			entity.dept = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.employee")]
	public partial class employee : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _empid;
		
		private string _empName;
		
		private string _empSalary;
		
		private int _deptId;
		
		private EntityRef<dept> _dept;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnempidChanging(int value);
    partial void OnempidChanged();
    partial void OnempNameChanging(string value);
    partial void OnempNameChanged();
    partial void OnempSalaryChanging(string value);
    partial void OnempSalaryChanged();
    partial void OndeptIdChanging(int value);
    partial void OndeptIdChanged();
    #endregion
		
		public employee()
		{
			this._dept = default(EntityRef<dept>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_empid", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int empid
		{
			get
			{
				return this._empid;
			}
			set
			{
				if ((this._empid != value))
				{
					this.OnempidChanging(value);
					this.SendPropertyChanging();
					this._empid = value;
					this.SendPropertyChanged("empid");
					this.OnempidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_empName", DbType="VarChar(50)")]
		public string empName
		{
			get
			{
				return this._empName;
			}
			set
			{
				if ((this._empName != value))
				{
					this.OnempNameChanging(value);
					this.SendPropertyChanging();
					this._empName = value;
					this.SendPropertyChanged("empName");
					this.OnempNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_empSalary", DbType="VarChar(50)")]
		public string empSalary
		{
			get
			{
				return this._empSalary;
			}
			set
			{
				if ((this._empSalary != value))
				{
					this.OnempSalaryChanging(value);
					this.SendPropertyChanging();
					this._empSalary = value;
					this.SendPropertyChanged("empSalary");
					this.OnempSalaryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_deptId", DbType="Int NOT NULL")]
		public int deptId
		{
			get
			{
				return this._deptId;
			}
			set
			{
				if ((this._deptId != value))
				{
					if (this._dept.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OndeptIdChanging(value);
					this.SendPropertyChanging();
					this._deptId = value;
					this.SendPropertyChanged("deptId");
					this.OndeptIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="dept_employee", Storage="_dept", ThisKey="deptId", OtherKey="deptId", IsForeignKey=true)]
		public dept dept
		{
			get
			{
				return this._dept.Entity;
			}
			set
			{
				dept previousValue = this._dept.Entity;
				if (((previousValue != value) 
							|| (this._dept.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._dept.Entity = null;
						previousValue.employees.Remove(this);
					}
					this._dept.Entity = value;
					if ((value != null))
					{
						value.employees.Add(this);
						this._deptId = value.deptId;
					}
					else
					{
						this._deptId = default(int);
					}
					this.SendPropertyChanged("dept");
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
