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


using ds.enovia.dseng.model;


namespace ds.emedcpe.samples.ein.model
{
    public class ItemProposedEIN
    {
        private string m_title = null;
        private string m_revision = null;
        private string m_proposedEIN = null;
        private string m_existingEIN = null;
        private string m_physicalId = null;

        private EngineeringItem m_item = null;

        private string m_collabSpace = null;
        private string m_lastUpdateStatus = null;

        public ItemProposedEIN Clone()
        {
            ItemProposedEIN cloneItemProposedEIN = new ItemProposedEIN();
            cloneItemProposedEIN.Title = this.Title;
            cloneItemProposedEIN.Revision = this.Revision;
            cloneItemProposedEIN.ProposedEIN = this.ProposedEIN;
            cloneItemProposedEIN.CollabSpace = this.CollabSpace;

            return cloneItemProposedEIN;
        }

        public string Title { get => m_title; set => m_title = value; }
        public string Revision { get => m_revision; set => m_revision = value; }
        public string ExistingEIN { get => m_existingEIN; set => m_existingEIN = value; }
        public EngineeringItem Item { get => m_item; set => m_item = value; }
        public string ProposedEIN { get => m_proposedEIN; set => m_proposedEIN = value; }
        public string CollabSpace { get => m_collabSpace; set => m_collabSpace = value; }
        public string LastUpdateStatus { get => m_lastUpdateStatus; set => m_lastUpdateStatus = value; }
        public string PhysicalId { get => m_physicalId; set => m_physicalId = value; }

    }
}
