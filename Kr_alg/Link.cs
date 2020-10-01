using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kr_alg
{
    class Link : IComparable
    {
        
        Node v1, v2;
        int nWeight;
        System.Drawing.Point pStringPosition;
        

        
        public Node V1
        {
            get
            {
                return v1;
            }
        }
        public Node V2
        {
            get
            {
                return v2;
            }
        }
        public int Weight
        {
            get
            {
                return nWeight;
            }
        }
        public System.Drawing.Point StringPosition
        {
            get
            {
                return pStringPosition;
            }
        }
      

        public Link(Node v1, Node v2, int nWeight, System.Drawing.Point pStringPosition)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.nWeight = nWeight;
            this.pStringPosition = pStringPosition;
        }

        

        public int CompareTo(object obj)
        {
            Link e = (Link)obj;
            return this.nWeight.CompareTo(e.nWeight);
        }

        

        internal static void QuickSortmin(List<Link> m_lstEdgesInitial, int nLeft, int nRight)
        {
            int i, j, x;
            i = nLeft; j = nRight;
            x = m_lstEdgesInitial[(nLeft + nRight) / 2].Weight;

            do
            {
                while ((m_lstEdgesInitial[i].Weight < x) && (i < nRight)) i++;
                while ((x < m_lstEdgesInitial[j].Weight) && (j > nLeft)) j--;

                if (i <= j)
                {
                    Link y = m_lstEdgesInitial[i];
                    m_lstEdgesInitial[i] = m_lstEdgesInitial[j];
                    m_lstEdgesInitial[j] = y;
                    i++; j--;
                }
            } while (i <= j);

            if (nLeft < j) QuickSortmin(m_lstEdgesInitial, nLeft, j);
            if (i < nRight) QuickSortmin(m_lstEdgesInitial, i, nRight);
            
        }

        internal static void QuickSortmax(List<Link> m_lstEdgesInitial, int nLeft, int nRight)
        {
            int i, j, x;
            i = nLeft; j = nRight;
            x = m_lstEdgesInitial[(nLeft + nRight) / 2].Weight;

            do
            {
                while ((m_lstEdgesInitial[i].Weight > x) && (i < nRight)) i++;
                while ((x > m_lstEdgesInitial[j].Weight) && (j > nLeft)) j--;

                if (i <= j)
                {
                    Link y = m_lstEdgesInitial[i];
                    m_lstEdgesInitial[i] = m_lstEdgesInitial[j];
                    m_lstEdgesInitial[j] = y;
                    i++; j--;
                }
            } while (i <= j);

            if (nLeft < j) QuickSortmax(m_lstEdgesInitial, nLeft, j);
            if (i < nRight) QuickSortmax(m_lstEdgesInitial, i, nRight);

        }
    }
}
