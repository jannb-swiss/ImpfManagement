using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Impfverwaltung.Controller;
using Impfverwaltung.Database;


namespace Impfverwaltung.View
{
    public partial class ImpfManagement : Form
    {
        private enum EditPerson { New, Edit };
        private EditPerson _ePerson;
        private string _searchPersonName = string.Empty;
        private ControllerPerson _controllerPerson;

        public ImpfManagement()
        {
            InitializeComponent();
            _controllerPerson = new ControllerPerson();
            _ePerson = EditPerson.Edit;
        }

        private void ClearAllText()
        {
            TxbFirstName.Text = string.Empty;
            TxbSecondName.Text = string.Empty;
            TxbStreet.Text = string.Empty;
            TxbPlz.Text = string.Empty;
            TxbPlace.Text = string.Empty;
            TxbAge.Text = string.Empty;
            TxbNumVaccinations.Text = string.Empty;
            CbxVaccination.SelectedIndex = 0;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            _searchPersonName = TxbSearch.Text;
            RefreshList(_searchPersonName);
        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listViewCompletley.SelectedItems.Count <= 0)
            {
                return;
            }

            var person = listViewCompletley.SelectedItems[0].Tag as Person;

            if (person == null)
            {
                return;
            }

            TxbFirstName.Text = person.FirstName;
            TxbSecondName.Text = person.SecondName;
            TxbAge.Text = person.Age.ToString();
            TxbStreet.Text = person.Street;
            TxbPlz.Text = person.Plz;
            TxbPlace.Text = person.Place;
            CbxVaccination.Text = person.Vaccination.Vaccine;
            TxbNumVaccinations.Text = person.NumVaccinations.ToString();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListViewPerson.SelectedItems.Count <= 0)
            {
                return;
            }

            var person = ListViewPerson.SelectedItems[0].Tag as Person;

            if (person == null)
            {
                return;
            }

            TxbFirstName.Text = person.FirstName;
            TxbSecondName.Text = person.SecondName;
            TxbAge.Text = person.Age.ToString();
            TxbStreet.Text = person.Street;
            TxbPlz.Text = person.Plz;
            TxbPlace.Text = person.Place;
            CbxVaccination.Text = person.Vaccination.Vaccine;
            TxbNumVaccinations.Text = person.NumVaccinations.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnNewEntry_Click(object sender, EventArgs e)
        {
            if (_ePerson == EditPerson.Edit)
            {
                _ePerson = EditPerson.New;
                BtnNewEntry.BackColor = Color.DarkGray;

                TxbSearch.Enabled = false;
                BtnDelete.Enabled = false;
                BtnVaccinate.Enabled = false;
                CbxVaccinationPlus.Enabled = false;

                if (ListViewPerson.SelectedItems.Count > 0)
                {
                    ListViewPerson.SelectedItems[0].Tag = null;
                }

                ListViewPerson.Enabled = false;

                if (listViewCompletley.SelectedItems.Count > 0)
                {
                    listViewCompletley.SelectedItems[0].Tag = null;
                }

                listViewCompletley.Enabled = false;

            }
            else
            {
                _ePerson = EditPerson.Edit;
                BtnNewEntry.BackColor = SystemColors.Window;

                CbxVaccinationPlus.Enabled = true;
                BtnVaccinate.Enabled = true;
                TxbSearch.Enabled = true;
                BtnDelete.Enabled = true;
                ListViewPerson.Enabled = true;
                listViewCompletley.Enabled = true;
            }
            RefreshList(_searchPersonName);
            ClearAllText();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (ListViewPerson.SelectedItems.Count <= 0)
            {
                return;
            }

            var person = ListViewPerson.SelectedItems[0].Tag as Person;

            if (person == null)
             {
                return;
             }

            _controllerPerson.DeletePerson(person);
            RefreshList(_searchPersonName);
            ClearAllText();

        }

