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
                this.LoadFile(file.filePath, RichTextBoxStreamType.PlainText);
            }
        }

        private myFile mFile;
    }
}
