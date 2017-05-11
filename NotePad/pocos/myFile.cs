using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotePad.pocos
{
    public class myFile
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

        public String fileName
        {
            get {
                String filename = "";
                for (int i = filePath.Length-1; i >=0 ; i--)
                {
                    if (filePath[i].Equals('\\'))
                    {
                        return filename;
                    }
                    filename = filePath[i]+filename;
                }
                return filename;
            }
        }


        private String mFilePath;
        private Boolean mModified;
    }
}
