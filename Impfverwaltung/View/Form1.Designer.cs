using System.Windows.Forms;

namespace Impfverwaltung.View
{
    partial class ImpfManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.vaccinationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Impfverwaltung.DataSet1();
            this.vaccinationTableAdapter = new Impfverwaltung.DataSet1TableAdapters.VaccinationTableAdapter();
            this.tableAdapterManager1 = new Impfverwaltung.DataSet1TableAdapters.TableAdapterManager();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personTableAdapter = new Impfverwaltung.DataSet1TableAdapters.PersonTableAdapter();
            this.fKPersonVaccinationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.TxbSearch = new System.Windows.Forms.TextBox();
            this.ChFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChSecondName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChAge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChStreet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChPlz = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChPlace = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChVaccin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChNumVaccinations = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListViewPerson = new System.Windows.Forms.ListView();
            this.BtnNewEntry = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.CbxVaccinationPlus = new System.Windows.Forms.ComboBox();
            this.BtnVaccinate = new System.Windows.Forms.Button();
            this.GrpsVaccinate = new System.Windows.Forms.GroupBox();
            this.LFirstName = new System.Windows.Forms.Label();
            this.LLastName = new System.Windows.Forms.Label();
            this.LStreet = new System.Windows.Forms.Label();
            this.lPLZ = new System.Windows.Forms.Label();
            this.LOrt = new System.Windows.Forms.Label();
            this.LVaccination = new System.Windows.Forms.Label();
            this.TxbFirstName = new System.Windows.Forms.TextBox();
            this.TxbSecondName = new System.Windows.Forms.TextBox();
            this.TxbStreet = new System.Windows.Forms.TextBox();
            this.TxbPlz = new System.Windows.Forms.TextBox();
            this.TxbPlace = new System.Windows.Forms.TextBox();
            this.CbxVaccination = new System.Windows.Forms.ComboBox();
            this.LAlter = new System.Windows.Forms.Label();
            this.TxbAge = new System.Windows.Forms.TextBox();
            this.LImpfdosen = new System.Windows.Forms.Label();
            this.TxbNumVaccinations = new System.Windows.Forms.TextBox();
            this.GrbNames = new System.Windows.Forms.GroupBox();
            this.listViewCompletley = new System.Windows.Forms.ListView();
            this.CFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CSecondName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CAge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CStreet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CPLZ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CPlace = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CVaccin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CNumVaccinations = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.vaccinationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPersonVaccinationBindingSource)).BeginInit();
            this.GrpsVaccinate.SuspendLayout();
            this.GrbNames.SuspendLayout();
            this.SuspendLayout();
            // 
            // vaccinationBindingSource
            // 
            this.vaccinationBindingSource.DataMember = "Vaccination";
            this.vaccinationBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vaccinationTableAdapter
            // 
            this.vaccinationTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.PersonTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = Impfverwaltung.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.VaccinationTableAdapter = this.vaccinationTableAdapter;
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataMember = "Person";
            this.personBindingSource.DataSource = this.dataSet1;
            // 
            // personTableAdapter
            // 
            this.personTableAdapter.ClearBeforeFill = true;
            // 
            // fKPersonVaccinationBindingSource
            // 
            this.fKPersonVaccinationBindingSource.DataMember = "FK_Person_Vaccination";
            this.fKPersonVaccinationBindingSource.DataSource = this.vaccinationBindingSource;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // TxbSearch
            // 
            this.TxbSearch.Location = new System.Drawing.Point(11, 24);
            this.TxbSearch.Margin = new System.Windows.Forms.Padding(2);
            this.TxbSearch.Name = "TxbSearch";
            this.TxbSearch.Size = new System.Drawing.Size(350, 20);
            this.TxbSearch.TabIndex = 1;
            this.TxbSearch.TextChanged += new System.EventHandler(this.TxbSearch_TextChanged);
            this.TxbSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxbSearch_KeyPress);
            this.TxbSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxbSearch_KeyUp);
            // 
            // ChFirstName
            // 
            this.ChFirstName.Text = "Vorname";
            this.ChFirstName.Width = 120;
            // 
            // ChSecondName
            // 
            this.ChSecondName.Text = "Nachname";
            this.ChSecondName.Width = 147;
            // 
            // ChAge
            // 
            this.ChAge.Text = "Alter";
            // 
            // ChStreet
            // 
            this.ChStreet.Text = "Street";
            this.ChStreet.Width = 193;
            // 
            // ChPlz
            // 
            this.ChPlz.Text = "PLZ";
            this.ChPlz.Width = 69;
            // 
            // ChPlace
            // 
            this.ChPlace.Text = "Ort";
            this.ChPlace.Width = 117;
            // 
            // ChVaccin
            // 
            this.ChVaccin.Text = "Impfung";
            this.ChVaccin.Width = 100;
            // 
            // ChNumVaccinations
            // 
            this.ChNumVaccinations.Text = "Impfdosen";
            this.ChNumVaccinations.Width = 70;
            // 
            // ListViewPerson
            // 
            this.ListViewPerson.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ChFirstName,
            this.ChSecondName,
            this.ChAge,
            this.ChStreet,
            this.ChPlz,
            this.ChPlace,
            this.ChVaccin,
            this.ChNumVaccinations});
            this.ListViewPerson.FullRowSelect = true;
            this.ListViewPerson.GridLines = true;
            this.ListViewPerson.HideSelection = false;
            this.ListViewPerson.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.ListViewPerson.Location = new System.Drawing.Point(11, 84);
            this.ListViewPerson.Margin = new System.Windows.Forms.Padding(2);
            this.ListViewPerson.Name = "ListViewPerson";
            this.ListViewPerson.Size = new System.Drawing.Size(886, 244);
            this.ListViewPerson.TabIndex = 3;
            this.ListViewPerson.UseCompatibleStateImageBehavior = false;
            this.ListViewPerson.View = System.Windows.Forms.View.Details;
            this.ListViewPerson.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.ListViewPerson_DrawColumnHeader);
            this.ListViewPerson.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.ListViewPerson_DrawItem);
            this.ListViewPerson.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // BtnNewEntry
            // 
            this.BtnNewEntry.Location = new System.Drawing.Point(361, 802);
            this.BtnNewEntry.Margin = new System.Windows.Forms.Padding(2);
            this.BtnNewEntry.Name = "BtnNewEntry";
            this.BtnNewEntry.Size = new System.Drawing.Size(148, 24);
            this.BtnNewEntry.TabIndex = 4;
            this.BtnNewEntry.Text = "Neue Person erfassen";
            this.BtnNewEntry.UseVisualStyleBackColor = true;
            this.BtnNewEntry.Click += new System.EventHandler(this.BtnNewEntry_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(11, 802);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(141, 24);
            this.BtnDelete.TabIndex = 6;
            this.BtnDelete.Text = "Löschen";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(184, 802);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(148, 24);
            this.BtnSave.TabIndex = 7;
            this.BtnSave.Text = "Speichern";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // CbxVaccinationPlus
            // 
            this.CbxVaccinationPlus.DataSource = this.vaccinationBindingSource;
            this.CbxVaccinationPlus.DisplayMember = "Vaccine";
            this.CbxVaccinationPlus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxVaccinationPlus.FormattingEnabled = true;
            this.CbxVaccinationPlus.Location = new System.Drawing.Point(6, 19);
            this.CbxVaccinationPlus.Name = "CbxVaccinationPlus";
            this.CbxVaccinationPlus.Size = new System.Drawing.Size(186, 21);
            this.CbxVaccinationPlus.TabIndex = 0;
            // 
            // BtnVaccinate
            // 
            this.BtnVaccinate.Location = new System.Drawing.Point(222, 16);
            this.BtnVaccinate.Name = "BtnVaccinate";
            this.BtnVaccinate.Size = new System.Drawing.Size(75, 23);
            this.BtnVaccinate.TabIndex = 1;
            this.BtnVaccinate.Text = "Impfen";
            this.BtnVaccinate.UseVisualStyleBackColor = true;
            this.BtnVaccinate.Click += new System.EventHandler(this.BtnVaccinate_Click);
            // 
            // GrpsVaccinate
            // 
            this.GrpsVaccinate.Controls.Add(this.BtnVaccinate);
            this.GrpsVaccinate.Controls.Add(this.CbxVaccinationPlus);
            this.GrpsVaccinate.Location = new System.Drawing.Point(594, 653);
            this.GrpsVaccinate.Name = "GrpsVaccinate";
            this.GrpsVaccinate.Size = new System.Drawing.Size(303, 54);
            this.GrpsVaccinate.TabIndex = 14;
            this.GrpsVaccinate.TabStop = false;
            this.GrpsVaccinate.Text = "Impfen";
            // 
            // LFirstName
            // 
            this.LFirstName.AutoSize = true;
            this.LFirstName.Location = new System.Drawing.Point(7, 36);
            this.LFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LFirstName.Name = "LFirstName";
            this.LFirstName.Size = new System.Drawing.Size(49, 13);
            this.LFirstName.TabIndex = 0;
            this.LFirstName.Text = "Vorname";
            // 
            // LLastName
            // 
            this.LLastName.AutoSize = true;
            this.LLastName.Location = new System.Drawing.Point(231, 36);
            this.LLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LLastName.Name = "LLastName";
            this.LLastName.Size = new System.Drawing.Size(59, 13);
            this.LLastName.TabIndex = 1;
            this.LLastName.Text = "Nachname";
            // 
            // LStreet
            // 
            this.LStreet.AutoSize = true;
            this.LStreet.Location = new System.Drawing.Point(7, 60);
            this.LStreet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LStreet.Name = "LStreet";
            this.LStreet.Size = new System.Drawing.Size(42, 13);
            this.LStreet.TabIndex = 2;
            this.LStreet.Text = "Strasse";
            // 
            // lPLZ
            // 
            this.lPLZ.AutoSize = true;
            this.lPLZ.Location = new System.Drawing.Point(231, 60);
            this.lPLZ.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lPLZ.Name = "lPLZ";
            this.lPLZ.Size = new System.Drawing.Size(27, 13);
            this.lPLZ.TabIndex = 3;
            this.lPLZ.Text = "PLZ";
            // 
            // LOrt
            // 
            this.LOrt.AutoSize = true;
            this.LOrt.Location = new System.Drawing.Point(7, 84);
            this.LOrt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LOrt.Name = "LOrt";
            this.LOrt.Size = new System.Drawing.Size(21, 13);
            this.LOrt.TabIndex = 4;
            this.LOrt.Text = "Ort";
            // 
            // LVaccination
            // 
            this.LVaccination.AutoSize = true;
            this.LVaccination.Location = new System.Drawing.Point(231, 107);
            this.LVaccination.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LVaccination.Name = "LVaccination";
            this.LVaccination.Size = new System.Drawing.Size(45, 13);
            this.LVaccination.TabIndex = 5;
            this.LVaccination.Text = "Impfung";
            // 
            // TxbFirstName
            // 
            this.TxbFirstName.Location = new System.Drawing.Point(72, 33);
            this.TxbFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.TxbFirstName.Name = "TxbFirstName";
            this.TxbFirstName.Size = new System.Drawing.Size(150, 20);
            this.TxbFirstName.TabIndex = 6;
            this.TxbFirstName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TxbSecondName
            // 
            this.TxbSecondName.Location = new System.Drawing.Point(299, 33);
            this.TxbSecondName.Margin = new System.Windows.Forms.Padding(2);
            this.TxbSecondName.Name = "TxbSecondName";
            this.TxbSecondName.Size = new System.Drawing.Size(150, 20);
            this.TxbSecondName.TabIndex = 7;
            // 
            // TxbStreet
            // 
            this.TxbStreet.Location = new System.Drawing.Point(72, 57);
            this.TxbStreet.Margin = new System.Windows.Forms.Padding(2);
            this.TxbStreet.Name = "TxbStreet";
            this.TxbStreet.Size = new System.Drawing.Size(150, 20);
            this.TxbStreet.TabIndex = 8;
            // 
            // TxbPlz
            // 
            this.TxbPlz.Location = new System.Drawing.Point(299, 57);
            this.TxbPlz.Margin = new System.Windows.Forms.Padding(2);
            this.TxbPlz.Name = "TxbPlz";
            this.TxbPlz.Size = new System.Drawing.Size(150, 20);
            this.TxbPlz.TabIndex = 9;
            // 
            // TxbPlace
            // 
            this.TxbPlace.Location = new System.Drawing.Point(72, 81);
            this.TxbPlace.Margin = new System.Windows.Forms.Padding(2);
            this.TxbPlace.Name = "TxbPlace";
            this.TxbPlace.Size = new System.Drawing.Size(150, 20);
            this.TxbPlace.TabIndex = 10;
            // 
            // CbxVaccination
            // 
            this.CbxVaccination.DataSource = this.vaccinationBindingSource;
            this.CbxVaccination.DisplayMember = "Vaccine";
            this.CbxVaccination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxVaccination.FormattingEnabled = true;
            this.CbxVaccination.Location = new System.Drawing.Point(299, 104);
            this.CbxVaccination.Margin = new System.Windows.Forms.Padding(2);
            this.CbxVaccination.Name = "CbxVaccination";
            this.CbxVaccination.Size = new System.Drawing.Size(150, 21);
            this.CbxVaccination.TabIndex = 11;
            this.CbxVaccination.SelectedIndexChanged += new System.EventHandler(this.CbxVaccination_SelectedIndexChanged);
            // 
            // LAlter
            // 
            this.LAlter.AutoSize = true;
            this.LAlter.Location = new System.Drawing.Point(231, 84);
            this.LAlter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LAlter.Name = "LAlter";
            this.LAlter.Size = new System.Drawing.Size(28, 13);
            this.LAlter.TabIndex = 12;
            this.LAlter.Text = "Alter";
            // 
            // TxbAge
            // 
            this.TxbAge.Location = new System.Drawing.Point(299, 81);
            this.TxbAge.Margin = new System.Windows.Forms.Padding(2);
            this.TxbAge.Name = "TxbAge";
            this.TxbAge.Size = new System.Drawing.Size(150, 20);
            this.TxbAge.TabIndex = 13;
            this.TxbAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxbAge_KeyPress);
            // 
            // LImpfdosen
            // 
            this.LImpfdosen.AutoSize = true;
            this.LImpfdosen.Location = new System.Drawing.Point(7, 107);
            this.LImpfdosen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LImpfdosen.Name = "LImpfdosen";
            this.LImpfdosen.Size = new System.Drawing.Size(56, 13);
            this.LImpfdosen.TabIndex = 14;
            this.LImpfdosen.Text = "Impfdosen";
            // 
            // TxbNumVaccinations
            // 
            this.TxbNumVaccinations.Location = new System.Drawing.Point(72, 104);
            this.TxbNumVaccinations.Margin = new System.Windows.Forms.Padding(2);
            this.TxbNumVaccinations.Name = "TxbNumVaccinations";
            this.TxbNumVaccinations.Size = new System.Drawing.Size(150, 20);
            this.TxbNumVaccinations.TabIndex = 15;
            this.TxbNumVaccinations.TextChanged += new System.EventHandler(this.TxbNumVaccinations_TextChanged);
            this.TxbNumVaccinations.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxbNumVaccinations_KeyPress);
            // 
            // GrbNames
            // 
            this.GrbNames.Controls.Add(this.TxbNumVaccinations);
            this.GrbNames.Controls.Add(this.LImpfdosen);
            this.GrbNames.Controls.Add(this.TxbAge);
            this.GrbNames.Controls.Add(this.LAlter);
            this.GrbNames.Controls.Add(this.CbxVaccination);
            this.GrbNames.Controls.Add(this.TxbPlace);
            this.GrbNames.Controls.Add(this.TxbPlz);
            this.GrbNames.Controls.Add(this.TxbStreet);
            this.GrbNames.Controls.Add(this.TxbSecondName);
            this.GrbNames.Controls.Add(this.TxbFirstName);
            this.GrbNames.Controls.Add(this.LVaccination);
            this.GrbNames.Controls.Add(this.LOrt);
            this.GrbNames.Controls.Add(this.lPLZ);
            this.GrbNames.Controls.Add(this.LStreet);
            this.GrbNames.Controls.Add(this.LLastName);
            this.GrbNames.Controls.Add(this.LFirstName);
            this.GrbNames.Location = new System.Drawing.Point(11, 653);
            this.GrbNames.Margin = new System.Windows.Forms.Padding(2);
            this.GrbNames.Name = "GrbNames";
            this.GrbNames.Padding = new System.Windows.Forms.Padding(2);
            this.GrbNames.Size = new System.Drawing.Size(499, 145);
            this.GrbNames.TabIndex = 5;
            this.GrbNames.TabStop = false;
            this.GrbNames.Text = "Person";
            this.GrbNames.Enter += new System.EventHandler(this.GrbNames_Enter);
            // 
            // listViewCompletley
            // 
            this.listViewCompletley.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CFirstName,
            this.CSecondName,
            this.CAge,
            this.CStreet,
            this.CPLZ,
            this.CPlace,
            this.CVaccin,
            this.CNumVaccinations});
            this.listViewCompletley.FullRowSelect = true;
            this.listViewCompletley.GridLines = true;
            this.listViewCompletley.HideSelection = false;
            this.listViewCompletley.Location = new System.Drawing.Point(11, 389);
            this.listViewCompletley.Name = "listViewCompletley";
            this.listViewCompletley.Size = new System.Drawing.Size(886, 232);
            this.listViewCompletley.TabIndex = 16;
            this.listViewCompletley.UseCompatibleStateImageBehavior = false;
            this.listViewCompletley.View = System.Windows.Forms.View.Details;
            this.listViewCompletley.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged_1);
            // 
            // CFirstName
            // 
            this.CFirstName.Text = "Vorname";
            this.CFirstName.Width = 125;
            // 
            // CSecondName
            // 
            this.CSecondName.Text = "Nachname";
            this.CSecondName.Width = 142;
            // 
            // CAge
            // 
            this.CAge.Text = "Alter";
            this.CAge.Width = 64;
            // 
            // CStreet
            // 
            this.CStreet.Text = "Strasse";
            this.CStreet.Width = 192;
            // 
            // CPLZ
            // 
            this.CPLZ.Text = "PLZ";
            this.CPLZ.Width = 70;
            // 
            // CPlace
            // 
            this.CPlace.Text = "Ort";
            this.CPlace.Width = 118;
            // 
            // CVaccin
            // 
            this.CVaccin.Text = "Impfung";
            this.CVaccin.Width = 99;
            // 
            // CNumVaccinations
            // 
            this.CNumVaccinations.Text = "Impfdosen";
            this.CNumVaccinations.Width = 68;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.Location = new System.Drawing.Point(11, 363);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 20);
            this.textBox1.TabIndex = 19;
            this.textBox1.Text = "Vollständig geimpfte Personen";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox2.Location = new System.Drawing.Point(11, 59);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(170, 20);
            this.textBox2.TabIndex = 20;
            this.textBox2.Text = "Nicht vollständig geimpfte Personen";
            // 
            // ImpfManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 849);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listViewCompletley);
            this.Controls.Add(this.GrpsVaccinate);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.GrbNames);
            this.Controls.Add(this.BtnNewEntry);
            this.Controls.Add(this.ListViewPerson);
            this.Controls.Add(this.TxbSearch);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ImpfManagement";
            this.Text = "ImpfManagement";
            this.Load += new System.EventHandler(this.ImpfManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vaccinationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPersonVaccinationBindingSource)).EndInit();
            this.GrpsVaccinate.ResumeLayout(false);
            this.GrbNames.ResumeLayout(false);
            this.GrbNames.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private DataSet1 dataSet1;
        private BindingSource vaccinationBindingSource;
        private DataSet1TableAdapters.VaccinationTableAdapter vaccinationTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private BindingSource personBindingSource;
        private DataSet1TableAdapters.PersonTableAdapter personTableAdapter;
        private BindingSource fKPersonVaccinationBindingSource;
        private Label label1;
        private TextBox TxbSearch;
        private ColumnHeader ChFirstName;
        private ColumnHeader ChSecondName;
        private ColumnHeader ChAge;
        private ColumnHeader ChStreet;
        private ColumnHeader ChPlz;
        private ColumnHeader ChPlace;
        private ColumnHeader ChVaccin;
        private ColumnHeader ChNumVaccinations;
        private ListView ListViewPerson;
        private Button BtnNewEntry;
        private Button BtnDelete;
        private Button BtnSave;
        private ComboBox CbxVaccinationPlus;
        private Button BtnVaccinate;
        private GroupBox GrpsVaccinate;
        private Label LFirstName;
        private Label LLastName;
        private Label LStreet;
        private Label lPLZ;
        private Label LOrt;
        private Label LVaccination;
        private TextBox TxbFirstName;
        private TextBox TxbSecondName;
        private TextBox TxbStreet;
        private TextBox TxbPlz;
        private TextBox TxbPlace;
        private ComboBox CbxVaccination;
        private Label LAlter;
        private TextBox TxbAge;
        private Label LImpfdosen;
        private TextBox TxbNumVaccinations;
        private GroupBox GrbNames;
        private ListView listViewCompletley;
        private ColumnHeader CFirstName;
        private ColumnHeader CSecondName;
        private ColumnHeader CAge;
        private ColumnHeader CNumVaccinations;
        private TextBox textBox1;
        private TextBox textBox2;
        private ColumnHeader CStreet;
        private ColumnHeader CPLZ;
        private ColumnHeader CPlace;
        private ColumnHeader CVaccin;
        //private DataSet1 dataSet1;
        //private BindingSource vaccinationBindingSource;
        //private DataSet1TableAdapters.VaccinationTableAdapter vaccinationTableAdapter;
    }
}

