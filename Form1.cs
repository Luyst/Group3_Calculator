using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string S = "";
        public static bool check = false;
        public static double result;
        public static int Countmn = 0;
        public static int Countdn = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            S+="1";
            textBox1.Text=S;
            check = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            S+="2";
            textBox1.Text=S;
            check = false;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            S+="3";
            textBox1.Text=S;
            check = false;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            S+="4";
            textBox1.Text=S;
            check = false;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            S+="5";
            textBox1.Text=S;
            check = false;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            S+="6";
            textBox1.Text=S;
            check = false;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            S+="7";
            textBox1.Text=S;
            check = false;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            S+="8";
            textBox1.Text=S;
            check = false;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            S+="9";
            textBox1.Text=S;
            check = false;
        }
        private void button14_Click(object sender, EventArgs e)
        {
            S+="0";
            textBox1.Text=S;
            check = false;
        }
        private void button15_Click(object sender, EventArgs e)
        {
            if (check==true)
            {
                S+=result;
                check=false;
            }
            if (S.Length>0 && S[S.Length-1]!='(')
            {
                if (S[S.Length-1]!='+' && S[S.Length-1]!='-' && S[S.Length-1]!='*' && S[S.Length-1]!='/' && S[S.Length-1]!=',' && S[S.Length-1]!='^')
                {
                    S+=",";
                    textBox1.Text=S;
                }
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            if (S.Length>0 && Countmn==Countdn)
            {
                if (S[S.Length-1]!='+' && S[S.Length-1]!='-' && S[S.Length-1]!='*' && S[S.Length-1]!='/' && S[S.Length-1]!=',' && S[S.Length-1]!='^')
                {
                    BinarySearchTree btn = new BinarySearchTree();
                    Node node = btn.TreeNode(S);
                    btn.Traverin(node);
                    result =BinarySearchTree.Tong(BinarySearchTree.listarray);
                    textBox1.Text=Convert.ToString(result);
                    BinarySearchTree.listarray=new string[100];
                    textBox2.Text+=S+"="+result;
                    textBox2.Text+="\t";
                    S ="";
                    check=true;
                }
            }           
        }
        private void button11_Click(object sender, EventArgs e)
        {
            if (check==true)
            {
                S+=result;
                check=false;
            }
            if (S.Length>0 && S[S.Length-1]!='(')
            {
                if (S[S.Length-1]!='+' && S[S.Length-1]!='-' && S[S.Length-1]!='*' && S[S.Length-1]!='/' && S[S.Length-1]!=',' && S[S.Length-1]!='^')
                {
                    S+="+";
                    textBox1.Text=S;
                }
            }
        }
        private void button12_Click(object sender, EventArgs e)
        {
            if (check==true)
            {
                S+=result;
                check=false;
            }
            if (S.Length>0)
            {
                if (S[S.Length-1]!='+' && S[S.Length-1]!='-' && S[S.Length-1]!='*' && S[S.Length-1]!='/' && S[S.Length-1]!=',' && S[S.Length-1]!='^')
                {
                    S+="-";
                    textBox1.Text=S;
                }
            }
        }
        private void button13_Click(object sender, EventArgs e)
        {
            if (check==true)
            {
                S+=result;
                check=false;
            }
            if (S.Length>0 && S[S.Length-1]!='(')
            {
                if (S[S.Length-1]!='+' && S[S.Length-1]!='-' && S[S.Length-1]!='*' && S[S.Length-1]!='/' && S[S.Length-1]!=',' && S[S.Length-1]!='^')
                {
                    S+="*";
                    textBox1.Text=S;
                }
            }
        }
        private void button19_Click(object sender, EventArgs e)
        {
            if (check==true)
            {
                S+=result;
                check=false;
            }
            if (S.Length>0 && S[S.Length-1]!='(')
            {
                if (S[S.Length-1]!='+' && S[S.Length-1]!='-' && S[S.Length-1]!='*' && S[S.Length-1]!='/' && S[S.Length-1]!=',' && S[S.Length-1]!='^')
                {
                    S+="/";
                    textBox1.Text=S;
                }
            }
        }
        private void button18_Click(object sender, EventArgs e)
        {
            if (S.Length==0)
            {
                S+="(";
                textBox1.Text=S;
                Countmn++;
            }
            else if (S[S.Length-1]=='+' || S[S.Length-1]=='-' || S[S.Length-1]=='*' || S[S.Length-1]=='/' || S[S.Length-1]=='^' || S[S.Length-1]=='(' || S[S.Length-2]=='g')
            {
                S+="(";
                textBox1.Text=S;
                Countmn++;
            }
            check = false;
        }
        private void button20_Click(object sender, EventArgs e)
        {
            if (S[S.Length-1]!='(')
            {
                if (S.Length>0 && Countmn>0 && Countmn>Countdn)
                {
                    if (S[S.Length-1]!='+' && S[S.Length-1]!='-' && S[S.Length-1]!='*' && S[S.Length-1]!='/' && S[S.Length-1]!=',' && S[S.Length-1]!='^')
                    {
                        S+=")";
                        textBox1.Text=S;
                        Countdn++;
                    }
                }
            }
            check = false;
        }
        private void button16_Click(object sender, EventArgs e)
        {
            if (check==true)
            {
                S+=result;
                check=false;
            }
            if (S.Length>0 && S[S.Length-1]!='(')
            {
                if (S[S.Length-1]!='+' && S[S.Length-1]!='-' && S[S.Length-1]!='*' && S[S.Length-1]!='/' && S[S.Length-1]!=',' && S[S.Length-1]!='^')
                {
                    S+="^";
                    textBox1.Text=S;
                }
            }
        }
        private void button17_Click(object sender, EventArgs e)
        {
            if (S.Length==0)
            {
                S+="log";
                textBox1.Text=S;
            }
            else if (S[S.Length-1]=='+' || S[S.Length-1]=='-' || S[S.Length-1]=='*' || S[S.Length-1]=='/' || S[S.Length-1]=='^' || S[S.Length-1]=='(')
            {
                S+="log";
                textBox1.Text=S;
            }
            check = false;
        }
        private void button21_Click(object sender, EventArgs e)
        {
            S="";
            textBox1.Text=S;
            check = false;
        }
        private void button22_Click(object sender, EventArgs e)
        {
            if (S.Length>0)
            {
                if (S[S.Length-1]=='(')
                {
                    Countmn--;
                }
                else if (S[S.Length-1]==')')
                {
                    Countdn--;
                }
                S=S.Remove(S.Length-1, 1);
                textBox1.Text=S;
            }
            check = false;
        }
    }
    public class Node
    {
        public Node Left;
        public Node Right;
        public string Value;
        public Node()
        {
            Value=null;
        }
        public Node(string s)
        {
            Value=s;
        }
    }
    public class BinarySearchTree
    {
        private static void Create(Stack<Node> Stack, Stack<Node> nodeStack)
        {
            Node node = Stack.Pop();
            node.Right = nodeStack.Pop();
            if (node.Value!="sqrt")
                node.Left = nodeStack.Pop();
            nodeStack.Push(node);
        }
        public Node TreeNode(string array)
        {
            Stack<Node> Stack = new Stack<Node>();
            Stack<Node> nodeStack = new Stack<Node>();
            string chuoi = "";
            while (array.Length>0)
            {
                if (char.IsLetter(array[0]))
                {
                    if (array[0]=='s' || array[0]=='l')
                    {
                        while (array.Length>0 && (char.IsLetter(array[0])))
                        {
                            chuoi+=array[0];
                            array=array.Remove(0, 1);
                        }
                        if (chuoi.Length>0)
                        {
                            Stack.Push(new Node(Convert.ToString(chuoi)));
                            chuoi="";
                        }
                    }
                }
                else if (char.IsNumber(array[0]))
                {
                    while (array.Length>0 && (char.IsNumber(array[0]) || array[0]==','))
                    {
                        chuoi+=array[0];
                        array=array.Remove(0, 1);
                    }
                    if (chuoi.Length>0)
                    {
                        nodeStack.Push(new Node(Convert.ToString(chuoi)));
                        chuoi="";
                    }
                }
                else if (array[0]=='(')
                {
                    if (array[1]=='-')
                    {
                        array=array.Remove(0, 1);
                        chuoi+=array[0];
                        array=array.Remove(0, 1);
                        while (char.IsNumber(array[0]) || array[0]==',')
                        {
                            chuoi+=array[0];
                            array=array.Remove(0, 1);
                        }
                        nodeStack.Push(new Node(Convert.ToString(chuoi)));
                        chuoi="";
                        array=array.Remove(0, 1);
                    }
                    else
                    {
                        Stack.Push(new Node(Convert.ToString(array[0])));
                        array=array.Remove(0, 1);
                    }
                }
                else if (array[0]==')')
                {
                    while (Stack.Count>0 && Stack.Peek().Value!="(")
                        Create(Stack, nodeStack);
                    Stack.Pop();
                    array=array.Remove(0, 1);
                }
                else
                {
                    while (Stack.Count>0 && Thutu(Convert.ToString(array[0]))<=Thutu(Stack.Peek().Value))
                        Create(Stack, nodeStack);
                    Stack.Push(new Node(Convert.ToString(array[0])));
                    array=array.Remove(0, 1);
                }
            }
            while (Stack.Count > 0)
                Create(Stack, nodeStack);
            return nodeStack.Peek();
        }
        public static string[] listarray = new string[100];
        public static int count = 0;
        public void Traverin(Node parent)
        {
            if (parent!=null)
            {
                Traverin(parent.Left);
                Traverin(parent.Right);
                Console.Write(parent.Value+" ");
                listarray[count]=parent.Value;
                count++;
            }
        }
        static int Thutu(string x)
        {
            if (x=="+" || x=="-")
            {
                return 1;
            }
            else if (x=="*" || x=="/")
            {
                return 2;
            }
            else if (x=="^" || x=="sqrt" || x=="log")
            {
                return 3;
            }
            return -1;
        }
        public static double Tong(string[] x)
        {
            double tong = 0;
            Stack<double> stack = new Stack<double>();
            double a, b;
            foreach (string i in x)
            {
                if (i!=null)
                {
                    if (i=="sqrt")
                    {
                        double c = stack.Pop();
                        stack.Push(Math.Sqrt(c));
                    }
                    else if (i=="log")
                    {
                        a=stack.Pop();
                        b=stack.Pop();
                        stack.Push(Math.Log(a, b));
                    }
                    else if (i=="+" || i=="-" || i=="*" || i=="/" || i=="^")
                    {
                        a=stack.Pop();
                        b=stack.Pop();
                        if (i=="+")
                            stack.Push((a+b));
                        else if (i=="-")
                            stack.Push((b-a));
                        else if (i=="*")
                            stack.Push((a*b));
                        else if (i=="/")
                            stack.Push((b/a));
                        else if (i=="^")
                            stack.Push(Math.Pow(b, a));
                    }
                    else
                    {
                        stack.Push(Convert.ToDouble(i));
                    }
                }
            }
            while (stack.Count > 0)
                tong+=stack.Pop();
            return tong;
        }
    }
}
