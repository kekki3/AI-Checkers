using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using RoboProg;

namespace AICheckers
{
    internal class RobotClass
    {
        String robotname = "FanucCR7IAL";
        static Pose nulla0 = Pose.Base(-65, 530, -300, Math.PI, 0, 0);
        /*static Pose egy0 = Pose.Base(-65, 563, -300, Math.PI, 0, 0);
        static Pose ketto0 = Pose.Base(-65, 595, -300, Math.PI, 0, 0);
        static Pose harom0 = Pose.Base(-65.0001, 628, -300, Math.PI, 0, 0);
        static Pose negy0 = Pose.Base(-65, 660, -300, Math.PI, 0, 0);
        static Pose ot0 = Pose.Base(-65, 692, -300, Math.PI, 0, 0);
        static Pose hat0 = Pose.Base(-65, 724, -300, Math.PI, 0, 0);
        static Pose het0 = Pose.Base(-65, 757, -300, Math.PI, 0, 0);
        static Pose nulla1 = Pose.Base(-32, 530, -300, Math.PI, 0, 0);
        static Pose egy1 = Pose.Base(-32, 563, -300, Math.PI, 0, 0);
        static Pose ketto1 = Pose.Base(-32, 595, -300, Math.PI, 0, 0);
        static Pose harom1 = Pose.Base(-32, 628, -300, Math.PI, 0, 0);
        static Pose negy1 = Pose.Base(-32, 660, -300, Math.PI, 0, 0);
        static Pose ot1 = Pose.Base(-32, 692, -300, Math.PI, 0, 0);
        static Pose hat1 = Pose.Base(-32, 724, -300, Math.PI, 0, 0);
        static Pose het1 = Pose.Base(-32.0001, 757, -300, Math.PI, 0, 0); // This is different because of a bug in the proxy
        static Pose nulla2 = Pose.Base(1, 530, -300, Math.PI, 0, 0);
        static Pose egy2 = Pose.Base(1, 563, -300, Math.PI, 0, 0);
        static Pose ketto2 = Pose.Base(1, 595, -300, Math.PI, 0, 0);
        static Pose harom2 = Pose.Base(1, 628, -300, Math.PI, 0, 0);
        static Pose negy2 = Pose.Base(1, 660, -300, Math.PI, 0, 0);
        static Pose ot2 = Pose.Base(1, 692, -300, Math.PI, 0, 0);
        static Pose hat2 = Pose.Base(1, 724, -300, Math.PI, 0, 0);
        static Pose het2 = Pose.Base(1, 757, -300, Math.PI, 0, 0);
        static Pose nulla3 = Pose.Base(33, 530, -300, Math.PI, 0, 0);
        static Pose egy3 = Pose.Base(33, 563, -300, Math.PI, 0, 0);
        static Pose ketto3 = Pose.Base(33, 595, -300, Math.PI, 0, 0);
        static Pose harom3 = Pose.Base(33, 628, -300, Math.PI, 0, 0);
        static Pose negy3 = Pose.Base(33, 660, -300, Math.PI, 0, 0);
        static Pose ot3 = Pose.Base(33, 692, -300, Math.PI, 0, 0);
        static Pose hat3 = Pose.Base(33, 724, -300, Math.PI, 0, 0);
        static Pose het3 = Pose.Base(33, 757, -300, Math.PI, 0, 0);
        static Pose nulla4 = Pose.Base(65, 530, -300, Math.PI, 0, 0);
        static Pose egy4 = Pose.Base(65, 563, -300, Math.PI, 0, 0);
        static Pose ketto4 = Pose.Base(65, 595, -300, Math.PI, 0, 0);
        static Pose harom4 = Pose.Base(65, 628, -300, Math.PI, 0, 0);
        static Pose negy4 = Pose.Base(65, 660, -300, Math.PI, 0, 0);
        static Pose ot4 = Pose.Base(65, 692, -300, Math.PI, 0, 0);
        static Pose hat4 = Pose.Base(65, 724, -300, Math.PI, 0, 0);
        static Pose het4 = Pose.Base(65, 757, -300, Math.PI, 0, 0);
        static Pose nulla5 = Pose.Base(97, 530, -300, Math.PI, 0, 0);
        static Pose egy5 = Pose.Base(97, 563, -300, Math.PI, 0, 0);
        static Pose ketto5 = Pose.Base(97, 595, -300, Math.PI, 0, 0);
        static Pose harom5 = Pose.Base(97, 628, -300, Math.PI, 0, 0);
        static Pose negy5 = Pose.Base(97, 660, -300, Math.PI, 0, 0);
        static Pose ot5 = Pose.Base(97, 692, -300, Math.PI, 0, 0);
        static Pose hat5 = Pose.Base(97, 724, -300, Math.PI, 0, 0);
        static Pose het5 = Pose.Base(97, 757, -300, Math.PI, 0, 0);
        static Pose nulla6 = Pose.Base(130, 530, -300, Math.PI, 0, 0);
        static Pose egy6 = Pose.Base(130, 563, -300, Math.PI, 0, 0);
        static Pose ketto6 = Pose.Base(130, 595, -300, Math.PI, 0, 0);
        static Pose harom6 = Pose.Base(130, 628, -300, Math.PI, 0, 0);
        static Pose negy6 = Pose.Base(130, 660, -300, Math.PI, 0, 0);
        static Pose ot6 = Pose.Base(130, 692, -300, Math.PI, 0, 0);
        static Pose hat6 = Pose.Base(130, 724, -300, Math.PI, 0, 0);
        static Pose het6 = Pose.Base(130, 757, -300, Math.PI, 0, 0);
        static Pose nulla7 = Pose.Base(163, 530, -300, Math.PI, 0, 0);
        static Pose egy7 = Pose.Base(163, 563, -300, Math.PI, 0, 0);
        static Pose ketto7 = Pose.Base(163, 595, -300, Math.PI, 0, 0);
        static Pose harom7 = Pose.Base(163, 628, -300, Math.PI, 0, 0);
        static Pose negy7 = Pose.Base(163, 660, -300, Math.PI, 0, 0);
        static Pose ot7 = Pose.Base(163, 692, -300, Math.PI, 0, 0);
        static Pose hat7 = Pose.Base(163, 724, -300, Math.PI, 0, 0);
        static Pose het7 = Pose.Base(163, 757, -300, Math.PI, 0, 0);*/
        //static Pose BKing7 = Pose.Base(163, 802, -300, Math.PI, 0, 0);
        //static Pose BKing6 = Pose.Base(130, 802, -300, Math.PI, 0, 0);
        //static Pose BKing5 = Pose.Base(98, 802, -300, Math.PI, 0, 0);
        //static Pose BKing4 = Pose.Base(65, 802, -300, Math.PI, 0, 0);
        //static Pose BKing3 = Pose.Base(32, 802, -300, Math.PI, 0, 0);
        //static Pose BKing2 = Pose.Base(1, 802, -300, Math.PI, 0, 0);
        //static Pose BKing1 = Pose.Base(-33, 802, -300, Math.PI, 0, 0);
        static Pose WKing0 = nulla0.local(-44.5, 0, 0, 0, 0, 0, 0);
        //static Pose WKing7 = Pose.Base(-110, 757, -300, Math.PI, 0, 0);
        //static Pose WKing6 = Pose.Base(-110, 724, -300, Math.PI, 0, 0);
        //static Pose WKing5 = Pose.Base(-110, 692, -300, Math.PI, 0, 0);
        //static Pose WKing4 = Pose.Base(-110, 660, -300, Math.PI, 0, 0);
        //static Pose WKing3 = Pose.Base(-110, 628, -300, Math.PI, 0, 0);
        //static Pose WKing2 = Pose.Base(-110, 595, -300, Math.PI, 0, 0);
        //static Pose WKing1 = Pose.Base(-110, 563, -300, Math.PI, 0, 0);
        static Pose BKing0 = nulla0.local(0, -32.5 * 7 - 44.5, 0, 0, 0, 0);
        static Pose doboz = Pose.Base(1, 400, -50, Math.PI, 0, 0);

