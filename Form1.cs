using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsertRow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.htmlEditControl1.ToolStripItems.Add("InsertRows").Click += InsertRows_Click;
            this.htmlEditControl1.ToolStripItems.Add("InsertHRs").Click += InsertHRs_Click;
        }

        private void InsertHRs_Click(object sender, EventArgs e)
        {
            HtmlElement element;

            element = FindParentElementIfTable(this.htmlEditControl1.CurrentWindowsFormsElement);

            if (element != null)
            {
                HtmlElement hr = this.htmlEditControl1.Document.CreateElement("hr");
<<<<<<< HEAD
                hr.Style = "border: 5px solid red";
=======
                hr.Style = "border: 5px solid red"; 
>>>>>>> c019fa3c7af02696601dc950aa2311d355b11c34
                HtmlElement hr2 = this.htmlEditControl1.Document.CreateElement("hr");
                hr2.Style = "border: 5px solid red";

                element.InsertAdjacentElement(HtmlElementInsertionOrientation.BeforeBegin, hr);
                element.InsertAdjacentElement(HtmlElementInsertionOrientation.AfterEnd, hr2);
<<<<<<< HEAD

                this.htmlEditControl1.SetDirty(true);
=======
>>>>>>> c019fa3c7af02696601dc950aa2311d355b11c34
            }
        }

        private void InsertRows_Click(object sender, EventArgs e)
        {

            // requires colspan attribute value for td child element of tr. is possible to find but would require iterating thru the first tr child elements

            HtmlElement element;

            element = FindParentElementIfTable(this.htmlEditControl1.CurrentWindowsFormsElement);

            if (element != null)
            {
                HtmlElement newRow = this.htmlEditControl1.Document.CreateElement("tr");
                newRow.InsertAdjacentElement(HtmlElementInsertionOrientation.AfterBegin, this.htmlEditControl1.Document.CreateElement("td")).SetAttribute("colspan", "5");
                newRow.Style = "background-color: red";
                element.InsertAdjacentElement(HtmlElementInsertionOrientation.AfterBegin, newRow);

                HtmlElement newRow2 = this.htmlEditControl1.Document.CreateElement("tr");
                newRow2.InsertAdjacentElement(HtmlElementInsertionOrientation.AfterBegin, this.htmlEditControl1.Document.CreateElement("td")).SetAttribute("colspan", "5");
                newRow2.Style = "background-color: red";
                element.InsertAdjacentElement(HtmlElementInsertionOrientation.BeforeEnd, newRow2);

            }
        }

        private HtmlElement FindParentElementIfTable(HtmlElement element)
        {
            if (element.TagName.ToLower() == "table")
                return element;

            if (element.TagName.ToLower() == "body")
                return null;

            return FindParentElementIfTable(element.Parent);

        }

        private void htmlEditControl1_Load(object sender, EventArgs e)
        {

        }

    }
}
