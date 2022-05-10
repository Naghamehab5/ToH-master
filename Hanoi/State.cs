using System.Collections.Generic;
using System.Linq;

namespace Hanoi
{
    public enum Peg
    {
        first, second, third
    }
    public class State
    {
        //represent discs by integers small = 0, large = 1, larger = 2, ...
        //private const int smDisck = 0, mdDisck = 1, lgDisck = 2;

        public Stack<int>[] Pegs { get; set; }

        public void PushPeg(Peg peg, int value)
        {
            Pegs[(int) peg].Push(value);
        }

        public int PeekPeg(Peg peg)
        {
            return Pegs[(int) peg].Peek();
        }

        public int PopPeg(Peg peg)
        {
            return Pegs[(int) peg].Pop();
        }

        public State()
        {
            //بينشئ 3 استاك فاضيين مترقمين من الشمال لليمين
            this.Pegs = new Stack<int>[3]
            {
                new Stack<int>(),
                new Stack<int>(),
                new Stack<int>()
            }
            ;
        }

        
        public State(int[] discsInPeg1, int[] discsInPeg2, int[] discsInPeg3) : this()
        {
            // make it easier to use for loop 
            int[][] allDiscs = 
            {
                sort(discsInPeg1),
                sort(discsInPeg2),
                sort(discsInPeg3)
            };

            //initialize pegs
            for (int i = 0; i < Pegs.Length; i++)
            {
                foreach (int disc in allDiscs[i])
                {
                    Pegs[i].Push(disc);
                }
            }
        }

        //
        //copy costructor
       public State(State copy) : this()
        {
            for (int i = 0; i < Pegs.Length; i++)
            {
                var currentPeg = copy.Pegs[i].Reverse();
                foreach (var disc in currentPeg)
                {
                    this.Pegs[i].Push(disc);
                }
            }
        }
        
        //
        //copy costructor
        //to create the state of the new successor function
        //
        public State(State toClone, int diskToMove, Peg destinationPeg, bool isEmptyDestination): this()
        {
            //to clone نسخة من حالة ال أب سواء كانت الوجهة او القرص الي هيتحرم 
          
            for (int i = 0; i < Pegs.Length; i++)
            {
                
                //بيعمل استبدال للقرص الصغير بيحطه من فوق والكبير بيحطه من تحت
                var peg_i = toClone.Pegs[i].Reverse();
                //
                
                int destinationPeg_pos = (int) destinationPeg;

                if (i == destinationPeg_pos&&isEmptyDestination)
                {
                     
                    //لو كان العامود الوجهة فاضي هنحط فيه القرص الي مطلوب انو يتحرك 

                    this.Pegs[i].Push(diskToMove);
                }
                //
                // peg-i هي العامو بتاعنا وهو مترتب الي المفروض نوصله
                foreach (var disc in peg_i)
                {
                    //
                    if (disc != diskToMove)
                    {
                        this.Pegs[i].Push(disc);
                    }
                    //
               
                    if (i == destinationPeg_pos
                        &&
                        (
                    
                        //لو القرص الي عليه الدور هو أول حاجه في العامود 
                        //لو مافيش قيم فوق الدقرص الحالي او الحالة الحالية
                        //لو كان اللوب بيشاور على الوجهة الي اليوزر دخلها هتحط القرص ع التوب)
                        disc == toClone.PeekPeg(destinationPeg)
                        )
                        )
                    {
                        //ضيف قرص  جديد
                        this.Pegs[i].Push(diskToMove);
                    }
                }
            }
        }

        private static int[] sort(int[] intArr)
        {
            int[] sortedDiscs = intArr.OrderByDescending(l => l).ToArray();
            return sortedDiscs;
        }
    }
}
