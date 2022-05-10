


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hanoi
{
    enum Direction
    {
        left, right, far_left, far_right
    }

    public class Action
    {
        public Peg Source { get; set; }
        public Peg Destination{ get; set; }
        public string Direction { get; set; }
        
        //copy constractor
        public Action(Action copy)
        {
            Source = copy.Source;
            Destination = copy.Destination;
            Direction = copy.Direction;
        }

        public Action(Peg source, Peg destination, string direction)
        {
            Source = source;
            Destination = destination;
            Direction = direction;
        }
        public static Stack<Action> getSolutionPath(Node goal)
        {
            var solution = new Stack<Action>();
            
            // بتحتوي على كل  النود المتواجده في مسار الحلول
            var tmp = goal;
            
            //بيشيك على المسار من القرص الي في القاعده لفوق
 
            while (tmp.Parent != null)
            {
                solution.Push(tmp.Action);
                
                //بيشاور للنود الي قبلها 
                tmp = tmp.Parent;
            }
            return solution;
        }

    }
}
