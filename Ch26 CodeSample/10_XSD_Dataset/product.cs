﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.312
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;

// 
// This source code was auto-generated by xsd, Version=2.0.50727.42.
// 


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
[Serializable()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.ComponentModel.ToolboxItem(true)]
[System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedDataSetSchema")]
[System.Xml.Serialization.XmlRootAttribute("Products")]
[System.ComponentModel.Design.HelpKeywordAttribute("vs.data.DataSet")]
public partial class Products : System.Data.DataSet {
    
    private ProductDataTable tableProduct;
    
    private System.Data.SchemaSerializationMode _schemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public Products() {
        this.BeginInit();
        this.InitClass();
        System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
        base.Tables.CollectionChanged += schemaChangedHandler;
        base.Relations.CollectionChanged += schemaChangedHandler;
        this.EndInit();
    }
    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    protected Products(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : 
            base(info, context, false) {
        if ((this.IsBinarySerialized(info, context) == true)) {
            this.InitVars(false);
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler1 = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler1;
            this.Relations.CollectionChanged += schemaChangedHandler1;
            return;
        }
        string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
        if ((this.DetermineSchemaSerializationMode(info, context) == System.Data.SchemaSerializationMode.IncludeSchema)) {
            System.Data.DataSet ds = new System.Data.DataSet();
            ds.ReadXmlSchema(new System.Xml.XmlTextReader(new System.IO.StringReader(strSchema)));
            if ((ds.Tables["Product"] != null)) {
                base.Tables.Add(new ProductDataTable(ds.Tables["Product"]));
            }
            this.DataSetName = ds.DataSetName;
            this.Prefix = ds.Prefix;
            this.Namespace = ds.Namespace;
            this.Locale = ds.Locale;
            this.CaseSensitive = ds.CaseSensitive;
            this.EnforceConstraints = ds.EnforceConstraints;
            this.Merge(ds, false, System.Data.MissingSchemaAction.Add);
            this.InitVars();
        }
        else {
            this.ReadXmlSchema(new System.Xml.XmlTextReader(new System.IO.StringReader(strSchema)));
        }
        this.GetSerializationData(info, context);
        System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
        base.Tables.CollectionChanged += schemaChangedHandler;
        this.Relations.CollectionChanged += schemaChangedHandler;
    }
    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [System.ComponentModel.Browsable(false)]
    [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Content)]
    public ProductDataTable Product {
        get {
            return this.tableProduct;
        }
    }
    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [System.ComponentModel.BrowsableAttribute(true)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Visible)]
    public override System.Data.SchemaSerializationMode SchemaSerializationMode {
        get {
            return this._schemaSerializationMode;
        }
        set {
            this._schemaSerializationMode = value;
        }
    }
    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
    public new System.Data.DataTableCollection Tables {
        get {
            return base.Tables;
        }
    }
    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
    public new System.Data.DataRelationCollection Relations {
        get {
            return base.Relations;
        }
    }
    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    protected override void InitializeDerivedDataSet() {
        this.BeginInit();
        this.InitClass();
        this.EndInit();
    }
    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public override System.Data.DataSet Clone() {
        Products cln = ((Products)(base.Clone()));
        cln.InitVars();
        cln.SchemaSerializationMode = this.SchemaSerializationMode;
        return cln;
    }
    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    protected override bool ShouldSerializeTables() {
        return false;
    }
    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    protected override bool ShouldSerializeRelations() {
        return false;
    }
    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    protected override void ReadXmlSerializable(System.Xml.XmlReader reader) {
        if ((this.DetermineSchemaSerializationMode(reader) == System.Data.SchemaSerializationMode.IncludeSchema)) {
            this.Reset();
            System.Data.DataSet ds = new System.Data.DataSet();
            ds.ReadXml(reader);
            if ((ds.Tables["Product"] != null)) {
                base.Tables.Add(new ProductDataTable(ds.Tables["Product"]));
            }
            this.DataSetName = ds.DataSetName;
            this.Prefix = ds.Prefix;
            this.Namespace = ds.Namespace;
            this.Locale = ds.Locale;
            this.CaseSensitive = ds.CaseSensitive;
            this.EnforceConstraints = ds.EnforceConstraints;
            this.Merge(ds, false, System.Data.MissingSchemaAction.Add);
            this.InitVars();
        }
        else {
            this.ReadXml(reader);
            this.InitVars();
        }
    }
    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    protected override System.Xml.Schema.XmlSchema GetSchemaSerializable() {
        System.IO.MemoryStream stream = new System.IO.MemoryStream();
        this.WriteXmlSchema(new System.Xml.XmlTextWriter(stream, null));
        stream.Position = 0;
        return System.Xml.Schema.XmlSchema.Read(new System.Xml.XmlTextReader(stream), null);
    }
    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal void InitVars() {
        this.InitVars(true);
    }
    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal void InitVars(bool initTable) {
        this.tableProduct = ((ProductDataTable)(base.Tables["Product"]));
        if ((initTable == true)) {
            if ((this.tableProduct != null)) {
                this.tableProduct.InitVars();
            }
        }
    }
    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    private void InitClass() {
        this.DataSetName = "Products";
        this.Prefix = "";
        this.Namespace = "http://tempuri.org/XMLSchema1.xsd";
        this.Locale = new System.Globalization.CultureInfo("");
        this.EnforceConstraints = true;
        this.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
        this.tableProduct = new ProductDataTable();
        base.Tables.Add(this.tableProduct);
    }
    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    private bool ShouldSerializeProduct() {
        return false;
    }
    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
        if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
            this.InitVars();
        }
    }
    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public static System.Xml.Schema.XmlSchemaComplexType GetTypedDataSetSchema(System.Xml.Schema.XmlSchemaSet xs) {
        Products ds = new Products();
        System.Xml.Schema.XmlSchemaComplexType type = new System.Xml.Schema.XmlSchemaComplexType();
        System.Xml.Schema.XmlSchemaSequence sequence = new System.Xml.Schema.XmlSchemaSequence();
        xs.Add(ds.GetSchemaSerializable());
        System.Xml.Schema.XmlSchemaAny any = new System.Xml.Schema.XmlSchemaAny();
        any.Namespace = ds.Namespace;
        sequence.Items.Add(any);
        type.Particle = sequence;
        return type;
    }
    
    public delegate void ProductRowChangeEventHandler(object sender, ProductRowChangeEvent e);
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    [System.Serializable()]
    [System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")]
    public partial class ProductDataTable : System.Data.DataTable, System.Collections.IEnumerable {
        
        private System.Data.DataColumn columnProductID;
        
        private System.Data.DataColumn columnProductName;
        
        private System.Data.DataColumn columnSupplierID;
        
        private System.Data.DataColumn columnCategoryID;
        
        private System.Data.DataColumn columnQuantityPerUnit;
        
        private System.Data.DataColumn columnUnitPrice;
        
        private System.Data.DataColumn columnUnitsInStock;
        
        private System.Data.DataColumn columnUnitsOnOrder;
        
        private System.Data.DataColumn columnReorderLevel;
        
        private System.Data.DataColumn columnDiscontinued;
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public ProductDataTable() {
            this.TableName = "Product";
            this.BeginInit();
            this.InitClass();
            this.EndInit();
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        internal ProductDataTable(System.Data.DataTable table) {
            this.TableName = table.TableName;
            if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                this.CaseSensitive = table.CaseSensitive;
            }
            if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                this.Locale = table.Locale;
            }
            if ((table.Namespace != table.DataSet.Namespace)) {
                this.Namespace = table.Namespace;
            }
            this.Prefix = table.Prefix;
            this.MinimumCapacity = table.MinimumCapacity;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        protected ProductDataTable(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : 
                base(info, context) {
            this.InitVars();
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public System.Data.DataColumn ProductIDColumn {
            get {
                return this.columnProductID;
            }
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public System.Data.DataColumn ProductNameColumn {
            get {
                return this.columnProductName;
            }
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public System.Data.DataColumn SupplierIDColumn {
            get {
                return this.columnSupplierID;
            }
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public System.Data.DataColumn CategoryIDColumn {
            get {
                return this.columnCategoryID;
            }
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public System.Data.DataColumn QuantityPerUnitColumn {
            get {
                return this.columnQuantityPerUnit;
            }
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public System.Data.DataColumn UnitPriceColumn {
            get {
                return this.columnUnitPrice;
            }
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public System.Data.DataColumn UnitsInStockColumn {
            get {
                return this.columnUnitsInStock;
            }
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public System.Data.DataColumn UnitsOnOrderColumn {
            get {
                return this.columnUnitsOnOrder;
            }
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public System.Data.DataColumn ReorderLevelColumn {
            get {
                return this.columnReorderLevel;
            }
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public System.Data.DataColumn DiscontinuedColumn {
            get {
                return this.columnDiscontinued;
            }
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.Browsable(false)]
        public int Count {
            get {
                return this.Rows.Count;
            }
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public ProductRow this[int index] {
            get {
                return ((ProductRow)(this.Rows[index]));
            }
        }
        
        public event ProductRowChangeEventHandler ProductRowChanging;
        
        public event ProductRowChangeEventHandler ProductRowChanged;
        
        public event ProductRowChangeEventHandler ProductRowDeleting;
        
        public event ProductRowChangeEventHandler ProductRowDeleted;
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void AddProductRow(ProductRow row) {
            this.Rows.Add(row);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public ProductRow AddProductRow(string ProductName, int SupplierID, int CategoryID, string QuantityPerUnit, decimal UnitPrice, short UnitsInStock, short UnitsOnOrder, short ReorderLevel, bool Discontinued) {
            ProductRow rowProductRow = ((ProductRow)(this.NewRow()));
            rowProductRow.ItemArray = new object[] {
                    null,
                    ProductName,
                    SupplierID,
                    CategoryID,
                    QuantityPerUnit,
                    UnitPrice,
                    UnitsInStock,
                    UnitsOnOrder,
                    ReorderLevel,
                    Discontinued};
            this.Rows.Add(rowProductRow);
            return rowProductRow;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public virtual System.Collections.IEnumerator GetEnumerator() {
            return this.Rows.GetEnumerator();
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public override System.Data.DataTable Clone() {
            ProductDataTable cln = ((ProductDataTable)(base.Clone()));
            cln.InitVars();
            return cln;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        protected override System.Data.DataTable CreateInstance() {
            return new ProductDataTable();
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        internal void InitVars() {
            this.columnProductID = base.Columns["ProductID"];
            this.columnProductName = base.Columns["ProductName"];
            this.columnSupplierID = base.Columns["SupplierID"];
            this.columnCategoryID = base.Columns["CategoryID"];
            this.columnQuantityPerUnit = base.Columns["QuantityPerUnit"];
            this.columnUnitPrice = base.Columns["UnitPrice"];
            this.columnUnitsInStock = base.Columns["UnitsInStock"];
            this.columnUnitsOnOrder = base.Columns["UnitsOnOrder"];
            this.columnReorderLevel = base.Columns["ReorderLevel"];
            this.columnDiscontinued = base.Columns["Discontinued"];
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private void InitClass() {
            this.columnProductID = new System.Data.DataColumn("ProductID", typeof(int), null, System.Data.MappingType.Element);
            base.Columns.Add(this.columnProductID);
            this.columnProductName = new System.Data.DataColumn("ProductName", typeof(string), null, System.Data.MappingType.Element);
            base.Columns.Add(this.columnProductName);
            this.columnSupplierID = new System.Data.DataColumn("SupplierID", typeof(int), null, System.Data.MappingType.Element);
            base.Columns.Add(this.columnSupplierID);
            this.columnCategoryID = new System.Data.DataColumn("CategoryID", typeof(int), null, System.Data.MappingType.Element);
            base.Columns.Add(this.columnCategoryID);
            this.columnQuantityPerUnit = new System.Data.DataColumn("QuantityPerUnit", typeof(string), null, System.Data.MappingType.Element);
            base.Columns.Add(this.columnQuantityPerUnit);
            this.columnUnitPrice = new System.Data.DataColumn("UnitPrice", typeof(decimal), null, System.Data.MappingType.Element);
            base.Columns.Add(this.columnUnitPrice);
            this.columnUnitsInStock = new System.Data.DataColumn("UnitsInStock", typeof(short), null, System.Data.MappingType.Element);
            base.Columns.Add(this.columnUnitsInStock);
            this.columnUnitsOnOrder = new System.Data.DataColumn("UnitsOnOrder", typeof(short), null, System.Data.MappingType.Element);
            base.Columns.Add(this.columnUnitsOnOrder);
            this.columnReorderLevel = new System.Data.DataColumn("ReorderLevel", typeof(short), null, System.Data.MappingType.Element);
            base.Columns.Add(this.columnReorderLevel);
            this.columnDiscontinued = new System.Data.DataColumn("Discontinued", typeof(bool), null, System.Data.MappingType.Element);
            base.Columns.Add(this.columnDiscontinued);
            this.columnProductID.AutoIncrement = true;
            this.columnProductID.AllowDBNull = false;
            this.columnProductID.ReadOnly = true;
            this.columnProductName.AllowDBNull = false;
            this.columnDiscontinued.AllowDBNull = false;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public ProductRow NewProductRow() {
            return ((ProductRow)(this.NewRow()));
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        protected override System.Data.DataRow NewRowFromBuilder(System.Data.DataRowBuilder builder) {
            return new ProductRow(builder);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        protected override System.Type GetRowType() {
            return typeof(ProductRow);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        protected override void OnRowChanged(System.Data.DataRowChangeEventArgs e) {
            base.OnRowChanged(e);
            if ((this.ProductRowChanged != null)) {
                this.ProductRowChanged(this, new ProductRowChangeEvent(((ProductRow)(e.Row)), e.Action));
            }
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        protected override void OnRowChanging(System.Data.DataRowChangeEventArgs e) {
            base.OnRowChanging(e);
            if ((this.ProductRowChanging != null)) {
                this.ProductRowChanging(this, new ProductRowChangeEvent(((ProductRow)(e.Row)), e.Action));
            }
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        protected override void OnRowDeleted(System.Data.DataRowChangeEventArgs e) {
            base.OnRowDeleted(e);
            if ((this.ProductRowDeleted != null)) {
                this.ProductRowDeleted(this, new ProductRowChangeEvent(((ProductRow)(e.Row)), e.Action));
            }
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        protected override void OnRowDeleting(System.Data.DataRowChangeEventArgs e) {
            base.OnRowDeleting(e);
            if ((this.ProductRowDeleting != null)) {
                this.ProductRowDeleting(this, new ProductRowChangeEvent(((ProductRow)(e.Row)), e.Action));
            }
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void RemoveProductRow(ProductRow row) {
            this.Rows.Remove(row);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public static System.Xml.Schema.XmlSchemaComplexType GetTypedTableSchema(System.Xml.Schema.XmlSchemaSet xs) {
            System.Xml.Schema.XmlSchemaComplexType type = new System.Xml.Schema.XmlSchemaComplexType();
            System.Xml.Schema.XmlSchemaSequence sequence = new System.Xml.Schema.XmlSchemaSequence();
            Products ds = new Products();
            xs.Add(ds.GetSchemaSerializable());
            System.Xml.Schema.XmlSchemaAny any1 = new System.Xml.Schema.XmlSchemaAny();
            any1.Namespace = "http://www.w3.org/2001/XMLSchema";
            any1.MinOccurs = new decimal(0);
            any1.MaxOccurs = decimal.MaxValue;
            any1.ProcessContents = System.Xml.Schema.XmlSchemaContentProcessing.Lax;
            sequence.Items.Add(any1);
            System.Xml.Schema.XmlSchemaAny any2 = new System.Xml.Schema.XmlSchemaAny();
            any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
            any2.MinOccurs = new decimal(1);
            any2.ProcessContents = System.Xml.Schema.XmlSchemaContentProcessing.Lax;
            sequence.Items.Add(any2);
            System.Xml.Schema.XmlSchemaAttribute attribute1 = new System.Xml.Schema.XmlSchemaAttribute();
            attribute1.Name = "namespace";
            attribute1.FixedValue = ds.Namespace;
            type.Attributes.Add(attribute1);
            System.Xml.Schema.XmlSchemaAttribute attribute2 = new System.Xml.Schema.XmlSchemaAttribute();
            attribute2.Name = "tableTypeName";
            attribute2.FixedValue = "ProductDataTable";
            type.Attributes.Add(attribute2);
            type.Particle = sequence;
            return type;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public partial class ProductRow : System.Data.DataRow {
        
        private ProductDataTable tableProduct;
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        internal ProductRow(System.Data.DataRowBuilder rb) : 
                base(rb) {
            this.tableProduct = ((ProductDataTable)(this.Table));
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public int ProductID {
            get {
                return ((int)(this[this.tableProduct.ProductIDColumn]));
            }
            set {
                this[this.tableProduct.ProductIDColumn] = value;
            }
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public string ProductName {
            get {
                return ((string)(this[this.tableProduct.ProductNameColumn]));
            }
            set {
                this[this.tableProduct.ProductNameColumn] = value;
            }
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public int SupplierID {
            get {
                try {
                    return ((int)(this[this.tableProduct.SupplierIDColumn]));
                }
                catch (System.InvalidCastException e) {
                    throw new System.Data.StrongTypingException("The value for column \'SupplierID\' in table \'Product\' is DBNull.", e);
                }
            }
            set {
                this[this.tableProduct.SupplierIDColumn] = value;
            }
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public int CategoryID {
            get {
                try {
                    return ((int)(this[this.tableProduct.CategoryIDColumn]));
                }
                catch (System.InvalidCastException e) {
                    throw new System.Data.StrongTypingException("The value for column \'CategoryID\' in table \'Product\' is DBNull.", e);
                }
            }
            set {
                this[this.tableProduct.CategoryIDColumn] = value;
            }
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public string QuantityPerUnit {
            get {
                try {
                    return ((string)(this[this.tableProduct.QuantityPerUnitColumn]));
                }
                catch (System.InvalidCastException e) {
                    throw new System.Data.StrongTypingException("The value for column \'QuantityPerUnit\' in table \'Product\' is DBNull.", e);
                }
            }
            set {
                this[this.tableProduct.QuantityPerUnitColumn] = value;
            }
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public decimal UnitPrice {
            get {
                try {
                    return ((decimal)(this[this.tableProduct.UnitPriceColumn]));
                }
                catch (System.InvalidCastException e) {
                    throw new System.Data.StrongTypingException("The value for column \'UnitPrice\' in table \'Product\' is DBNull.", e);
                }
            }
            set {
                this[this.tableProduct.UnitPriceColumn] = value;
            }
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public short UnitsInStock {
            get {
                try {
                    return ((short)(this[this.tableProduct.UnitsInStockColumn]));
                }
                catch (System.InvalidCastException e) {
                    throw new System.Data.StrongTypingException("The value for column \'UnitsInStock\' in table \'Product\' is DBNull.", e);
                }
            }
            set {
                this[this.tableProduct.UnitsInStockColumn] = value;
            }
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public short UnitsOnOrder {
            get {
                try {
                    return ((short)(this[this.tableProduct.UnitsOnOrderColumn]));
                }
                catch (System.InvalidCastException e) {
                    throw new System.Data.StrongTypingException("The value for column \'UnitsOnOrder\' in table \'Product\' is DBNull.", e);
                }
            }
            set {
                this[this.tableProduct.UnitsOnOrderColumn] = value;
            }
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public short ReorderLevel {
            get {
                try {
                    return ((short)(this[this.tableProduct.ReorderLevelColumn]));
                }
                catch (System.InvalidCastException e) {
                    throw new System.Data.StrongTypingException("The value for column \'ReorderLevel\' in table \'Product\' is DBNull.", e);
                }
            }
            set {
                this[this.tableProduct.ReorderLevelColumn] = value;
            }
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public bool Discontinued {
            get {
                return ((bool)(this[this.tableProduct.DiscontinuedColumn]));
            }
            set {
                this[this.tableProduct.DiscontinuedColumn] = value;
            }
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public bool IsSupplierIDNull() {
            return this.IsNull(this.tableProduct.SupplierIDColumn);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void SetSupplierIDNull() {
            this[this.tableProduct.SupplierIDColumn] = System.Convert.DBNull;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public bool IsCategoryIDNull() {
            return this.IsNull(this.tableProduct.CategoryIDColumn);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void SetCategoryIDNull() {
            this[this.tableProduct.CategoryIDColumn] = System.Convert.DBNull;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public bool IsQuantityPerUnitNull() {
            return this.IsNull(this.tableProduct.QuantityPerUnitColumn);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void SetQuantityPerUnitNull() {
            this[this.tableProduct.QuantityPerUnitColumn] = System.Convert.DBNull;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public bool IsUnitPriceNull() {
            return this.IsNull(this.tableProduct.UnitPriceColumn);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void SetUnitPriceNull() {
            this[this.tableProduct.UnitPriceColumn] = System.Convert.DBNull;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public bool IsUnitsInStockNull() {
            return this.IsNull(this.tableProduct.UnitsInStockColumn);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void SetUnitsInStockNull() {
            this[this.tableProduct.UnitsInStockColumn] = System.Convert.DBNull;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public bool IsUnitsOnOrderNull() {
            return this.IsNull(this.tableProduct.UnitsOnOrderColumn);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void SetUnitsOnOrderNull() {
            this[this.tableProduct.UnitsOnOrderColumn] = System.Convert.DBNull;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public bool IsReorderLevelNull() {
            return this.IsNull(this.tableProduct.ReorderLevelColumn);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void SetReorderLevelNull() {
            this[this.tableProduct.ReorderLevelColumn] = System.Convert.DBNull;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class ProductRowChangeEvent : System.EventArgs {
        
        private ProductRow eventRow;
        
        private System.Data.DataRowAction eventAction;
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public ProductRowChangeEvent(ProductRow row, System.Data.DataRowAction action) {
            this.eventRow = row;
            this.eventAction = action;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public ProductRow Row {
            get {
                return this.eventRow;
            }
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public System.Data.DataRowAction Action {
            get {
                return this.eventAction;
            }
        }
    }
}