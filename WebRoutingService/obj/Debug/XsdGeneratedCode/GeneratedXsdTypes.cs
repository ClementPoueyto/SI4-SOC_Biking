//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebProxyService.ContractTypes
{
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MSBuild", "16.9.0+57a23d249aafe6409b3e24836a486f769cb74c2c")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://tempuri.org/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://tempuri.org/", IsNullable=false)]
    public partial class GetData
    {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MSBuild", "16.9.0+57a23d249aafe6409b3e24836a486f769cb74c2c")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/WebProxyService")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://schemas.datacontract.org/2004/07/WebProxyService", IsNullable=true)]
    public partial class CompositeType
    {
        
        private bool boolValueField;
        
        private bool boolValueFieldSpecified;
        
        private string stringValueField;
        
        /// <remarks/>
        public bool BoolValue
        {
            get
            {
                return this.boolValueField;
            }
            set
            {
                this.boolValueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BoolValueSpecified
        {
            get
            {
                return this.boolValueFieldSpecified;
            }
            set
            {
                this.boolValueFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string StringValue
        {
            get
            {
                return this.stringValueField;
            }
            set
            {
                this.stringValueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MSBuild", "16.9.0+57a23d249aafe6409b3e24836a486f769cb74c2c")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/WebProxyService")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://schemas.datacontract.org/2004/07/WebProxyService", IsNullable=true)]
    public partial class Position
    {
        
        private double latitudeField;
        
        private bool latitudeFieldSpecified;
        
        private double longitudeField;
        
        private bool longitudeFieldSpecified;
        
        /// <remarks/>
        public double latitude
        {
            get
            {
                return this.latitudeField;
            }
            set
            {
                this.latitudeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool latitudeSpecified
        {
            get
            {
                return this.latitudeFieldSpecified;
            }
            set
            {
                this.latitudeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public double longitude
        {
            get
            {
                return this.longitudeField;
            }
            set
            {
                this.longitudeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool longitudeSpecified
        {
            get
            {
                return this.longitudeFieldSpecified;
            }
            set
            {
                this.longitudeFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MSBuild", "16.9.0+57a23d249aafe6409b3e24836a486f769cb74c2c")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/WebProxyService")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://schemas.datacontract.org/2004/07/WebProxyService", IsNullable=true)]
    public partial class Availabilities
    {
        
        private int bikesField;
        
        private bool bikesFieldSpecified;
        
        private int bikmechanicalBikesesField;
        
        private bool bikmechanicalBikesesFieldSpecified;
        
        private int electricalBikesField;
        
        private bool electricalBikesFieldSpecified;
        
        private int electricalInternalBatteryBikesField;
        
        private bool electricalInternalBatteryBikesFieldSpecified;
        
        private int electricalRemovableBatteryBikesField;
        
        private bool electricalRemovableBatteryBikesFieldSpecified;
        
        private int standsField;
        
        private bool standsFieldSpecified;
        
        /// <remarks/>
        public int bikes
        {
            get
            {
                return this.bikesField;
            }
            set
            {
                this.bikesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool bikesSpecified
        {
            get
            {
                return this.bikesFieldSpecified;
            }
            set
            {
                this.bikesFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public int bikmechanicalBikeses
        {
            get
            {
                return this.bikmechanicalBikesesField;
            }
            set
            {
                this.bikmechanicalBikesesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool bikmechanicalBikesesSpecified
        {
            get
            {
                return this.bikmechanicalBikesesFieldSpecified;
            }
            set
            {
                this.bikmechanicalBikesesFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public int electricalBikes
        {
            get
            {
                return this.electricalBikesField;
            }
            set
            {
                this.electricalBikesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool electricalBikesSpecified
        {
            get
            {
                return this.electricalBikesFieldSpecified;
            }
            set
            {
                this.electricalBikesFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public int electricalInternalBatteryBikes
        {
            get
            {
                return this.electricalInternalBatteryBikesField;
            }
            set
            {
                this.electricalInternalBatteryBikesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool electricalInternalBatteryBikesSpecified
        {
            get
            {
                return this.electricalInternalBatteryBikesFieldSpecified;
            }
            set
            {
                this.electricalInternalBatteryBikesFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public int electricalRemovableBatteryBikes
        {
            get
            {
                return this.electricalRemovableBatteryBikesField;
            }
            set
            {
                this.electricalRemovableBatteryBikesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool electricalRemovableBatteryBikesSpecified
        {
            get
            {
                return this.electricalRemovableBatteryBikesFieldSpecified;
            }
            set
            {
                this.electricalRemovableBatteryBikesFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public int stands
        {
            get
            {
                return this.standsField;
            }
            set
            {
                this.standsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool standsSpecified
        {
            get
            {
                return this.standsFieldSpecified;
            }
            set
            {
                this.standsFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MSBuild", "16.9.0+57a23d249aafe6409b3e24836a486f769cb74c2c")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/WebProxyService")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://schemas.datacontract.org/2004/07/WebProxyService", IsNullable=true)]
    public partial class Stand
    {
        
        private Availabilities availabilitiesField;
        
        private int capacityField;
        
        private bool capacityFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public Availabilities availabilities
        {
            get
            {
                return this.availabilitiesField;
            }
            set
            {
                this.availabilitiesField = value;
            }
        }
        
        /// <remarks/>
        public int capacity
        {
            get
            {
                return this.capacityField;
            }
            set
            {
                this.capacityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool capacitySpecified
        {
            get
            {
                return this.capacityFieldSpecified;
            }
            set
            {
                this.capacityFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MSBuild", "16.9.0+57a23d249aafe6409b3e24836a486f769cb74c2c")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/WebProxyService")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://schemas.datacontract.org/2004/07/WebProxyService", IsNullable=true)]
    public partial class Station
    {
        
        private string addressField;
        
        private bool bankingField;
        
        private bool bankingFieldSpecified;
        
        private bool bonusField;
        
        private bool bonusFieldSpecified;
        
        private bool connectedField;
        
        private bool connectedFieldSpecified;
        
        private string contractNameField;
        
        private Stand mainStandsField;
        
        private string nameField;
        
        private int numberField;
        
        private bool numberFieldSpecified;
        
        private bool overflowField;
        
        private bool overflowFieldSpecified;
        
        private Stand overflowStandsField;
        
        private Position positionField;
        
        private string shapeField;
        
        private string statusField;
        
        private Stand totalStandsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }
        
        /// <remarks/>
        public bool banking
        {
            get
            {
                return this.bankingField;
            }
            set
            {
                this.bankingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool bankingSpecified
        {
            get
            {
                return this.bankingFieldSpecified;
            }
            set
            {
                this.bankingFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public bool bonus
        {
            get
            {
                return this.bonusField;
            }
            set
            {
                this.bonusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool bonusSpecified
        {
            get
            {
                return this.bonusFieldSpecified;
            }
            set
            {
                this.bonusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public bool connected
        {
            get
            {
                return this.connectedField;
            }
            set
            {
                this.connectedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool connectedSpecified
        {
            get
            {
                return this.connectedFieldSpecified;
            }
            set
            {
                this.connectedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string contractName
        {
            get
            {
                return this.contractNameField;
            }
            set
            {
                this.contractNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public Stand mainStands
        {
            get
            {
                return this.mainStandsField;
            }
            set
            {
                this.mainStandsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public int number
        {
            get
            {
                return this.numberField;
            }
            set
            {
                this.numberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool numberSpecified
        {
            get
            {
                return this.numberFieldSpecified;
            }
            set
            {
                this.numberFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public bool overflow
        {
            get
            {
                return this.overflowField;
            }
            set
            {
                this.overflowField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool overflowSpecified
        {
            get
            {
                return this.overflowFieldSpecified;
            }
            set
            {
                this.overflowFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public Stand overflowStands
        {
            get
            {
                return this.overflowStandsField;
            }
            set
            {
                this.overflowStandsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public Position position
        {
            get
            {
                return this.positionField;
            }
            set
            {
                this.positionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string shape
        {
            get
            {
                return this.shapeField;
            }
            set
            {
                this.shapeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public Stand totalStands
        {
            get
            {
                return this.totalStandsField;
            }
            set
            {
                this.totalStandsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MSBuild", "16.9.0+57a23d249aafe6409b3e24836a486f769cb74c2c")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://tempuri.org/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://tempuri.org/", IsNullable=false)]
    public partial class GetDataResponse
    {
        
        private Station[] getDataResultField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.datacontract.org/2004/07/WebProxyService")]
        public Station[] GetDataResult
        {
            get
            {
                return this.getDataResultField;
            }
            set
            {
                this.getDataResultField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MSBuild", "16.9.0+57a23d249aafe6409b3e24836a486f769cb74c2c")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://tempuri.org/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://tempuri.org/", IsNullable=false)]
    public partial class GetStation
    {
        
        private string numberField;
        
        private string nameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string number
        {
            get
            {
                return this.numberField;
            }
            set
            {
                this.numberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MSBuild", "16.9.0+57a23d249aafe6409b3e24836a486f769cb74c2c")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://tempuri.org/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://tempuri.org/", IsNullable=false)]
    public partial class GetStationResponse
    {
        
        private Station getStationResultField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public Station GetStationResult
        {
            get
            {
                return this.getStationResultField;
            }
            set
            {
                this.getStationResultField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MSBuild", "16.9.0+57a23d249aafe6409b3e24836a486f769cb74c2c")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://tempuri.org/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://tempuri.org/", IsNullable=false)]
    public partial class GetDataUsingDataContract
    {
        
        private CompositeType compositeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public CompositeType composite
        {
            get
            {
                return this.compositeField;
            }
            set
            {
                this.compositeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MSBuild", "16.9.0+57a23d249aafe6409b3e24836a486f769cb74c2c")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://tempuri.org/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://tempuri.org/", IsNullable=false)]
    public partial class GetDataUsingDataContractResponse
    {
        
        private CompositeType getDataUsingDataContractResultField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public CompositeType GetDataUsingDataContractResult
        {
            get
            {
                return this.getDataUsingDataContractResultField;
            }
            set
            {
                this.getDataUsingDataContractResultField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MSBuild", "16.9.0+57a23d249aafe6409b3e24836a486f769cb74c2c")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/WebProxyService")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://schemas.datacontract.org/2004/07/WebProxyService", IsNullable=true)]
    public partial class ArrayOfStation
    {
        
        private Station[] stationField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Station", IsNullable=true)]
        public Station[] Station
        {
            get
            {
                return this.stationField;
            }
            set
            {
                this.stationField = value;
            }
        }
    }
}
