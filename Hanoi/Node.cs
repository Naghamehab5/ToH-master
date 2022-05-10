using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hanoi
{
    public class Node
    {
        public Node()
        {

        }

        //copy constructor
        public Node(Node node)
        {
            Depth = node.Depth;
            Parent = node.Parent;
            Action = new Action(node.Action);
            State = new State(node.State);
        }

        public int Depth { get; set; }
        public Node Parent { get; set; }
        public Hanoi.State State { get; set; }
        public Action Action { get; set; }
        //
        //
        //   //هينشئ أطفال عن طريق 
        //هيشوف لو العامودين متجاورين هيتحقق من حركة القرص للشمال(الطفل الأول) بعدين هيتحقق من حركته لليمين (الطفل التاني)ب       

        public List<Node> Expand()
        {
         
            List<Node> successors = new List<Node>();

         

           // بينشئ الاعمده
            var pegs = this.State.Pegs;

            //ال(i)هي العامود
            //كل مرة هيشاور على عامود ويعتبره المصدر
            for (int i = 0; i < pegs.Length; i++)
            {
                //لو العامود الي بيشاور عليه فاضي هيسيبه 

                if (pegs[i].Count == 0)
                {
                    continue;
                }
                 //لو مش فاضي هياخد القرص الي في المقدمة ويخزنه في متغير 

                var discToMoveFromSource = pegs[i].Peek();
                //تؤشر الى الوجهة الي هيتحرك ليها القرص j
                // هنبدأ ندور على الوجهة الي هننقل فيها القرص ونخزنهم ك(شيلدرن)م

                for (int j = 0; j < pegs.Length; j++)
                {
                    //
                    //لو كان العامود فاضي هيدي القيمة ب صح ودي معلومه هنستخدمها بعدين

                    bool emptyPeg = pegs[j].Count == 0;
                    //بيتأكد لو كان العامود الوجهة فاضي ف بيديله رقم كبير جدا بحيث انو هيسمح لأي قرص انو يتحط في العامود عشان هيبقى  

                    var discOnTheTopOfDestination = (emptyPeg) ? int.MaxValue : pegs[j].Peek();
                    //
                    // بيشوف لو كان لوب المصدر و الوجهة بيشاور على نفس العامود 
                    var samePeg = i == j;//0
                                       
                     //متغير بيشوف هل القرص الي هيتحرك اصغر من القرص الي في الوجهة 
                    var sourceSmaller = (discToMoveFromSource < discOnTheTopOfDestination);//1
                    //لو كان الهدف لا يساوي السورس هتساوي صفر ووو ولو كان القرص اصغر من القرص الي في الوجهه
                    if (!samePeg && sourceSmaller)//1&&1>>1
                    {
                        //
                        //بتنشئ الحركة (الوجهة الي هيتحرك ليها القرص )و بتنشئ successor

                        string direction = leftOrRight(i, j);
                        //
                        Peg source = (Peg) i;
                        Peg destination = (Peg) j;
                        Action action = new Action(source, destination, direction);
                        //
                        // بتنشئ successor
                        successors.Add(
                                    CreateSuccessor(discToMoveFromSource, (Peg) j, emptyPeg, action));
                    }
                }
            }
            return successors;
        }

        //
      
        private static string leftOrRight(int i, int j)
        {
            string direction;
            //
            //لو كان العملية تساوي موجب هتبقى الوجهة نحية الشمال بالتالي هنحرك الديسك نحية الشمال
            if (i - j > 0)
            {
                direction = "left";
            }
            //
            
            else
            {
                direction = "right";
            }

            return direction;
        }

        private Node CreateSuccessor(int discToMoveFromSource, Peg destinationPeg, bool isEmptyPeg, Action action)
        {// بندي خصائص لل ابن الجديد عشان اللوب 
            // كل مرة هيعمل اين جديد للحالة الحالية عشان 
            Node child = new Node
            {
                //depth of parent plus one
                Depth = this.Depth + 1,
                //parent is the current node
                //أل parent  ه الحالة الحالية
                Parent = this,
                //extract the child state from the parent state and the new action 
                //لوب على ال ابناء لل حالة الحالية (parent)
                State = new State(this.State, discToMoveFromSource, destinationPeg, isEmptyPeg),
                Action = action
            };
            return child;
        }
    }
}
