using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kr_alg
{
    class Node
    {
        
        int nName;
        int temp=0;
        public int nRank;
        public Node vRoot;
        public System.Drawing.Point pPosition;
      

        
        public int Name
        {
            get
            {
                return nName;
            }
        }
        

        public Node(int nName, System.Drawing.Point pPosition)
        {
            this.nName = nName;
            nRank = 0;
            this.vRoot = this;
            this.pPosition = pPosition;
        }

        
        internal Node GetRoot()
        {
            if (this.vRoot != this)// check if parent
            {
                this.vRoot = this.vRoot.GetRoot();// get parent if child
            }
           /* else { 
                temp++;
                if (temp > 1) {
                MessageBox.Show("Unconnected graph", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Application.Exit();
                }
                
                } */
            return this.vRoot;
        }

        internal static void Join(Node vRoot1, Node vRoot2)
        {

            if (vRoot2.nRank < vRoot1.nRank)//check if rank of Root2 less than that of Root1
            {
                vRoot2.vRoot = vRoot1;//if yes - Root1 is the parent of Root2
                
            }
            else //rank of Root2 is greater than or equal to that of Root1
            {
                vRoot1.vRoot = vRoot2;//make Root2 the parent
                if (vRoot1.nRank == vRoot2.nRank)// if both ranks are equal
                {
                    vRoot1.nRank++;//increment one of them to make a root
                }
            }
        }

    }
}