        /*List<Pose> positions = new List<Pose> {nulla0, egy0, ketto0, harom0, negy0, ot0, hat0, het0,
                                               nulla1, egy1, ketto1, harom1, negy1, ot1, hat1, het1,
                                               nulla2, egy2, ketto2, harom2, negy2, ot2, hat2, het2,
                                               nulla3, egy3, ketto3, harom3, negy3, ot3, hat3, het3,
                                               nulla4, egy4, ketto4, harom4, negy4, ot4, hat4, het4,
                                               nulla5, egy5, ketto5, harom5, negy5, ot5, hat5, het5,
                                               nulla6, egy6, ketto6, harom6, negy6, ot6, hat6, het6,
                                               nulla7, egy7, ketto7, harom7, negy7, ot7, hat7, het7};*/

        //List<Pose> BlackKing = new List<Pose> { BKing0, BKing1, BKing2, BKing3, BKing4, BKing5, BKing6, BKing7 };
        //List<Pose> WhiteKing = new List<Pose> { WKing0, WKing1, WKing2, WKing3, WKing4, WKing5, WKing6, WKing7 };
        

        private int BlackCount = 0;
        private int WhiteCount = 0;
        private bool WKing = false;
        private bool BKing = false;
        private bool kinging = false;

        BoardPanel boardPanel;

