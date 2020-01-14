using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemSety
{
    public partial class Form1 : Form
    {
        CreatNetWork CreatNetWork;
        List<Node> NodeList;
        public Form1()
        {
            InitializeComponent();
            CreatNetWork = new CreatNetWork();
            NodeList = CreatNetWork.NodeList;
        }
        int k = 0;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            k = 0;
            string pathName, nodeName = null;
            if (comboBox1.SelectedIndex == 0)
            {
                pathName = null;
                for (int i = 0; i < NodeList.Count(); i++)
                {
                    for (int j = 0; j < NodeList.Count(); j++)
                    {
                        if (NodeList[i].SearchOutConnection("Значение", NodeList[j]))
                        {
                            if (Convert.ToString(NodeList[j].Name)=="Фэнтази")
                            {
                                k = i;
                                for (int m = 0; m < k; m++)
                                {
                                    if (NodeList[m].SearchIncomingConnection("Объект", NodeList[k]))
                                    {
                                        pathName += Convert.ToString(NodeList[m].Name) + "   ";
                                    }
                                }
                            }
                        }
                    }

                }
                label2.Text = pathName;
            }

            if (comboBox1.SelectedIndex == 1)
            {
                pathName = null;
                for(int i=0;i<NodeList.Count();i++)
                {
                    for (int j = 0; j < NodeList.Count(); j++)
                    {
                        if (NodeList[i].SearchOutConnection("Продолжительность", NodeList[j]))
                        {
                            if (Convert.ToInt32(NodeList[j].Name) > 120)
                            {
                                pathName += Convert.ToString(NodeList[i].Name)+"   ";
                            }
                        }
                    }
                    
                }
                label2.Text = pathName;
            }
        }
    }
}
