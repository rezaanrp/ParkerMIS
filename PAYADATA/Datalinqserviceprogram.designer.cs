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

namespace PAYADATA
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="payazobnet")]
	public partial class DatalinqserviceprogramDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertdevice(device instance);
    partial void Updatedevice(device instance);
    partial void Deletedevice(device instance);
    partial void Insertmdetailsdevice(mdetailsdevice instance);
    partial void Updatemdetailsdevice(mdetailsdevice instance);
    partial void Deletemdetailsdevice(mdetailsdevice instance);
    partial void Insertmserviceprogramheader(mserviceprogramheader instance);
    partial void Updatemserviceprogramheader(mserviceprogramheader instance);
    partial void Deletemserviceprogramheader(mserviceprogramheader instance);
    partial void Insertmserviceprogram(mserviceprogram instance);
    partial void Updatemserviceprogram(mserviceprogram instance);
    partial void Deletemserviceprogram(mserviceprogram instance);
    #endregion
		
		public DatalinqserviceprogramDataContext() : 
				base(global::PAYADATA.Properties.Settings.Default.payazobnetConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DatalinqserviceprogramDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DatalinqserviceprogramDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DatalinqserviceprogramDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DatalinqserviceprogramDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<device> devices
		{
			get
			{
				return this.GetTable<device>();
			}
		}
		
		public System.Data.Linq.Table<mdetailsdevice> mdetailsdevices
		{
			get
			{
				return this.GetTable<mdetailsdevice>();
			}
		}
		
		public System.Data.Linq.Table<mserviceprogramheader> mserviceprogramheaders
		{
			get
			{
				return this.GetTable<mserviceprogramheader>();
			}
		}
		
		public System.Data.Linq.Table<mserviceprogram> mserviceprograms
		{
			get
			{
				return this.GetTable<mserviceprogram>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.device")]
	public partial class device : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _xcod;
		
		private string _xiddevice;
		
		private string _xnumber;
		
		private string _xcodoflocation;
		
		private string _xmanufactur_serial_number;
		
		private string _xdateofmaking;
		
		private string _xdatestart;
		
		private string _xstatepurchase;
		
		private string _xautomation;
		
		private EntityRef<mdetailsdevice> _mdetailsdevice;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnxcodChanging(string value);
    partial void OnxcodChanged();
    partial void OnxiddeviceChanging(string value);
    partial void OnxiddeviceChanged();
    partial void OnxnumberChanging(string value);
    partial void OnxnumberChanged();
    partial void OnxcodoflocationChanging(string value);
    partial void OnxcodoflocationChanged();
    partial void Onxmanufactur_serial_numberChanging(string value);
    partial void Onxmanufactur_serial_numberChanged();
    partial void OnxdateofmakingChanging(string value);
    partial void OnxdateofmakingChanged();
    partial void OnxdatestartChanging(string value);
    partial void OnxdatestartChanged();
    partial void OnxstatepurchaseChanging(string value);
    partial void OnxstatepurchaseChanged();
    partial void OnxautomationChanging(string value);
    partial void OnxautomationChanged();
    #endregion
		
		public device()
		{
			this._mdetailsdevice = default(EntityRef<mdetailsdevice>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_xcod", DbType="NChar(6) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string xcod
		{
			get
			{
				return this._xcod;
			}
			set
			{
				if ((this._xcod != value))
				{
					this.OnxcodChanging(value);
					this.SendPropertyChanging();
					this._xcod = value;
					this.SendPropertyChanged("xcod");
					this.OnxcodChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_xiddevice", DbType="NChar(3) NOT NULL", CanBeNull=false)]
		public string xiddevice
		{
			get
			{
				return this._xiddevice;
			}
			set
			{
				if ((this._xiddevice != value))
				{
					if (this._mdetailsdevice.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnxiddeviceChanging(value);
					this.SendPropertyChanging();
					this._xiddevice = value;
					this.SendPropertyChanged("xiddevice");
					this.OnxiddeviceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_xnumber", DbType="NChar(2) NOT NULL", CanBeNull=false)]
		public string xnumber
		{
			get
			{
				return this._xnumber;
			}
			set
			{
				if ((this._xnumber != value))
				{
					this.OnxnumberChanging(value);
					this.SendPropertyChanging();
					this._xnumber = value;
					this.SendPropertyChanged("xnumber");
					this.OnxnumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_xcodoflocation", DbType="NChar(2)")]
		public string xcodoflocation
		{
			get
			{
				return this._xcodoflocation;
			}
			set
			{
				if ((this._xcodoflocation != value))
				{
					this.OnxcodoflocationChanging(value);
					this.SendPropertyChanging();
					this._xcodoflocation = value;
					this.SendPropertyChanged("xcodoflocation");
					this.OnxcodoflocationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_xmanufactur_serial_number", DbType="NVarChar(MAX)")]
		public string xmanufactur_serial_number
		{
			get
			{
				return this._xmanufactur_serial_number;
			}
			set
			{
				if ((this._xmanufactur_serial_number != value))
				{
					this.Onxmanufactur_serial_numberChanging(value);
					this.SendPropertyChanging();
					this._xmanufactur_serial_number = value;
					this.SendPropertyChanged("xmanufactur_serial_number");
					this.Onxmanufactur_serial_numberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_xdateofmaking", DbType="NChar(10)")]
		public string xdateofmaking
		{
			get
			{
				return this._xdateofmaking;
			}
			set
			{
				if ((this._xdateofmaking != value))
				{
					this.OnxdateofmakingChanging(value);
					this.SendPropertyChanging();
					this._xdateofmaking = value;
					this.SendPropertyChanged("xdateofmaking");
					this.OnxdateofmakingChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_xdatestart", DbType="NChar(10)")]
		public string xdatestart
		{
			get
			{
				return this._xdatestart;
			}
			set
			{
				if ((this._xdatestart != value))
				{
					this.OnxdatestartChanging(value);
					this.SendPropertyChanging();
					this._xdatestart = value;
					this.SendPropertyChanged("xdatestart");
					this.OnxdatestartChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_xstatepurchase", DbType="NVarChar(50)")]
		public string xstatepurchase
		{
			get
			{
				return this._xstatepurchase;
			}
			set
			{
				if ((this._xstatepurchase != value))
				{
					this.OnxstatepurchaseChanging(value);
					this.SendPropertyChanging();
					this._xstatepurchase = value;
					this.SendPropertyChanged("xstatepurchase");
					this.OnxstatepurchaseChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_xautomation", DbType="NVarChar(50)")]
		public string xautomation
		{
			get
			{
				return this._xautomation;
			}
			set
			{
				if ((this._xautomation != value))
				{
					this.OnxautomationChanging(value);
					this.SendPropertyChanging();
					this._xautomation = value;
					this.SendPropertyChanged("xautomation");
					this.OnxautomationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="mdetailsdevice_device", Storage="_mdetailsdevice", ThisKey="xiddevice", OtherKey="xcoddevice", IsForeignKey=true)]
		public mdetailsdevice mdetailsdevice
		{
			get
			{
				return this._mdetailsdevice.Entity;
			}
			set
			{
				mdetailsdevice previousValue = this._mdetailsdevice.Entity;
				if (((previousValue != value) 
							|| (this._mdetailsdevice.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._mdetailsdevice.Entity = null;
						previousValue.devices.Remove(this);
					}
					this._mdetailsdevice.Entity = value;
					if ((value != null))
					{
						value.devices.Add(this);
						this._xiddevice = value.xcoddevice;
					}
					else
					{
						this._xiddevice = default(string);
					}
					this.SendPropertyChanged("mdetailsdevice");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.mdetailsdevice")]
	public partial class mdetailsdevice : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _xid;
		
		private string _xnamedevice;
		
		private string _xEnglishname;
		
		private string _xcoddevice;
		
		private System.Nullable<int> _xcount;
		
		private System.Nullable<int> _xcountofoperator;
		
		private System.Nullable<float> _xweight;
		
		private System.Nullable<float> _xuseful_life;
		
		private EntitySet<device> _devices;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnxidChanging(int value);
    partial void OnxidChanged();
    partial void OnxnamedeviceChanging(string value);
    partial void OnxnamedeviceChanged();
    partial void OnxEnglishnameChanging(string value);
    partial void OnxEnglishnameChanged();
    partial void OnxcoddeviceChanging(string value);
    partial void OnxcoddeviceChanged();
    partial void OnxcountChanging(System.Nullable<int> value);
    partial void OnxcountChanged();
    partial void OnxcountofoperatorChanging(System.Nullable<int> value);
    partial void OnxcountofoperatorChanged();
    partial void OnxweightChanging(System.Nullable<float> value);
    partial void OnxweightChanged();
    partial void Onxuseful_lifeChanging(System.Nullable<float> value);
    partial void Onxuseful_lifeChanged();
    #endregion
		
		public mdetailsdevice()
		{
			this._devices = new EntitySet<device>(new Action<device>(this.attach_devices), new Action<device>(this.detach_devices));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_xid", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
		public int xid
		{
			get
			{
				return this._xid;
			}
			set
			{
				if ((this._xid != value))
				{
					this.OnxidChanging(value);
					this.SendPropertyChanging();
					this._xid = value;
					this.SendPropertyChanged("xid");
					this.OnxidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_xnamedevice", DbType="NVarChar(MAX)")]
		public string xnamedevice
		{
			get
			{
				return this._xnamedevice;
			}
			set
			{
				if ((this._xnamedevice != value))
				{
					this.OnxnamedeviceChanging(value);
					this.SendPropertyChanging();
					this._xnamedevice = value;
					this.SendPropertyChanged("xnamedevice");
					this.OnxnamedeviceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_xEnglishname", DbType="NVarChar(MAX)")]
		public string xEnglishname
		{
			get
			{
				return this._xEnglishname;
			}
			set
			{
				if ((this._xEnglishname != value))
				{
					this.OnxEnglishnameChanging(value);
					this.SendPropertyChanging();
					this._xEnglishname = value;
					this.SendPropertyChanged("xEnglishname");
					this.OnxEnglishnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_xcoddevice", DbType="NChar(3) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string xcoddevice
		{
			get
			{
				return this._xcoddevice;
			}
			set
			{
				if ((this._xcoddevice != value))
				{
					this.OnxcoddeviceChanging(value);
					this.SendPropertyChanging();
					this._xcoddevice = value;
					this.SendPropertyChanged("xcoddevice");
					this.OnxcoddeviceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_xcount", DbType="Int")]
		public System.Nullable<int> xcount
		{
			get
			{
				return this._xcount;
			}
			set
			{
				if ((this._xcount != value))
				{
					this.OnxcountChanging(value);
					this.SendPropertyChanging();
					this._xcount = value;
					this.SendPropertyChanged("xcount");
					this.OnxcountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_xcountofoperator", DbType="Int")]
		public System.Nullable<int> xcountofoperator
		{
			get
			{
				return this._xcountofoperator;
			}
			set
			{
				if ((this._xcountofoperator != value))
				{
					this.OnxcountofoperatorChanging(value);
					this.SendPropertyChanging();
					this._xcountofoperator = value;
					this.SendPropertyChanged("xcountofoperator");
					this.OnxcountofoperatorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_xweight", DbType="Real")]
		public System.Nullable<float> xweight
		{
			get
			{
				return this._xweight;
			}
			set
			{
				if ((this._xweight != value))
				{
					this.OnxweightChanging(value);
					this.SendPropertyChanging();
					this._xweight = value;
					this.SendPropertyChanged("xweight");
					this.OnxweightChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_xuseful_life", DbType="Real")]
		public System.Nullable<float> xuseful_life
		{
			get
			{
				return this._xuseful_life;
			}
			set
			{
				if ((this._xuseful_life != value))
				{
					this.Onxuseful_lifeChanging(value);
					this.SendPropertyChanging();
					this._xuseful_life = value;
					this.SendPropertyChanged("xuseful_life");
					this.Onxuseful_lifeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="mdetailsdevice_device", Storage="_devices", ThisKey="xcoddevice", OtherKey="xiddevice")]
		public EntitySet<device> devices
		{
			get
			{
				return this._devices;
			}
			set
			{
				this._devices.Assign(value);
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
		
		private void attach_devices(device entity)
		{
			this.SendPropertyChanging();
			entity.mdetailsdevice = this;
		}
		
		private void detach_devices(device entity)
		{
			this.SendPropertyChanging();
			entity.mdetailsdevice = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.mserviceprogramheader")]
	public partial class mserviceprogramheader : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _xid;
		
		private string _xyear;
		
		private string _xmonth;
		
		private System.Nullable<bool> _xismonthly;
		
		private System.Nullable<bool> _xCertified_net_Manager;
		
		private System.Nullable<int> _xiduser_Confirms_net;
		
		private System.Nullable<bool> _xCertified_Product_Manager;
		
		private System.Nullable<int> _xiduser_confirms_product;
		
		private System.Nullable<bool> _xCertified_Planning_Manager;
		
		private System.Nullable<int> _xiduser_confirms_planing;
		
		private System.Nullable<bool> _xCertified_Manager;
		
		private System.Nullable<int> _xiduser_confirms_manager;
		
		private EntitySet<mserviceprogram> _mserviceprograms;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnxidChanging(int value);
    partial void OnxidChanged();
    partial void OnxyearChanging(string value);
    partial void OnxyearChanged();
    partial void OnxmonthChanging(string value);
    partial void OnxmonthChanged();
    partial void OnxismonthlyChanging(System.Nullable<bool> value);
    partial void OnxismonthlyChanged();
    partial void OnxCertified_net_ManagerChanging(System.Nullable<bool> value);
    partial void OnxCertified_net_ManagerChanged();
    partial void Onxiduser_Confirms_netChanging(System.Nullable<int> value);
    partial void Onxiduser_Confirms_netChanged();
    partial void OnxCertified_Product_ManagerChanging(System.Nullable<bool> value);
    partial void OnxCertified_Product_ManagerChanged();
    partial void Onxiduser_confirms_productChanging(System.Nullable<int> value);
    partial void Onxiduser_confirms_productChanged();
    partial void OnxCertified_Planning_ManagerChanging(System.Nullable<bool> value);
    partial void OnxCertified_Planning_ManagerChanged();
    partial void Onxiduser_confirms_planingChanging(System.Nullable<int> value);
    partial void Onxiduser_confirms_planingChanged();
    partial void OnxCertified_ManagerChanging(System.Nullable<bool> value);
    partial void OnxCertified_ManagerChanged();
    partial void Onxiduser_confirms_managerChanging(System.Nullable<int> value);
    partial void Onxiduser_confirms_managerChanged();
    #endregion
		
		public mserviceprogramheader()
		{
			this._mserviceprograms = new EntitySet<mserviceprogram>(new Action<mserviceprogram>(this.attach_mserviceprograms), new Action<mserviceprogram>(this.detach_mserviceprograms));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_xid", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int xid
		{
			get
			{
				return this._xid;
			}
			set
			{
				if ((this._xid != value))
				{
					this.OnxidChanging(value);
					this.SendPropertyChanging();
					this._xid = value;
					this.SendPropertyChanged("xid");
					this.OnxidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_xyear", DbType="NChar(4)")]
		public string xyear
		{
			get
			{
				return this._xyear;
			}
			set
			{
				if ((this._xyear != value))
				{
					this.OnxyearChanging(value);
					this.SendPropertyChanging();
					this._xyear = value;
					this.SendPropertyChanged("xyear");
					this.OnxyearChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_xmonth", DbType="NChar(2)")]
		public string xmonth
		{
			get
			{
				return this._xmonth;
			}
			set
			{
				if ((this._xmonth != value))
				{
					this.OnxmonthChanging(value);
					this.SendPropertyChanging();
					this._xmonth = value;
					this.SendPropertyChanged("xmonth");
					this.OnxmonthChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_xismonthly", DbType="Bit")]
		public System.Nullable<bool> xismonthly
		{
			get
			{
				return this._xismonthly;
			}
			set
			{
				if ((this._xismonthly != value))
				{
					this.OnxismonthlyChanging(value);
					this.SendPropertyChanging();
					this._xismonthly = value;
					this.SendPropertyChanged("xismonthly");
					this.OnxismonthlyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_xCertified_net_Manager", DbType="Bit")]
		public System.Nullable<bool> xCertified_net_Manager
		{
			get
			{
				return this._xCertified_net_Manager;
			}
			set
			{
				if ((this._xCertified_net_Manager != value))
				{
					this.OnxCertified_net_ManagerChanging(value);
					this.SendPropertyChanging();
					this._xCertified_net_Manager = value;
					this.SendPropertyChanged("xCertified_net_Manager");
					this.OnxCertified_net_ManagerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_xiduser_Confirms_net", DbType="Int")]
		public System.Nullable<int> xiduser_Confirms_net
		{
			get
			{
				return this._xiduser_Confirms_net;
			}
			set
			{
				if ((this._xiduser_Confirms_net != value))
				{
					this.Onxiduser_Confirms_netChanging(value);
					this.SendPropertyChanging();
					this._xiduser_Confirms_net = value;
					this.SendPropertyChanged("xiduser_Confirms_net");
					this.Onxiduser_Confirms_netChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_xCertified_Product_Manager", DbType="Bit")]
		public System.Nullable<bool> xCertified_Product_Manager
		{
			get
			{
				return this._xCertified_Product_Manager;
			}
			set
			{
				if ((this._xCertified_Product_Manager != value))
				{
					this.OnxCertified_Product_ManagerChanging(value);
					this.SendPropertyChanging();
					this._xCertified_Product_Manager = value;
					this.SendPropertyChanged("xCertified_Product_Manager");
					this.OnxCertified_Product_ManagerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_xiduser_confirms_product", DbType="Int")]
		public System.Nullable<int> xiduser_confirms_product
		{
			get
			{
				return this._xiduser_confirms_product;
			}
			set
			{
				if ((this._xiduser_confirms_product != value))
				{
					this.Onxiduser_confirms_productChanging(value);
					this.SendPropertyChanging();
					this._xiduser_confirms_product = value;
					this.SendPropertyChanged("xiduser_confirms_product");
					this.Onxiduser_confirms_productChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_xCertified_Planning_Manager", DbType="Bit")]
		public System.Nullable<bool> xCertified_Planning_Manager
		{
			get
			{
				return this._xCertified_Planning_Manager;
			}
			set
			{
				if ((this._xCertified_Planning_Manager != value))
				{
					this.OnxCertified_Planning_ManagerChanging(value);
					this.SendPropertyChanging();
					this._xCertified_Planning_Manager = value;
					this.SendPropertyChanged("xCertified_Planning_Manager");
					this.OnxCertified_Planning_ManagerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_xiduser_confirms_planing", DbType="Int")]
		public System.Nullable<int> xiduser_confirms_planing
		{
			get
			{
				return this._xiduser_confirms_planing;
			}
			set
			{
				if ((this._xiduser_confirms_planing != value))
				{
					this.Onxiduser_confirms_planingChanging(value);
					this.SendPropertyChanging();
					this._xiduser_confirms_planing = value;
					this.SendPropertyChanged("xiduser_confirms_planing");
					this.Onxiduser_confirms_planingChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_xCertified_Manager", DbType="Bit")]
		public System.Nullable<bool> xCertified_Manager
		{
			get
			{
				return this._xCertified_Manager;
			}
			set
			{
				if ((this._xCertified_Manager != value))
				{
					this.OnxCertified_ManagerChanging(value);
					this.SendPropertyChanging();
					this._xCertified_Manager = value;
					this.SendPropertyChanged("xCertified_Manager");
					this.OnxCertified_ManagerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_xiduser_confirms_manager", DbType="Int")]
		public System.Nullable<int> xiduser_confirms_manager
		{
			get
			{
				return this._xiduser_confirms_manager;
			}
			set
			{
				if ((this._xiduser_confirms_manager != value))
				{
					this.Onxiduser_confirms_managerChanging(value);
					this.SendPropertyChanging();
					this._xiduser_confirms_manager = value;
					this.SendPropertyChanged("xiduser_confirms_manager");
					this.Onxiduser_confirms_managerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="mserviceprogramheader_mserviceprogram", Storage="_mserviceprograms", ThisKey="xid", OtherKey="xidservice")]
		public EntitySet<mserviceprogram> mserviceprograms
		{
			get
			{
				return this._mserviceprograms;
			}
			set
			{
				this._mserviceprograms.Assign(value);
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
		
		private void attach_mserviceprograms(mserviceprogram entity)
		{
			this.SendPropertyChanging();
			entity.mserviceprogramheader = this;
		}
		
		private void detach_mserviceprograms(mserviceprogram entity)
		{
			this.SendPropertyChanging();
			entity.mserviceprogramheader = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.mserviceprogram")]
	public partial class mserviceprogram : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _xid;
		
		private System.Nullable<int> _xidservice;
		
		private string _xdevicecod;
		
		private string _xdevicenumber;
		
		private string _xdate;
		
		private string _xtimestart;
		
		private string _xtimeend;
		
		private bool _xMonthly;
		
		private System.Nullable<int> _xresult;
		
		private string _xexplain;
		
		private EntityRef<mserviceprogramheader> _mserviceprogramheader;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnxidChanging(int value);
    partial void OnxidChanged();
    partial void OnxidserviceChanging(System.Nullable<int> value);
    partial void OnxidserviceChanged();
    partial void OnxdevicecodChanging(string value);
    partial void OnxdevicecodChanged();
    partial void OnxdevicenumberChanging(string value);
    partial void OnxdevicenumberChanged();
    partial void OnxdateChanging(string value);
    partial void OnxdateChanged();
    partial void OnxtimestartChanging(string value);
    partial void OnxtimestartChanged();
    partial void OnxtimeendChanging(string value);
    partial void OnxtimeendChanged();
    partial void OnxMonthlyChanging(bool value);
    partial void OnxMonthlyChanged();
    partial void OnxresultChanging(System.Nullable<int> value);
    partial void OnxresultChanged();
    partial void OnxexplainChanging(string value);
    partial void OnxexplainChanged();
    #endregion
		
		public mserviceprogram()
		{
			this._mserviceprogramheader = default(EntityRef<mserviceprogramheader>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_xid", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int xid
		{
			get
			{
				return this._xid;
			}
			set
			{
				if ((this._xid != value))
				{
					this.OnxidChanging(value);
					this.SendPropertyChanging();
					this._xid = value;
					this.SendPropertyChanged("xid");
					this.OnxidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_xidservice", DbType="Int")]
		public System.Nullable<int> xidservice
		{
			get
			{
				return this._xidservice;
			}
			set
			{
				if ((this._xidservice != value))
				{
					if (this._mserviceprogramheader.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnxidserviceChanging(value);
					this.SendPropertyChanging();
					this._xidservice = value;
					this.SendPropertyChanged("xidservice");
					this.OnxidserviceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_xdevicecod", DbType="NChar(3)")]
		public string xdevicecod
		{
			get
			{
				return this._xdevicecod;
			}
			set
			{
				if ((this._xdevicecod != value))
				{
					this.OnxdevicecodChanging(value);
					this.SendPropertyChanging();
					this._xdevicecod = value;
					this.SendPropertyChanged("xdevicecod");
					this.OnxdevicecodChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_xdevicenumber", DbType="NChar(2)")]
		public string xdevicenumber
		{
			get
			{
				return this._xdevicenumber;
			}
			set
			{
				if ((this._xdevicenumber != value))
				{
					this.OnxdevicenumberChanging(value);
					this.SendPropertyChanging();
					this._xdevicenumber = value;
					this.SendPropertyChanged("xdevicenumber");
					this.OnxdevicenumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_xdate", DbType="Char(10)")]
		public string xdate
		{
			get
			{
				return this._xdate;
			}
			set
			{
				if ((this._xdate != value))
				{
					this.OnxdateChanging(value);
					this.SendPropertyChanging();
					this._xdate = value;
					this.SendPropertyChanged("xdate");
					this.OnxdateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_xtimestart", DbType="NChar(5)")]
		public string xtimestart
		{
			get
			{
				return this._xtimestart;
			}
			set
			{
				if ((this._xtimestart != value))
				{
					this.OnxtimestartChanging(value);
					this.SendPropertyChanging();
					this._xtimestart = value;
					this.SendPropertyChanged("xtimestart");
					this.OnxtimestartChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_xtimeend", DbType="NChar(5)")]
		public string xtimeend
		{
			get
			{
				return this._xtimeend;
			}
			set
			{
				if ((this._xtimeend != value))
				{
					this.OnxtimeendChanging(value);
					this.SendPropertyChanging();
					this._xtimeend = value;
					this.SendPropertyChanged("xtimeend");
					this.OnxtimeendChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_xMonthly", DbType="Bit NOT NULL")]
		public bool xMonthly
		{
			get
			{
				return this._xMonthly;
			}
			set
			{
				if ((this._xMonthly != value))
				{
					this.OnxMonthlyChanging(value);
					this.SendPropertyChanging();
					this._xMonthly = value;
					this.SendPropertyChanged("xMonthly");
					this.OnxMonthlyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_xresult", DbType="Int")]
		public System.Nullable<int> xresult
		{
			get
			{
				return this._xresult;
			}
			set
			{
				if ((this._xresult != value))
				{
					this.OnxresultChanging(value);
					this.SendPropertyChanging();
					this._xresult = value;
					this.SendPropertyChanged("xresult");
					this.OnxresultChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_xexplain", DbType="NVarChar(MAX)")]
		public string xexplain
		{
			get
			{
				return this._xexplain;
			}
			set
			{
				if ((this._xexplain != value))
				{
					this.OnxexplainChanging(value);
					this.SendPropertyChanging();
					this._xexplain = value;
					this.SendPropertyChanged("xexplain");
					this.OnxexplainChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="mserviceprogramheader_mserviceprogram", Storage="_mserviceprogramheader", ThisKey="xidservice", OtherKey="xid", IsForeignKey=true)]
		public mserviceprogramheader mserviceprogramheader
		{
			get
			{
				return this._mserviceprogramheader.Entity;
			}
			set
			{
				mserviceprogramheader previousValue = this._mserviceprogramheader.Entity;
				if (((previousValue != value) 
							|| (this._mserviceprogramheader.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._mserviceprogramheader.Entity = null;
						previousValue.mserviceprograms.Remove(this);
					}
					this._mserviceprogramheader.Entity = value;
					if ((value != null))
					{
						value.mserviceprograms.Add(this);
						this._xidservice = value.xid;
					}
					else
					{
						this._xidservice = default(Nullable<int>);
					}
					this.SendPropertyChanged("mserviceprogramheader");
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
