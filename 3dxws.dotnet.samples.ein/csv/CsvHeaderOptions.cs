//------------------------------------------------------------------------------------------------------------------------------------
// Copyright 2020-2021 Dassault Systèmes - CPE EMED
//
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation
// files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify,
// merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished
// to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES 
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS
// BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//------------------------------------------------------------------------------------------------------------------------------------

using System;
using System.IO;

namespace ds.emedcpe.samples.ein.csv
{
    public class CsvHeaderOptions
    {
        bool m_usesTitle = false;
        bool m_usesName = false;
        bool m_usesRevision = false;
        bool m_hasCollabSpace = false;
        int m_collabSpaceColPos = -1;
        int m_revisionColPos = -1;
        int m_einColPos = -1;

        public CsvHeaderOptions(string _csvFilename)
        {
            using (StreamReader reader = new StreamReader(_csvFilename))
            {
                string headerLine = reader.ReadLine();

                string[] headers = headerLine.Split(',');

                if ((headers.Length != 3) && (headers.Length != 4))
                {
                    throw new Exception(string.Format("Error CSV format header: Expecting 3 or 4 columns in the header getting {0}.", headers.Length));
                }

                if (headers[0].Equals("TITLE", StringComparison.InvariantCultureIgnoreCase))
                {
                    this.UsesTitle = true;
                }
                else
                {
                    if (headers[0].Equals("NAME", StringComparison.InvariantCultureIgnoreCase))
                    {
                        this.UsesName = true;
                    }
                    else
                    {
                        throw (new Exception("Error CSV format header: The first column in the csv needs to be either Title or Name"));
                    }
                }

                for (int i = 0; i < headers.Length; i++)
                {
                    string testHeader = headers[i];

                    if (testHeader.Equals("COLLABORATIVE SPACE", StringComparison.InvariantCultureIgnoreCase) ||
                        testHeader.Equals("COLLABORATIVESPACE", StringComparison.InvariantCultureIgnoreCase) ||
                        testHeader.Equals("COLLAB SPACE", StringComparison.InvariantCultureIgnoreCase) ||
                        testHeader.Equals("COLLABSPACE", StringComparison.InvariantCultureIgnoreCase))
                    {
                        UsesCollabSpace = true;
                        CollabSpaceColumn = i;
                    }
                }

                for (int i = 0; i < headers.Length; i++)
                {
                    string testHeader = headers[i];

                    if (testHeader.Equals("REVISION", StringComparison.InvariantCultureIgnoreCase) ||
                        testHeader.Equals("REV", StringComparison.InvariantCultureIgnoreCase))
                    {
                        UsesRevision = true;
                        RevisionColumn = i;
                    }
                }

                for (int i = 0; i < headers.Length; i++)
                {
                    string testHeader = headers[i];

                    if (testHeader.Equals("EIN", StringComparison.InvariantCultureIgnoreCase) ||
                        testHeader.Equals("PROPOSED EIN", StringComparison.InvariantCultureIgnoreCase) ||
                        testHeader.Equals("PART NUMBER", StringComparison.InvariantCultureIgnoreCase))
                    {
                        EINColumn = i;
                    }
                }
            }
        }

        public bool UsesTitle { get { return m_usesTitle; } private set { m_usesTitle = value; } }
        public int TitleColumn { get { return 0; } }

        public bool UsesName { get { return m_usesName; } private set { m_usesName = value; } }
        public int NameColumn { get { return 0; } }

        public bool UsesRevision { get { return m_usesRevision; } private set { m_usesRevision = value; } }
        public int RevisionColumn { get { return m_revisionColPos; } private set => m_revisionColPos = value; }

        public bool UsesCollabSpace { get => m_hasCollabSpace; private set => m_hasCollabSpace = value; }
        public int CollabSpaceColumn { get => m_collabSpaceColPos; private set => m_collabSpaceColPos = value; }

        public int EINColumn { get => m_einColPos; private set => m_einColPos = value; }


    }
}
