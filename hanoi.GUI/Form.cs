using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Hanoi;

namespace hanoi.GUI
{
    public partial class HanoiUI : Form
    {
        public HanoiUI()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            //
            btnPlay.Visible = false;
            //
            Node initState = initialState();
            //
            //goal state
            //دا الهدف النهائي لما ال3 أقراص يكونو في العامود رقم 3 بالترتيب
            //0-1-2 دا رقم ك قرص
            //دا الي لما يوصله الالجوريزم البرنامج هيقف
            Hanoi.State goalTest = new Hanoi.State(new int[] { }, new int[] { }, new int[] { 2, 1, 0 });
            //
            //هنا بنستدعي الالجوريزم بتاعنا وبنديله الحالة الابتدائية والهدف المطلوب 
            Node goal = Hanoi.Program.BFS(initState, goalTest);
            //
            var solutionPath = Hanoi.Action.getSolutionPath(goal);
            //
            //visualize
            //
            FlowLayoutPanel[] pegs = { peg0, peg1, peg2 };
            //
            play(solutionPath, pegs);
        }

        //
        //input:
        //pegs: for easy access using pointers
        private void play(Stack<Hanoi.Action> solutionPath, FlowLayoutPanel[] pegs)
        {
            //
            foreach (var action in solutionPath)
            {
                var sourcePeg = (int) action.Source;
                var destinationPeg = (int) action.Destination;
                //
                //get index of the disc on the top of source peg
                var top = pegs[sourcePeg].Controls.Count - 1;
                //point to the top of the source
                var disc = pegs[sourcePeg].Controls[top];
                //wait for visualization
                System.Threading.Thread.Sleep(333);
                //move to the top of the destination
                pegs[destinationPeg].Controls.Add(disc);
            }
        }

        private static Node initialState()
        {
            //init state
            Hanoi.Node init = new Hanoi.Node();
            init.Depth = 0;
            init.Parent = null;
            init.Action = null;
            init.State = new Hanoi.State(new int[] { 2, 1, 0 }, new int[] { }, new int[] { });
            return init;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btnPlay2_Click(object sender, EventArgs e)
        {
        }

     
        private void lblDLS_Click(object sender, EventArgs e)
        {

        }

        private void peg02_Paint(object sender, PaintEventArgs e)
        {

        }

        private void peg12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void disc0_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HanoiUI_Load(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
