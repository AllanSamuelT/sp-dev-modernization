﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=4.6.1055.0.
// 
namespace SharePointPnP.Modernization.Framework.Publishing {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.dev.office.com/PnP/2019/03/PublishingPageTransformationSchema")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://schemas.dev.office.com/PnP/2019/03/PublishingPageTransformationSchema", IsNullable=false)]
    public partial class PublishingPageTransformation {
        
        private AddOn[] addOnsField;
        
        private PageLayout[] pageLayoutsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public AddOn[] AddOns {
            get {
                return this.addOnsField;
            }
            set {
                this.addOnsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public PageLayout[] PageLayouts {
            get {
                return this.pageLayoutsField;
            }
            set {
                this.pageLayoutsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.dev.office.com/PnP/2019/03/PublishingPageTransformationSchema")]
    public partial class AddOn {
        
        private string nameField;
        
        private string typeField;
        
        private string assemblyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Assembly {
            get {
                return this.assemblyField;
            }
            set {
                this.assemblyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.dev.office.com/PnP/2019/03/PublishingPageTransformationSchema")]
    public partial class FixedWebPartProperty {
        
        private string nameField;
        
        private WebPartProperyType typeField;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public WebPartProperyType Type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.dev.office.com/PnP/2019/03/PublishingPageTransformationSchema")]
    public enum WebPartProperyType {
        
        /// <remarks/>
        @string,
        
        /// <remarks/>
        @bool,
        
        /// <remarks/>
        guid,
        
        /// <remarks/>
        integer,
        
        /// <remarks/>
        datetime,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.dev.office.com/PnP/2019/03/PublishingPageTransformationSchema")]
    public partial class FixedWebPart {
        
        private FixedWebPartProperty[] propertyField;
        
        private string typeField;
        
        private int rowField;
        
        private bool rowFieldSpecified;
        
        private int columnField;
        
        private bool columnFieldSpecified;
        
        private int orderField;
        
        private bool orderFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Property")]
        public FixedWebPartProperty[] Property {
            get {
                return this.propertyField;
            }
            set {
                this.propertyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int Row {
            get {
                return this.rowField;
            }
            set {
                this.rowField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RowSpecified {
            get {
                return this.rowFieldSpecified;
            }
            set {
                this.rowFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int Column {
            get {
                return this.columnField;
            }
            set {
                this.columnField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ColumnSpecified {
            get {
                return this.columnFieldSpecified;
            }
            set {
                this.columnFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int Order {
            get {
                return this.orderField;
            }
            set {
                this.orderField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OrderSpecified {
            get {
                return this.orderFieldSpecified;
            }
            set {
                this.orderFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.dev.office.com/PnP/2019/03/PublishingPageTransformationSchema")]
    public partial class WebPartZone {
        
        private int zoneIndexField;
        
        private string zoneIdField;
        
        private int rowField;
        
        private bool rowFieldSpecified;
        
        private int columnField;
        
        private bool columnFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int ZoneIndex {
            get {
                return this.zoneIndexField;
            }
            set {
                this.zoneIndexField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ZoneId {
            get {
                return this.zoneIdField;
            }
            set {
                this.zoneIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int Row {
            get {
                return this.rowField;
            }
            set {
                this.rowField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RowSpecified {
            get {
                return this.rowFieldSpecified;
            }
            set {
                this.rowFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int Column {
            get {
                return this.columnField;
            }
            set {
                this.columnField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ColumnSpecified {
            get {
                return this.columnFieldSpecified;
            }
            set {
                this.columnFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.dev.office.com/PnP/2019/03/PublishingPageTransformationSchema")]
    public partial class WebPartProperty {
        
        private string nameField;
        
        private WebPartProperyType typeField;
        
        private string functionsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public WebPartProperyType Type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Functions {
            get {
                return this.functionsField;
            }
            set {
                this.functionsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.dev.office.com/PnP/2019/03/PublishingPageTransformationSchema")]
    public partial class WebPartField {
        
        private WebPartProperty[] propertyField;
        
        private string nameField;
        
        private string targetWebPartField;
        
        private int rowField;
        
        private bool rowFieldSpecified;
        
        private int columnField;
        
        private bool columnFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Property")]
        public WebPartProperty[] Property {
            get {
                return this.propertyField;
            }
            set {
                this.propertyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TargetWebPart {
            get {
                return this.targetWebPartField;
            }
            set {
                this.targetWebPartField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int Row {
            get {
                return this.rowField;
            }
            set {
                this.rowField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RowSpecified {
            get {
                return this.rowFieldSpecified;
            }
            set {
                this.rowFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int Column {
            get {
                return this.columnField;
            }
            set {
                this.columnField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ColumnSpecified {
            get {
                return this.columnFieldSpecified;
            }
            set {
                this.columnFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.dev.office.com/PnP/2019/03/PublishingPageTransformationSchema")]
    public partial class MetaDataField {
        
        private string nameField;
        
        private string targetFieldNameField;
        
        private string functionsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TargetFieldName {
            get {
                return this.targetFieldNameField;
            }
            set {
                this.targetFieldNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Functions {
            get {
                return this.functionsField;
            }
            set {
                this.functionsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.dev.office.com/PnP/2019/03/PublishingPageTransformationSchema")]
    public partial class HeaderField {
        
        private string nameField;
        
        private string headerPropertyField;
        
        private string functionsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string HeaderProperty {
            get {
                return this.headerPropertyField;
            }
            set {
                this.headerPropertyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Functions {
            get {
                return this.functionsField;
            }
            set {
                this.functionsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.dev.office.com/PnP/2019/03/PublishingPageTransformationSchema")]
    public partial class Header {
        
        private HeaderField[] fieldField;
        
        private HeaderType typeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Field")]
        public HeaderField[] Field {
            get {
                return this.fieldField;
            }
            set {
                this.fieldField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public HeaderType Type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.dev.office.com/PnP/2019/03/PublishingPageTransformationSchema")]
    public enum HeaderType {
        
        /// <remarks/>
        FullWidthImage,
        
        /// <remarks/>
        NoImage,
        
        /// <remarks/>
        ColorBlock,
        
        /// <remarks/>
        CutInShape,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.dev.office.com/PnP/2019/03/PublishingPageTransformationSchema")]
    public partial class PageLayout {
        
        private Header headerField;
        
        private MetaDataField[] metaDataField;
        
        private WebPartField[] webPartsField;
        
        private WebPartZone[] webPartZonesField;
        
        private FixedWebPart[] fixedWebPartsField;
        
        private string nameField;
        
        private string associatedContentTypeField;
        
        private PageLayoutPageLayoutTemplate pageLayoutTemplateField;
        
        private PageLayoutPageHeader pageHeaderField;
        
        /// <remarks/>
        public Header Header {
            get {
                return this.headerField;
            }
            set {
                this.headerField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Field", IsNullable=false)]
        public MetaDataField[] MetaData {
            get {
                return this.metaDataField;
            }
            set {
                this.metaDataField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Field", IsNullable=false)]
        public WebPartField[] WebParts {
            get {
                return this.webPartsField;
            }
            set {
                this.webPartsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public WebPartZone[] WebPartZones {
            get {
                return this.webPartZonesField;
            }
            set {
                this.webPartZonesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("WebPart", IsNullable=false)]
        public FixedWebPart[] FixedWebParts {
            get {
                return this.fixedWebPartsField;
            }
            set {
                this.fixedWebPartsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AssociatedContentType {
            get {
                return this.associatedContentTypeField;
            }
            set {
                this.associatedContentTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PageLayoutPageLayoutTemplate PageLayoutTemplate {
            get {
                return this.pageLayoutTemplateField;
            }
            set {
                this.pageLayoutTemplateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PageLayoutPageHeader PageHeader {
            get {
                return this.pageHeaderField;
            }
            set {
                this.pageHeaderField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.dev.office.com/PnP/2019/03/PublishingPageTransformationSchema")]
    public enum PageLayoutPageLayoutTemplate {
        
        /// <remarks/>
        OneColumn,
        
        /// <remarks/>
        TwoColumns,
        
        /// <remarks/>
        TwoColumnsWithSidebarLeft,
        
        /// <remarks/>
        TwoColumnsWithSidebarRight,
        
        /// <remarks/>
        TwoColumnsWithHeader,
        
        /// <remarks/>
        TwoColumnsWithHeaderAndFooter,
        
        /// <remarks/>
        ThreeColumns,
        
        /// <remarks/>
        ThreeColumnsWithHeader,
        
        /// <remarks/>
        ThreeColumnsWithHeaderAndFooter,
        
        /// <remarks/>
        AutoDetect,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.dev.office.com/PnP/2019/03/PublishingPageTransformationSchema")]
    public enum PageLayoutPageHeader {
        
        /// <remarks/>
        None,
        
        /// <remarks/>
        Default,
        
        /// <remarks/>
        Custom,
    }
}
