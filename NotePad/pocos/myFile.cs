using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotePad.pocos
{
    class myFile
    {

        public myFile() {
            this.filePath = "";
            this.modified = false;
        }

        public myFile(String filePath, Boolean modified)
        {
            this.filePath = filePath;
            this.modified = modified;
        }

        public String filePath {
            get { return mFilePath; }
            set { mFilePath = value; }
        }

        public Boolean modified {
            get { return mModified; }
            set { mModified = value; }
        }


        private String mFilePath;
        private Boolean mModified;
    }
}
