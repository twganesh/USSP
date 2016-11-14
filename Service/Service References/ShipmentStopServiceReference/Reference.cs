﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Service.ShipmentStopServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.slb.com/SIMS/prjBroker_005_aa/ODShipmentQryServiceWSDL", ConfigurationName="ShipmentStopServiceReference.PortType1")]
    public interface PortType1 {
        
        // CODEGEN: Generating message contract since the operation ODShipmentQryService is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="/001801.O_USShippingPaper-WERCS.NET_TMSNAM_ODShipmentQry", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Service.ShipmentStopServiceReference.ODShipmentQryServiceResponse ODShipmentQryService(Service.ShipmentStopServiceReference.ODShipmentQryServiceRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="/001801.O_USShippingPaper-WERCS.NET_TMSNAM_ODShipmentQry", ReplyAction="*")]
        System.Threading.Tasks.Task<Service.ShipmentStopServiceReference.ODShipmentQryServiceResponse> ODShipmentQryServiceAsync(Service.ShipmentStopServiceReference.ODShipmentQryServiceRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1067.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.slb.com/ODShipmentQryService")]
    public partial class Request : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string uSSP_User_AliasField;
        
        private string shipmentIdField;
        
        private string stopField;
        
        private string originField;
        
        private string destinationField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string USSP_User_Alias {
            get {
                return this.uSSP_User_AliasField;
            }
            set {
                this.uSSP_User_AliasField = value;
                this.RaisePropertyChanged("USSP_User_Alias");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string ShipmentId {
            get {
                return this.shipmentIdField;
            }
            set {
                this.shipmentIdField = value;
                this.RaisePropertyChanged("ShipmentId");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string Stop {
            get {
                return this.stopField;
            }
            set {
                this.stopField = value;
                this.RaisePropertyChanged("Stop");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string Origin {
            get {
                return this.originField;
            }
            set {
                this.originField = value;
                this.RaisePropertyChanged("Origin");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string Destination {
            get {
                return this.destinationField;
            }
            set {
                this.destinationField = value;
                this.RaisePropertyChanged("Destination");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1067.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.slb.com/ODShipmentQryService")]
    public partial class TMSShipmentDetailsTMShipment : object, System.ComponentModel.INotifyPropertyChanged {
        
        private TMSShipmentDetailsTMShipmentShipmentStop shipmentStopField;
        
        private string idField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public TMSShipmentDetailsTMShipmentShipmentStop ShipmentStop {
            get {
                return this.shipmentStopField;
            }
            set {
                this.shipmentStopField = value;
                this.RaisePropertyChanged("ShipmentStop");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                this.RaisePropertyChanged("Id");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1067.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.slb.com/ODShipmentQryService")]
    public partial class TMSShipmentDetailsTMShipmentShipmentStop : object, System.ComponentModel.INotifyPropertyChanged {
        
        private TMSShipmentDetailsTMShipmentShipmentStopHeader headerField;
        
        private TMSShipmentDetailsTMShipmentShipmentStopDOTDescriptions dOTDescriptionsField;
        
        private TMSShipmentDetailsTMShipmentShipmentStopSpecialSafetyInstructions specialSafetyInstructionsField;
        
        private sbyte idField;
        
        private bool idFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public TMSShipmentDetailsTMShipmentShipmentStopHeader Header {
            get {
                return this.headerField;
            }
            set {
                this.headerField = value;
                this.RaisePropertyChanged("Header");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public TMSShipmentDetailsTMShipmentShipmentStopDOTDescriptions DOTDescriptions {
            get {
                return this.dOTDescriptionsField;
            }
            set {
                this.dOTDescriptionsField = value;
                this.RaisePropertyChanged("DOTDescriptions");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public TMSShipmentDetailsTMShipmentShipmentStopSpecialSafetyInstructions SpecialSafetyInstructions {
            get {
                return this.specialSafetyInstructionsField;
            }
            set {
                this.specialSafetyInstructionsField = value;
                this.RaisePropertyChanged("SpecialSafetyInstructions");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public sbyte Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                this.RaisePropertyChanged("Id");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IdSpecified {
            get {
                return this.idFieldSpecified;
            }
            set {
                this.idFieldSpecified = value;
                this.RaisePropertyChanged("IdSpecified");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1067.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.slb.com/ODShipmentQryService")]
    public partial class TMSShipmentDetailsTMShipmentShipmentStopHeader : object, System.ComponentModel.INotifyPropertyChanged {
        
        private WellSiteLov wellSiteField;
        
        private string districtField;
        
        private string operatorDriverField;
        
        private string dateShippedField;
        
        private string treatmentNumberField;
        
        private string truckNumberField;
        
        private string trailerNumberField;
        
        private string customerField;
        
        private string jobLocationField;
        
        private string wellJobNameField;
        
        private string specialInstructionsField;
        
        private ColoradoWellLOV coloradoWellField;
        
        private string radioactiveField;
        
        public TMSShipmentDetailsTMShipmentShipmentStopHeader() {
            this.districtField = "";
            this.operatorDriverField = "";
            this.truckNumberField = "";
            this.trailerNumberField = "";
            this.customerField = "";
            this.wellJobNameField = "";
            this.specialInstructionsField = "";
            this.radioactiveField = "";
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public WellSiteLov WellSite {
            get {
                return this.wellSiteField;
            }
            set {
                this.wellSiteField = value;
                this.RaisePropertyChanged("WellSite");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string District {
            get {
                return this.districtField;
            }
            set {
                this.districtField = value;
                this.RaisePropertyChanged("District");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string OperatorDriver {
            get {
                return this.operatorDriverField;
            }
            set {
                this.operatorDriverField = value;
                this.RaisePropertyChanged("OperatorDriver");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string DateShipped {
            get {
                return this.dateShippedField;
            }
            set {
                this.dateShippedField = value;
                this.RaisePropertyChanged("DateShipped");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string TreatmentNumber {
            get {
                return this.treatmentNumberField;
            }
            set {
                this.treatmentNumberField = value;
                this.RaisePropertyChanged("TreatmentNumber");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string TruckNumber {
            get {
                return this.truckNumberField;
            }
            set {
                this.truckNumberField = value;
                this.RaisePropertyChanged("TruckNumber");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public string TrailerNumber {
            get {
                return this.trailerNumberField;
            }
            set {
                this.trailerNumberField = value;
                this.RaisePropertyChanged("TrailerNumber");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public string Customer {
            get {
                return this.customerField;
            }
            set {
                this.customerField = value;
                this.RaisePropertyChanged("Customer");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public string JobLocation {
            get {
                return this.jobLocationField;
            }
            set {
                this.jobLocationField = value;
                this.RaisePropertyChanged("JobLocation");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public string WellJobName {
            get {
                return this.wellJobNameField;
            }
            set {
                this.wellJobNameField = value;
                this.RaisePropertyChanged("WellJobName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=10)]
        public string SpecialInstructions {
            get {
                return this.specialInstructionsField;
            }
            set {
                this.specialInstructionsField = value;
                this.RaisePropertyChanged("SpecialInstructions");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=11)]
        public ColoradoWellLOV ColoradoWell {
            get {
                return this.coloradoWellField;
            }
            set {
                this.coloradoWellField = value;
                this.RaisePropertyChanged("ColoradoWell");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=12)]
        public string Radioactive {
            get {
                return this.radioactiveField;
            }
            set {
                this.radioactiveField = value;
                this.RaisePropertyChanged("Radioactive");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1067.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.slb.com/ODShipmentQryService")]
    public enum WellSiteLov {
        
        /// <remarks/>
        Land,
        
        /// <remarks/>
        Offshore,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1067.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.slb.com/ODShipmentQryService")]
    public enum ColoradoWellLOV {
        
        /// <remarks/>
        Yes,
        
        /// <remarks/>
        No,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1067.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.slb.com/ODShipmentQryService")]
    public partial class TMSShipmentDetailsTMShipmentShipmentStopDOTDescriptions : object, System.ComponentModel.INotifyPropertyChanged {
        
        private TMSShipmentDetailsTMShipmentShipmentStopDOTDescriptionsDOTLineItem[] dOTLineItemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DOTLineItem", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public TMSShipmentDetailsTMShipmentShipmentStopDOTDescriptionsDOTLineItem[] DOTLineItem {
            get {
                return this.dOTLineItemField;
            }
            set {
                this.dOTLineItemField = value;
                this.RaisePropertyChanged("DOTLineItem");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1067.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.slb.com/ODShipmentQryService")]
    public partial class TMSShipmentDetailsTMShipmentShipmentStopDOTDescriptionsDOTLineItem : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string categoryField;
        
        private string productCodeField;
        
        private string typeofPackageField;
        
        private string locationField;
        
        private string actualQuantityField;
        
        private PerPackageLOV perPackageField;
        
        private string numberOfPackageField;
        
        private string orderReleaseIDField;
        
        private string orderShipmentIdField;
        
        public TMSShipmentDetailsTMShipmentShipmentStopDOTDescriptionsDOTLineItem() {
            this.categoryField = "Product Code";
            this.typeofPackageField = "";
            this.locationField = "";
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string Category {
            get {
                return this.categoryField;
            }
            set {
                this.categoryField = value;
                this.RaisePropertyChanged("Category");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string ProductCode {
            get {
                return this.productCodeField;
            }
            set {
                this.productCodeField = value;
                this.RaisePropertyChanged("ProductCode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string TypeofPackage {
            get {
                return this.typeofPackageField;
            }
            set {
                this.typeofPackageField = value;
                this.RaisePropertyChanged("TypeofPackage");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string Location {
            get {
                return this.locationField;
            }
            set {
                this.locationField = value;
                this.RaisePropertyChanged("Location");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string ActualQuantity {
            get {
                return this.actualQuantityField;
            }
            set {
                this.actualQuantityField = value;
                this.RaisePropertyChanged("ActualQuantity");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public PerPackageLOV PerPackage {
            get {
                return this.perPackageField;
            }
            set {
                this.perPackageField = value;
                this.RaisePropertyChanged("PerPackage");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public string NumberOfPackage {
            get {
                return this.numberOfPackageField;
            }
            set {
                this.numberOfPackageField = value;
                this.RaisePropertyChanged("NumberOfPackage");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public string OrderReleaseID {
            get {
                return this.orderReleaseIDField;
            }
            set {
                this.orderReleaseIDField = value;
                this.RaisePropertyChanged("OrderReleaseID");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OrderShipmentId {
            get {
                return this.orderShipmentIdField;
            }
            set {
                this.orderShipmentIdField = value;
                this.RaisePropertyChanged("OrderShipmentId");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1067.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.slb.com/ODShipmentQryService")]
    public enum PerPackageLOV {
        
        /// <remarks/>
        galUS,
        
        /// <remarks/>
        lbs,
        
        /// <remarks/>
        ea,
        
        /// <remarks/>
        KG,
        
        /// <remarks/>
        TN,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1067.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.slb.com/ODShipmentQryService")]
    public partial class TMSShipmentDetailsTMShipmentShipmentStopSpecialSafetyInstructions : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string specialSafetyEquipmentRequiredField;
        
        private string certifiedbyField;
        
        private string loadDateTimeField;
        
        private string loadTimeZoneField;
        
        private string returnLoadDateField;
        
        private string jobSupervisorField;
        
        private string returnLoadOperatorField;
        
        public TMSShipmentDetailsTMShipmentShipmentStopSpecialSafetyInstructions() {
            this.specialSafetyEquipmentRequiredField = "";
            this.certifiedbyField = "";
            this.loadDateTimeField = "";
            this.loadTimeZoneField = "";
            this.returnLoadOperatorField = "";
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string SpecialSafetyEquipmentRequired {
            get {
                return this.specialSafetyEquipmentRequiredField;
            }
            set {
                this.specialSafetyEquipmentRequiredField = value;
                this.RaisePropertyChanged("SpecialSafetyEquipmentRequired");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string Certifiedby {
            get {
                return this.certifiedbyField;
            }
            set {
                this.certifiedbyField = value;
                this.RaisePropertyChanged("Certifiedby");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string LoadDateTime {
            get {
                return this.loadDateTimeField;
            }
            set {
                this.loadDateTimeField = value;
                this.RaisePropertyChanged("LoadDateTime");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string LoadTimeZone {
            get {
                return this.loadTimeZoneField;
            }
            set {
                this.loadTimeZoneField = value;
                this.RaisePropertyChanged("LoadTimeZone");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string ReturnLoadDate {
            get {
                return this.returnLoadDateField;
            }
            set {
                this.returnLoadDateField = value;
                this.RaisePropertyChanged("ReturnLoadDate");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string JobSupervisor {
            get {
                return this.jobSupervisorField;
            }
            set {
                this.jobSupervisorField = value;
                this.RaisePropertyChanged("JobSupervisor");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public string ReturnLoadOperator {
            get {
                return this.returnLoadOperatorField;
            }
            set {
                this.returnLoadOperatorField = value;
                this.RaisePropertyChanged("ReturnLoadOperator");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ODShipmentQryServiceRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.slb.com/ODShipmentQryService", Order=0)]
        public Service.ShipmentStopServiceReference.Request Request;
        
        public ODShipmentQryServiceRequest() {
        }
        
        public ODShipmentQryServiceRequest(Service.ShipmentStopServiceReference.Request Request) {
            this.Request = Request;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ODShipmentQryServiceResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.slb.com/ODShipmentQryService", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("TMShipment", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public Service.ShipmentStopServiceReference.TMSShipmentDetailsTMShipment[] TMSShipmentDetails;
        
        public ODShipmentQryServiceResponse() {
        }
        
        public ODShipmentQryServiceResponse(Service.ShipmentStopServiceReference.TMSShipmentDetailsTMShipment[] TMSShipmentDetails) {
            this.TMSShipmentDetails = TMSShipmentDetails;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface PortType1Channel : Service.ShipmentStopServiceReference.PortType1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PortType1Client : System.ServiceModel.ClientBase<Service.ShipmentStopServiceReference.PortType1>, Service.ShipmentStopServiceReference.PortType1 {
        
        public PortType1Client() {
        }
        
        public PortType1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PortType1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PortType1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PortType1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Service.ShipmentStopServiceReference.ODShipmentQryServiceResponse Service.ShipmentStopServiceReference.PortType1.ODShipmentQryService(Service.ShipmentStopServiceReference.ODShipmentQryServiceRequest request) {
            return base.Channel.ODShipmentQryService(request);
        }
        
        public Service.ShipmentStopServiceReference.TMSShipmentDetailsTMShipment[] ODShipmentQryService(Service.ShipmentStopServiceReference.Request Request) {
            Service.ShipmentStopServiceReference.ODShipmentQryServiceRequest inValue = new Service.ShipmentStopServiceReference.ODShipmentQryServiceRequest();
            inValue.Request = Request;
            Service.ShipmentStopServiceReference.ODShipmentQryServiceResponse retVal = ((Service.ShipmentStopServiceReference.PortType1)(this)).ODShipmentQryService(inValue);
            return retVal.TMSShipmentDetails;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Service.ShipmentStopServiceReference.ODShipmentQryServiceResponse> Service.ShipmentStopServiceReference.PortType1.ODShipmentQryServiceAsync(Service.ShipmentStopServiceReference.ODShipmentQryServiceRequest request) {
            return base.Channel.ODShipmentQryServiceAsync(request);
        }
        
        public System.Threading.Tasks.Task<Service.ShipmentStopServiceReference.ODShipmentQryServiceResponse> ODShipmentQryServiceAsync(Service.ShipmentStopServiceReference.Request Request) {
            Service.ShipmentStopServiceReference.ODShipmentQryServiceRequest inValue = new Service.ShipmentStopServiceReference.ODShipmentQryServiceRequest();
            inValue.Request = Request;
            return ((Service.ShipmentStopServiceReference.PortType1)(this)).ODShipmentQryServiceAsync(inValue);
        }
    }
}