        private void BtnVaccinate_Click(object sender, EventArgs e)
        {
            Person newPerson;

            if (ListViewPerson.SelectedItems.Count <= 0)
            {
                return;
            }

            var person = ListViewPerson.SelectedItems[0].Tag as Person;

            if (person.NumVaccinations >= 3)
            {
                MessageBox.Show($"Diese Person wurde schon zwei mal geimpft", "Achtung!", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            } else if (person.Age <= 65 && person.NumVaccinations >= 2)
            {
                MessageBox.Show($"Eine Person unter 65 darf nur zwei mal geimpft werden!", "Achtung!", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            else
            {
                person.NumVaccinations = person.NumVaccinations + 1;
                TxbNumVaccinations.Text = person.NumVaccinations.ToString();

                newPerson = new Person();
                newPerson.Id = person.Id;

                if (!CreateNewPerson(newPerson))
                {
                    return;
                }

                _controllerPerson.UpdatePerson(newPerson);
            }

            RefreshList(_searchPersonName);
            ClearAllText();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Person newPerson;
            switch (_ePerson)
            {
                case EditPerson.Edit:
                    if (ListViewPerson.SelectedItems.Count <= 0 || ListViewPerson.SelectedItems[0].Tag == null)
                    {
                        return;
                    }

                    var person = ListViewPerson.SelectedItems[0].Tag as Person;

                    if (person == null)
                    {
                        return;
                    }


                    newPerson = new Person();
                    newPerson.Id = person.Id;

                    if (!CreateNewPerson(newPerson))
                    {
                        return;
                    }

                    _controllerPerson.UpdatePerson(newPerson);
                    break;
                case EditPerson.New:
                    newPerson = new Person();

                    if (!CreateNewPerson(newPerson))
                    {
                        return;
                    }

                    _controllerPerson.EntryPerson(newPerson);
                    break;
            }
            RefreshList(_searchPersonName);
            ClearAllText();
        }

        private void RefreshList(string searchWord)
        {
            if (!_controllerPerson.GetPersonList().Any())
            {
                return;
            }

            ListViewPerson.Items.Clear();

            var tmpPersonList =  _controllerPerson.GetNotFullVaccPerson().Where(x => x.FirstName.ToUpper().Contains(searchWord.ToUpper()));

            foreach (var lvi in from item in tmpPersonList let row = new string[] {
                item.FirstName,
                item.SecondName,
                item.Age.ToString(),
                item.Street,
                item.Plz,
                item.Place,
                item.Vaccination.Vaccine,
                item.NumVaccinations.ToString()
            } select new ListViewItem(row) { Tag = item })
            {
               
                ListViewPerson.Items.Add(lvi);
            }
            ListViewPerson.Refresh();

            if (!_controllerPerson.GetPersonList().Any())
            {
                return;
            }

            listViewCompletley.Items.Clear();


            var tmpPersonList1 = _controllerPerson.GetFullVaccPerson().Where(x => x.FirstName.ToUpper().Contains(searchWord.ToUpper()));

            foreach (var lvi in from item in tmpPersonList1
                                let row = new string[] {
                item.FirstName,
                item.SecondName,
                item.Age.ToString(),
                item.Street,
                item.Plz,
                item.Place,
                item.Vaccination.Vaccine,
                item.NumVaccinations.ToString()
                }
                                select new ListViewItem(row) { Tag = item })
            {
                listViewCompletley.Items.Add(lvi);
            }


            listViewCompletley.Refresh();
        }



        private bool CreateNewPerson(Person newPerson)
        {
            if (string.IsNullOrEmpty(TxbFirstName.Text) ||
                string.IsNullOrEmpty(TxbSecondName.Text) ||
                string.IsNullOrEmpty(TxbStreet.Text) ||
                string.IsNullOrEmpty(TxbPlz.Text) ||
                string.IsNullOrEmpty(TxbPlace.Text) ||
                string.IsNullOrEmpty(TxbAge.Text) ||
                string.IsNullOrEmpty(TxbNumVaccinations.Text))
            {
                MessageBox.Show($"Bitte alle Felder komplett ausfüllen!", "Hinweis", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return false;
            }

            newPerson.FirstName = TxbFirstName.Text;
            newPerson.SecondName = TxbSecondName.Text;
            newPerson.Age = Convert.ToInt32(TxbAge.Text);
            newPerson.Street = TxbStreet.Text;
            newPerson.Plz = TxbPlz.Text;
            newPerson.Place = TxbPlace.Text;
            newPerson.NumVaccinations = Convert.ToInt32(TxbNumVaccinations.Text);


            var first = _controllerPerson.GetVaccinationList()?.FirstOrDefault(x => x.Vaccine.Equals(CbxVaccination.Text));
            if (first != null)
            {
                newPerson.Vaccination = new Vaccination { VaccinationId = first.VaccinationId };
            }
            return true;
        }

        private void ImpfManagement_Load(object sender, EventArgs e)
        {
           
            this.personTableAdapter.FillCompletely(this.dataSet1.Person);
           
            this.vaccinationTableAdapter.Fill(this.dataSet1.Vaccination);
           
            this.vaccinationTableAdapter.Fill(this.dataSet1.Vaccination);
            RefreshList(_searchPersonName);
        }

        private void ListViewPerson_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void ListViewPerson_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            using (var sf = new StringFormat())
            {
                using (var headerFont = new Font("Helvetica", 10, FontStyle.Bold))
                {
                    e.Graphics.DrawString(e.Header.Text, headerFont, Brushes.Black, e.Bounds, sf);
                }
            }
        }

        private void TxbAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxbNumVaccinations_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
                BtnSearch_Click(null, null);
        }
        
        private void TxbSearch_TextChanged(object sender, EventArgs e)
        {
            _searchPersonName = TxbSearch.Text;
            RefreshList(_searchPersonName);
        }

        private void TxbSearch_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void GrbNames_Enter(object sender, EventArgs e)
        {

        }

        private void CbxVaccination_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TxbNumVaccinations_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
