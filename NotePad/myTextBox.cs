using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NotePad.pocos;


namespace NotePad
{
    public class myTextBox : RichTextBox
    {

         public int start = 0;
        public int indexOfSearchText = 0;

        public myTextBox()
        {
            this.mFile = new myFile();
            this.Name = "file";
            this.Dock = DockStyle.Fill;
        }

        public myTextBox(myFile file)
        {
            this.mFile = file;
            this.Name = "file";
            this.Dock = DockStyle.Fill;
            this.LoadFile(file.filePath, RichTextBoxStreamType.PlainText);
        }

        public myFile file {
            get { return mFile; }
            set { this.mFile = value;
                this.LoadFile(file.filePath, RichTextBoxStreamType.PlainText);
            }
        }

        public bool isModified
        {
            get { return file.modified; }
            set { this.file.modified = value; }
        }

        public String filePath {
            get { return file.filePath; }
            set { this.file.filePath = value;
            }
        }

        public void openFile(String filePath) {
            this.filePath = filePath;
            this.LoadFile(file.filePath, RichTextBoxStreamType.PlainText);
        }

        public void saveFile(String filePath)
        {
            this.filePath = filePath;
            this.SaveFile(file.filePath, RichTextBoxStreamType.PlainText);
            this.isModified = false;
        }

        public void initSearch() {
            start = 0;
        indexOfSearchText = 0;
    }

        public int FindMyText(string txtToSearch, int searchStart, int searchEnd)
        {
            // Unselect the previously searched string
            if (searchStart > 0 && searchEnd > 0 && indexOfSearchText >= 0)
            {
                this.SelectAll();
                this.SelectionColor = this.ForeColor;
                this.Select(0,0);
            }

            // Set the return value to -1 by default.
            int retVal = -1;

            // A valid starting index should be specified.
            // if indexOfSearchText = -1, the end of search
            if (searchStart >= 0 && indexOfSearchText >= 0)
            {
                // A valid ending index
                if (searchEnd > searchStart || searchEnd == -1)
                {
                    // Find the position of search string in RichTextBox
                    indexOfSearchText = this.Find(txtToSearch, searchStart, searchEnd, RichTextBoxFinds.None);
                    // Determine whether the text was found in richTextBox1.
                    if (indexOfSearchText != -1)
                    {
                        // Return the index to the specified search text.
                        retVal = indexOfSearchText;
                    }
                }
            }
            return retVal;
        }

        private myFile mFile;
    }
}
