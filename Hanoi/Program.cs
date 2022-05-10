using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hanoi
{
    public class Program
    {

        static void Main(string[] args)
        {

            //init state
            Hanoi.Node init = new Hanoi.Node();
            init.Depth = 0;
            init.Parent = null;
            init.Action = null;
            init.State = new Hanoi.State(new int[] { 2, 1, 0 }, new int[] { }, new int[] { });
            //
            //goal state
            Hanoi.State test = new Hanoi.State(new int[] { }, new int[] { }, new int[] { 2, 1, 0 });
            //

        }


        //>>>>>>>>>>>>>>>>>>>Breadth First search Algorithem<<<<<<<<<<<<<<<<<<<
        public static Node BFS(Node node, State Goal)
        {
            var successors = new List<Node>();

            var q = new Queue<Node>();
            q.Enqueue(node);
            // طول ما الكيو مش فاضي هيحط ال الي ع الوش في ال أب  
            //
            while (q.Count != 0)
            {
                Node Parent = q.Dequeue();
                //بيشيك لو كان ال أب هو الجول ولا لا
                //Check
                if (Parent.State.Pegs[2].Count == Goal.Pegs[2].Count)
                {
                    return Parent;
                    //break;
                }
                // بعدين بناخد الاطفال بنعتبرها اب وبنكمل اللوب
                successors = Parent.Expand();
                // هنضيف الاطفال في الكيو الي معرفينه
                for (int i = 0; i < successors.Count; i++)
                {
                    Node Temp = new Node(successors[i]);
                    q.Enqueue(Temp);
                }//end for
                 //
            }

            return null;
        }
        //
    }
}