        public void RobotMoveChecker(BoardPanel board, Move move)
        {
            boardPanel = board;
            
            using (Robot r = Robot.Create(Config.FromFile(robotname)))
            {
                r.Start();
                Pose source = FindSource(move);
                Pose dest = FindDest(move);
                if(board.isKing(move.Destination.Y, move.Destination.X) == true && kinging == false)
                {
                    r.Move(source);
                    r.Move(source.local(0, 0, 50, 0, 0, 0));
                    r.SetGripperNorm(0.6);
                    r.Move(source);
                    r.Move(dest);
                    r.Move(dest.local(0, 0, 50, 0, 0, 0));
                    r.SetGripperNorm(1);
                    r.Move(dest);
                    kinging = false;
                }
                else {
                    r.Move(source);
                    r.Move(source.local(0, 0, 58, 0, 0, 0));
                    r.SetGripperNorm(0.6);
                    r.Move(source);
                    r.Move(dest);
                    r.Move(dest.local(0, 0, 58, 0, 0, 0));
                    r.SetGripperNorm(1);
                    r.Move(dest);
                    
                }
                

                if(move.Captures.Count > 0)
                {
                    for (int i = 0; i < move.Captures.Count; i++)
                    {
                        Pose target = FindTarget(move.Captures[i]);
                        if (boardPanel.isKing(move.Captures[i].Y, move.Captures[i].X) == true)
                        {
                            r.Move(target);
                            r.Move(target.local(0, 0, 50, 0, 0, 0));
                            r.SetGripperNorm(0.6);
                            r.Move(target);
                            r.Move(doboz);
                            r.SetGripperNorm(1);
                        }
                        else
                        {
                            r.Move(target);
                            r.Move(target.local(0, 0, 59, 0, 0, 0));
                            r.SetGripperNorm(0.6);
                            r.Move(target);
                            r.Move(doboz);
                            r.SetGripperNorm(1);
                        }
                        
                    }
                }

               
                    if(WKing)
                    {
                        r.Move(dest);
                        r.Move(dest.local(0, 0, 58, 0, 0, 0));
                        r.SetGripperNorm(0.7);
                        r.Move(dest);
                        r.Move(doboz);
                        r.SetGripperNorm(1);
                        r.Move(WKing0.local(0, -32.5 * WhiteCount, 0, 0, 0, 0));
                        r.Move(WKing0.local(0, -32.5 * WhiteCount, 70, 0, 0, 0));
                        r.SetGripperNorm(0.7);
                        r.Move(WKing0.local(0, -32.5 * WhiteCount, 0, 0, 0, 0));
                        r.Move(dest);
                        r.Move(dest.local(0, 0, 50, 0, 0, 0));
                        r.SetGripperNorm(1);
                        r.Move(dest);
                        WhiteCount++;
                        WKing = false;
                        kinging = false;
                    }
                    if (BKing)
                    {
                        r.Move(dest);
                        r.Move(dest.local(0, 0, 58, 0, 0, 0));
                        r.SetGripperNorm(0.7);
                        r.Move(dest);
                        r.Move(doboz);
                        r.SetGripperNorm(1);
                        r.Move(BKing0.local(32.5 * BlackCount, 0, 0, 0, 0, 0));
                        r.Move(BKing0.local(32.5 * BlackCount, 0, 70, 0, 0, 0));
                        r.SetGripperNorm(0.7);
                        r.Move(BKing0.local(32.5 * BlackCount, 0, 0, 0, 0, 0));
                        r.Move(dest);
                        r.Move(dest.local(0, 0, 50, 0, 0, 0));
                        r.SetGripperNorm(1);
                        r.Move(dest);
                        BlackCount++;
                        BKing = false;
                        kinging = false;
                }
                

                r.Move(doboz);
                r.SetGripperNorm(1);
                r.Finish();
            }


        }

        public void Kinging(BoardPanel board, Move move)
        {
            Pose dest = FindDest(move);

        }

       private Pose FindSource(Move move)
        {
            Pose source = nulla0.local(32.5 * move.Source.Y + 12, -32.5*move.Source.X - 9, 0, 0, 0, 0.1);
            return source;

        }

        private Pose FindDest(Move move)
        {
            Pose dest = nulla0.local(32.5 * move.Destination.Y+12, -32.5 * move.Destination.X - 9, 0, 0, 0, 0.1);
            return dest;
        }

        private Pose FindTarget(Point p)
        {
            Pose target = nulla0.local(32.5 * p.Y+12, -32.5 * p.X-9, 0, 0, 0,0.1);
            return target;
        }

        public void isWKinging()
        {
            WKing = true;
        }

        public void isBKinging()
        {
            BKing = true;
        }
        public void FirstKinging()
        {
            kinging = true;
        }
    }
}
