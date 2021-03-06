﻿//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace Extraction
{
    #region 上下文
    
    /// <summary>
    /// 没有元数据文档可用。
    /// </summary>
    public partial class Week8Container : ObjectContext
    {
        #region 构造函数
    
        /// <summary>
        /// 请使用应用程序配置文件的“Week8Container”部分中的连接字符串初始化新 Week8Container 对象。
        /// </summary>
        public Week8Container() : base("name=Week8Container", "Week8Container")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// 初始化新的 Week8Container 对象。
        /// </summary>
        public Week8Container(string connectionString) : base(connectionString, "Week8Container")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// 初始化新的 Week8Container 对象。
        /// </summary>
        public Week8Container(EntityConnection connection) : base(connection, "Week8Container")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region 分部方法
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet 属性
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        public ObjectSet<Embedded> EmbeddedSet
        {
            get
            {
                if ((_EmbeddedSet == null))
                {
                    _EmbeddedSet = base.CreateObjectSet<Embedded>("EmbeddedSet");
                }
                return _EmbeddedSet;
            }
        }
        private ObjectSet<Embedded> _EmbeddedSet;
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        public ObjectSet<Duration> DurationSet
        {
            get
            {
                if ((_DurationSet == null))
                {
                    _DurationSet = base.CreateObjectSet<Duration>("DurationSet");
                }
                return _DurationSet;
            }
        }
        private ObjectSet<Duration> _DurationSet;
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        public ObjectSet<Activity_Count> Activity_CountSet
        {
            get
            {
                if ((_Activity_CountSet == null))
                {
                    _Activity_CountSet = base.CreateObjectSet<Activity_Count>("Activity_CountSet");
                }
                return _Activity_CountSet;
            }
        }
        private ObjectSet<Activity_Count> _Activity_CountSet;

        #endregion

        #region AddTo 方法
    
        /// <summary>
        /// 用于向 EmbeddedSet EntitySet 添加新对象的方法，已弃用。请考虑改用关联的 ObjectSet&lt;T&gt; 属性的 .Add 方法。
        /// </summary>
        public void AddToEmbeddedSet(Embedded embedded)
        {
            base.AddObject("EmbeddedSet", embedded);
        }
    
        /// <summary>
        /// 用于向 DurationSet EntitySet 添加新对象的方法，已弃用。请考虑改用关联的 ObjectSet&lt;T&gt; 属性的 .Add 方法。
        /// </summary>
        public void AddToDurationSet(Duration duration)
        {
            base.AddObject("DurationSet", duration);
        }
    
        /// <summary>
        /// 用于向 Activity_CountSet EntitySet 添加新对象的方法，已弃用。请考虑改用关联的 ObjectSet&lt;T&gt; 属性的 .Add 方法。
        /// </summary>
        public void AddToActivity_CountSet(Activity_Count activity_Count)
        {
            base.AddObject("Activity_CountSet", activity_Count);
        }

        #endregion

    }

    #endregion

    #region 实体
    
    /// <summary>
    /// 没有元数据文档可用。
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="Week8", Name="Activity_Count")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Activity_Count : EntityObject
    {
        #region 工厂方法
    
        /// <summary>
        /// 创建新的 Activity_Count 对象。
        /// </summary>
        /// <param name="id">Id 属性的初始值。</param>
        /// <param name="activity_id">Activity_id 属性的初始值。</param>
        /// <param name="number">Number 属性的初始值。</param>
        public static Activity_Count CreateActivity_Count(global::System.Int32 id, global::System.String activity_id, global::System.Int32 number)
        {
            Activity_Count activity_Count = new Activity_Count();
            activity_Count.Id = id;
            activity_Count.Activity_id = activity_id;
            activity_Count.Number = number;
            return activity_Count;
        }

        #endregion

        #region 基元属性
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Activity_id
        {
            get
            {
                return _Activity_id;
            }
            set
            {
                OnActivity_idChanging(value);
                ReportPropertyChanging("Activity_id");
                _Activity_id = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Activity_id");
                OnActivity_idChanged();
            }
        }
        private global::System.String _Activity_id;
        partial void OnActivity_idChanging(global::System.String value);
        partial void OnActivity_idChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Number
        {
            get
            {
                return _Number;
            }
            set
            {
                OnNumberChanging(value);
                ReportPropertyChanging("Number");
                _Number = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Number");
                OnNumberChanged();
            }
        }
        private global::System.Int32 _Number;
        partial void OnNumberChanging(global::System.Int32 value);
        partial void OnNumberChanged();

        #endregion

    
    }
    
    /// <summary>
    /// 没有元数据文档可用。
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="Week8", Name="Duration")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Duration : EntityObject
    {
        #region 工厂方法
    
        /// <summary>
        /// 创建新的 Duration 对象。
        /// </summary>
        /// <param name="id">Id 属性的初始值。</param>
        /// <param name="timeStamp">TimeStamp 属性的初始值。</param>
        /// <param name="activity_id">Activity_id 属性的初始值。</param>
        /// <param name="activity_duration">Activity_duration 属性的初始值。</param>
        public static Duration CreateDuration(global::System.Int32 id, global::System.DateTime timeStamp, global::System.String activity_id, global::System.String activity_duration)
        {
            Duration duration = new Duration();
            duration.Id = id;
            duration.TimeStamp = timeStamp;
            duration.Activity_id = activity_id;
            duration.Activity_duration = activity_duration;
            return duration;
        }

        #endregion

        #region 基元属性
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime TimeStamp
        {
            get
            {
                return _TimeStamp;
            }
            set
            {
                OnTimeStampChanging(value);
                ReportPropertyChanging("TimeStamp");
                _TimeStamp = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("TimeStamp");
                OnTimeStampChanged();
            }
        }
        private global::System.DateTime _TimeStamp;
        partial void OnTimeStampChanging(global::System.DateTime value);
        partial void OnTimeStampChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Activity_id
        {
            get
            {
                return _Activity_id;
            }
            set
            {
                OnActivity_idChanging(value);
                ReportPropertyChanging("Activity_id");
                _Activity_id = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Activity_id");
                OnActivity_idChanged();
            }
        }
        private global::System.String _Activity_id;
        partial void OnActivity_idChanging(global::System.String value);
        partial void OnActivity_idChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Activity_duration
        {
            get
            {
                return _Activity_duration;
            }
            set
            {
                OnActivity_durationChanging(value);
                ReportPropertyChanging("Activity_duration");
                _Activity_duration = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Activity_duration");
                OnActivity_durationChanged();
            }
        }
        private global::System.String _Activity_duration;
        partial void OnActivity_durationChanging(global::System.String value);
        partial void OnActivity_durationChanged();

        #endregion

    
    }
    
    /// <summary>
    /// 没有元数据文档可用。
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="Week8", Name="Embedded")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Embedded : EntityObject
    {
        #region 工厂方法
    
        /// <summary>
        /// 创建新的 Embedded 对象。
        /// </summary>
        /// <param name="id">Id 属性的初始值。</param>
        /// <param name="timeStamp">TimeStamp 属性的初始值。</param>
        /// <param name="item1">Item1 属性的初始值。</param>
        /// <param name="item2">Item2 属性的初始值。</param>
        public static Embedded CreateEmbedded(global::System.Int32 id, global::System.DateTime timeStamp, global::System.String item1, global::System.String item2)
        {
            Embedded embedded = new Embedded();
            embedded.Id = id;
            embedded.TimeStamp = timeStamp;
            embedded.Item1 = item1;
            embedded.Item2 = item2;
            return embedded;
        }

        #endregion

        #region 基元属性
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime TimeStamp
        {
            get
            {
                return _TimeStamp;
            }
            set
            {
                OnTimeStampChanging(value);
                ReportPropertyChanging("TimeStamp");
                _TimeStamp = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("TimeStamp");
                OnTimeStampChanged();
            }
        }
        private global::System.DateTime _TimeStamp;
        partial void OnTimeStampChanging(global::System.DateTime value);
        partial void OnTimeStampChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Item1
        {
            get
            {
                return _Item1;
            }
            set
            {
                OnItem1Changing(value);
                ReportPropertyChanging("Item1");
                _Item1 = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Item1");
                OnItem1Changed();
            }
        }
        private global::System.String _Item1;
        partial void OnItem1Changing(global::System.String value);
        partial void OnItem1Changed();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Item2
        {
            get
            {
                return _Item2;
            }
            set
            {
                OnItem2Changing(value);
                ReportPropertyChanging("Item2");
                _Item2 = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Item2");
                OnItem2Changed();
            }
        }
        private global::System.String _Item2;
        partial void OnItem2Changing(global::System.String value);
        partial void OnItem2Changed();

        #endregion

    
    }

    #endregion

    
}
