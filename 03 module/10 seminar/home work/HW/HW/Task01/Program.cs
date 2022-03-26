using System;
using System.Collections.Generic;
using System.Text;

namespace Task01
{
    internal class BTnode<valType> where valType : struct, IComparable
    {
        public valType Value { get; set; }
        private BTnode<valType> l;
        private BTnode<valType> r;

        public BTnode(valType now)
        {
            Value = now;
            l = null;
            r = null;
        }

        public void InsertValue(valType now)
        {
            if (Value.CompareTo(now) < 0)
            {
                if (r == null)
                {
                    r = new BTnode<valType>(now);
                }
                else
                {
                    r.InsertValue(now);
                }
            }
            if (Value.CompareTo(now) > 0)
            {
                if (l == null)
                {
                    l = new BTnode<valType>(now);
                }
                else
                {
                    l.InsertValue(now);
                }
            }
        }

        public void Print()
        {
            List<BTnode<valType> > vals = new List<BTnode<valType>>();
            vals.Add(this);
            int j = 0;
            while (vals.Count - j > 0)
            {
                BTnode<valType> now = vals[j];
                j += 1;
                Console.Write(now.Value + " ");
                if (now.l != null)
                {
                    vals.Add(now.l);
                    Console.Write(now.l + " ");
                }
                else
                {
                    Console.Write("нет левого ");
                }
                if (now.r != null)
                {
                    vals.Add(now.r);
                    Console.Write(now.r + " ");
                }
                else
                {
                    Console.Write("нет правого ");
                }
                Console.WriteLine();
            }
        }

        public void Delete(valType del)
        {
            if (Value.CompareTo(del) < 0)
            {
                if (r == null)
                {
                    throw new ArgumentException("надо было писать декартач...");
                }
                else if (r.r == null && r.l == null)
                {
                    r = null;
                }
                else
                {
                    r.Delete(del);
                }
            }
            if (Value.CompareTo(del) > 0)
            {
                if (l == null)
                {
                    throw new ArgumentException("надо было писать декартач...");
                }
                else if (l.l == null && l.r == null)
                {
                    l = null;
                }
                else
                {
                    l.Delete(del);
                }
            }
            if (Value.CompareTo(del) == 0)
            {
                if (l == null)
                {
                    r = r.r;
                }
                else
                {
                    l = l.l;
                }
            }
        }

        public bool Find(valType now)
        {
            if (now.CompareTo(Value) == 0)
            {
                return true;
            }
            else if (Value.CompareTo(now) > 0)
            {
                if (r == null)
                {
                    return false;
                }
                return r.Find(now);
            }
            else if (Value.CompareTo(now) < 0)
            {
                if (l == null)
                {
                    return false;
                }
                return l.Find(now);
            }
            return false;
        }

        public void Postorder(BTnode<valType> now)
        {
            Console.Write(now);
            if (now.l != null)
            {
                Postorder(now.l);
            }
            if (now.r != null)
            {
                Postorder(now.r);
            }
        }

        public void Inorder(BTnode<valType> now)
        {
            Console.Write(now);
            if (now.r != null)
            {
                Postorder(now.r);
            }
            if (now.l != null)
            {
                Postorder(now.l);
            }
        }
    }

    internal class BinaryTree<valType> where valType : struct, IComparable
    {
        private BTnode<valType> root = null;

        public void Insert(valType now)
        {
            if (root == null)
            {
                root = new BTnode<valType>(now);
                return;
            }
            root.InsertValue(now);
        }

        public void Print()
        {
            root.Print();
        }


        public void Delete(valType del)
        {
            if (root == null)
            {
                throw new ArgumentException("надо было писать декартач...");
            }
            root.Delete(del);
        }

        private bool Find(valType now)
        {
            if (root == null)
            {
                return false;
            }
            return root.Find(now);
        }

        public void Preorder(BTnode<valType> now)
        {
            if (Find(now.Value))
            {
                now.Print();
            }
        }

        public void Clear()
        {
            root = null;
        }

        public void Inorder()
        {
            root.Inorder(root);
        }

        public void Postorder()
        {
            root.Postorder(root);
        }

    }

    class Program
    {
        private static void Main()
        {
            BinaryTree<char> tree = new BinaryTree<char>();
            for (int i = 0; i < 25; ++i)
            {
                tree.Insert((char)('a' + i));
            }
            tree.Print();
            Console.WriteLine();
            tree.Inorder();
            Console.WriteLine();
            tree.Postorder();
            Console.WriteLine();
            tree.Delete('b');
            tree.Postorder();
            Console.WriteLine();
            tree.Clear();
        }
    }
}