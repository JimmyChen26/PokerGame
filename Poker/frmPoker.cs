using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poker
{
    public partial class frmPoker : Form
    {
        #region 欄位
        /// <summary>
        /// 用來存放牌桌上五張牌的 PictureBox 陣列
        /// </summary>
        PictureBox[] pic = new PictureBox[5];

        /// <summary>
        /// 所有的牌的編號，從 0 到 51，對應到 52 張牌
        /// </summary>
        int[] allPoker = new int[52];

        /// <summary>
        /// 記錄玩家手牌的編號，從 0 到 51，對應到 52 張牌
        /// </summary>
        int[] playerPoker = new int[5];

        #endregion
        int totalMoney = 1000000;   // 玩家總資金
        int currentBet = 0;         // 目前這局押注金額
        bool hasBet = false;        // 是否已經下注

        
           

            

        public frmPoker()
        {

            InitializeComponent();
            InitializePoker();
            txtMoney.Text = totalMoney.ToString();
            txtMoney.ReadOnly = true;
            txtMoney.TabStop = false;

            txtBetMoney.Text = "500";
            txtRechargeMoney.Text = "1000000";

            btnDealCard.Enabled = false;
            btnChangeCard.Enabled = false;
            btnCheck.Enabled = false;

            btnBet.Enabled = true;
            btnAllIn.Enabled = true;
            btnRecharge.Enabled = true;
            ApplyUIStyle();
        }
        private void ApplyUIStyle()
        {
            // Form 整體
            this.Text = "Lucky Five Poker";
            this.BackColor = Color.FromArgb(18, 70, 42);
            this.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Regular);

            // 標題與標語，如果你有新增 lblTitle / lblSlogan / lblHint
            lblTitle.Text = "Lucky Five Poker";
            lblTitle.Font = new Font("Microsoft JhengHei UI", 22F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Gold;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            lblSlogan.Text = "五張牌，一次翻身的機會";
            lblSlogan.Font = new Font("Microsoft JhengHei UI", 11F, FontStyle.Bold);
            lblSlogan.ForeColor = Color.White;
            lblSlogan.BackColor = Color.Transparent;
            lblSlogan.TextAlign = ContentAlignment.MiddleCenter;

            lblHint.Text = "遊戲提示：請先下注，接著按「發牌」開始遊戲。發牌後，請點選你想要換掉的牌，被選到的牌會變成背面，確認後再按「換牌」。";
            lblHint.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Bold);
            lblHint.ForeColor = Color.Gold;
            lblHint.BackColor = Color.Transparent;
            lblHint.TextAlign = ContentAlignment.MiddleCenter;

            // 讓提示文字可以顯示比較多
            lblHint.AutoSize = false;
            lblHint.Width = 650;
            lblHint.Height = 70;

            // GroupBox
            grpPoker.Text = "♠ 牌桌";
            grpButton.Text = "🎮 功能";

            StyleGroupBox(grpPoker);
            StyleGroupBox(grpButton);

            // 如果你的下注區叫 grpBet，也一起美化
            grpBet.Text = "💰 下注區";
            StyleGroupBox(grpBet);

            // TextBox
            StyleTextBox(txtMoney);
            StyleTextBox(txtBetMoney);
            StyleTextBox(txtRechargeMoney);

            txtMoney.ReadOnly = true;
            txtMoney.BackColor = Color.FromArgb(235, 235, 235);
            txtMoney.ForeColor = Color.DarkGreen;

            // Button
            StyleButton(btnBet, Color.FromArgb(255, 193, 7), Color.Black);
            StyleButton(btnAllIn, Color.FromArgb(220, 53, 69), Color.White);
            StyleButton(btnRecharge, Color.FromArgb(40, 167, 69), Color.White);

            StyleButton(btnDealCard, Color.FromArgb(0, 123, 255), Color.White);
            StyleButton(btnChangeCard, Color.FromArgb(108, 117, 125), Color.White);
            StyleButton(btnCheck, Color.FromArgb(111, 66, 193), Color.White);


            lblOddsHint.Text =
    "賠率介紹：皇家同花順 250倍｜同花順 50倍｜四條 25倍｜葫蘆 9倍｜同花 6倍\r\n" +
    "順子 4倍｜三條 3倍｜兩對 2倍｜一對 1倍｜雜牌 0倍";

            lblOddsHint.Font = new Font("Microsoft JhengHei UI", 13F, FontStyle.Bold);
            lblOddsHint.ForeColor = Color.White;
            lblOddsHint.BackColor = Color.Transparent;
            lblOddsHint.TextAlign = ContentAlignment.MiddleCenter;

            lblOddsHint.AutoSize = false;
            lblOddsHint.Width = 760;
            lblOddsHint.Height = 70;

            // 結果 Label
            lblResult.Font = new Font("Microsoft JhengHei UI", 13F, FontStyle.Bold);
            lblResult.ForeColor = Color.Gold;
            lblResult.BackColor = Color.FromArgb(35, 35, 35);
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
        }
        private void StyleGroupBox(GroupBox groupBox)
        {
            groupBox.BackColor = Color.FromArgb(25, 90, 55);
            groupBox.ForeColor = Color.Gold;
            groupBox.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Bold);

            foreach (Control ctrl in groupBox.Controls)
            {
                if (ctrl is Label)
                {
                    ctrl.ForeColor = Color.White;
                    ctrl.BackColor = Color.Transparent;
                    ctrl.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Bold);
                }
                else if (ctrl is TextBox)
                {
                    StyleTextBox((TextBox)ctrl);
                }
            }
        }

        private void StyleTextBox(TextBox textBox)
        {
            textBox.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Bold);
            textBox.BackColor = Color.White;
            textBox.ForeColor = Color.Black;
            textBox.TextAlign = HorizontalAlignment.Right;
            textBox.BorderStyle = BorderStyle.FixedSingle;
        }

        private void StyleButton(Button button, Color backColor, Color foreColor)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.BackColor = backColor;
            button.ForeColor = foreColor;
            button.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Bold);
            button.Cursor = Cursors.Hand;
        }

        #region 自定義方法
        private void InitializePoker()
        {
            for (int i = 0; i < pic.Length; i++)
            {
                pic[i] = new PictureBox();
                pic[i].Image = GetImage("back");
                pic[i].Name = "pic" + i;
                pic[i].SizeMode = PictureBoxSizeMode.AutoSize;
                pic[i].Top = 30;
                pic[i].Left = 10 + ((pic[i].Width + 10) * i);
                // 預設牌桌上的牌不可點擊
                pic[i].Enabled = false;
                // 預設牌桌上的牌的 Tag 為 "back"，表示牌面朝下
                pic[i].Tag = "back";
                pic[i].Visible = true;

                // 將 pic 丟至到 grpPorker 內
                this.grpPoker.Controls.Add(pic[i]);

                pic[i].Click += Pic_Click;
            }
        }

        /// <summary>
        /// 顯示五張撲克牌到桌面上
        /// </summary>
        private void ShowCards()
        {
            for (int i = 0; i < playerPoker.Length; i++)
            {
                pic[i].Image = this.GetImage($"pic{playerPoker[i] + 1}");
            }
        }


        /// <summary>
        /// 取得圖片資源
        /// </summary>
        /// <param name="name">string 的牌名 </param>
        /// <returns></returns>
        private Image GetImage(string name)
        {
            return Properties.Resources.ResourceManager.GetObject(name) as Image;
        }

        /// <summary>
        /// 取得圖片資源
        /// </summary>
        /// <param name="num">撲克牌編號</param>
        /// <returns></returns>
        private Image GetImage(int num)
        {
            return GetImage($"pic{num}");
        }


        /// <summary>
        /// 將 allPoker 陣列中的牌隨機打亂，模擬洗牌的過程
        /// </summary>
        private void Shuffle()
        {
            Random rand = new Random();
            for (int i = 0; i < 1000; i++)
            {
                int r = rand.Next(allPoker.Length);
                int temp = allPoker[r];
                allPoker[r] = allPoker[0];
                allPoker[0] = temp;
            }
        }

        #endregion


        #region 事件處理程序

        /// <summary>
        /// 牌桌上的牌被按下時，顯示訊息框告訴使用者按下了哪一張牌
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Pic_Click(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;


            int index = int.Parse(pic.Name.Replace("pic", ""));

            int cardNum = playerPoker[index] + 1;

            // 如果牌面朝下，則翻開牌面；如果牌面朝上，則翻回背面
            if (pic.Tag.ToString() == "back")
            {
                pic.Tag = "front";
                pic.Image = GetImage(cardNum);
            }
            else
            {
                pic.Tag = "back";
                pic.Image = GetImage("back");
            }
        }

        /// <summary>
        /// 當按下發牌按鈕時，隨機產生五個1~52的數字，並將對應的圖片顯示在牌桌上
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private async void btnDealCard_Click(object sender, EventArgs e)
        {
            if (!hasBet)
            {
                MessageBox.Show("請先下注！");
                return;
            }
            // 將上一把玩的結果清除
            this.lblResult.Text = "";


            // 將牌桌上的牌重置為背面圖
            for (int i = 0; i < pic.Length; i++)
            {
                pic[i].Image = GetImage("back");
            }

            // 將所有牌的編號從 0 到 51 填入 allPoker 陣列
            for (int i = 0; i < allPoker.Length; i++)
            {
                allPoker[i] = i;
            }

            // 洗牌
            this.Shuffle();

            // 暫停500ms
            await Task.Delay(500);

            // 發前五張牌給玩家，並將對應的牌面圖顯示在牌桌上
            for (int i = 0; i < playerPoker.Length; i++)
            {
                // 取前52張牌的前五張牌
                playerPoker[i] = allPoker[i];
            }


            //// 測試用
            //playerPoker[0] = 51;
            //playerPoker[1] = 47;
            //playerPoker[2] = 43;
            //playerPoker[3] = 39;
            //playerPoker[4] = 3;


            // 將對應的牌面圖顯示在牌桌上
            this.ShowCards();

            // 啟用所有牌的點擊事件
            for (int i = 0; i < pic.Length; i++)
            {
                // 將牌桌上的牌設成可以點擊
                pic[i].Enabled = true;
                // 將牌桌上的牌的 Tag 設成 "front"，表示牌面朝上
                pic[i].Tag = "front";
            }

            // 啟用換牌按鈕
            btnChangeCard.Enabled = true;
            btnDealCard.Enabled = false;

        }

        /// <summary>
        /// 當按下換牌按鈕時，將玩家手牌中被選中的牌換成新的牌，並將對應的圖片顯示在牌桌上
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChangeCard_Click(object sender, EventArgs e)
        {
            if (!hasBet)
            {
                MessageBox.Show("請先下注！");
                return;
            }
            int startIndex = 5; // 從 allPoker 陣列的第 5 張牌開始換牌，因為前 5 張牌已經發給玩家了

            for(int i = 0; i < playerPoker.Length; i++)
            {
                // 如果牌面朝下，表示玩家選擇換掉這張牌
                if (pic[i].Tag.ToString() == "back")
                {
                    // 將玩家手牌中被選中的牌換成新的牌
                    playerPoker[i] = allPoker[startIndex];
                    // 將對應的牌面圖顯示在牌桌上
                    pic[i].Image = GetImage(playerPoker[i] + 1);
                    pic[i].Tag = "front";

                    startIndex++;
                }
            }

            for(int i = 0; i < pic.Length; i++)
            {
                // 將牌桌上的牌設成不可點擊
                pic[i].Enabled = false;
            }

            // 將換牌按鈕設成不可用，表示玩家已經完成換牌了
            this.btnChangeCard.Enabled = false;

            // 將判斷牌型的按鈕設成可用，表示玩家可以開始判斷牌型了
            this.btnCheck.Enabled = true;
        }

        /// <summary>
        /// 當按下判斷牌型按鈕時，根據玩家手牌的編號，判斷玩家的牌型，並顯示在 lblResult 上
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (!hasBet)
            {
                MessageBox.Show("請先下注！");
                return;
            }

            string[] colorList = { "梅花", "方塊", "愛心", "黑桃" };
            string[] pointList = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };

            int[] pokerColor = new int[5];
            int[] pokerPoint = new int[5];

            for (int i = 0; i < playerPoker.Length; i++)
            {
                pokerColor[i] = playerPoker[i] % 4;
                pokerPoint[i] = playerPoker[i] / 4;
            }

            int[] colorCount = new int[4];
            int[] pointCount = new int[13];

            for (int i = 0; i < pokerColor.Length; i++)
            {
                int color = pokerColor[i];
                int point = pokerPoint[i];

                colorCount[color]++;
                pointCount[point]++;
            }

            Array.Sort(colorCount, colorList);
            Array.Reverse(colorCount);
            Array.Reverse(colorList);

            Array.Sort(pointCount, pointList);
            Array.Reverse(pointCount);
            Array.Reverse(pointList);

            bool isFlush = (colorCount[0] == 5);
            bool isSingle = (pointCount[0] == 1 && pointCount[1] == 1 && pointCount[2] == 1 && pointCount[3] == 1 && pointCount[4] == 1);
            bool isDiffFout = (pokerPoint.Max() - pokerPoint.Min() == 4);
            bool isRoyal = pokerPoint.Contains(0) && pokerPoint.Contains(9) && pokerPoint.Contains(10) && pokerPoint.Contains(11) && pokerPoint.Contains(12);

            bool isRoyalisFlush = isFlush && isRoyal;
            bool isStraightFlush = isFlush && isSingle && isDiffFout;
            bool isStraight = isSingle && (isDiffFout || isRoyal);
            bool isFourOfAKind = (pointCount[0] == 4);
            bool isFullHouse = (pointCount[0] == 3 && pointCount[1] == 2);
            bool isThreeOfAKind = (pointCount[0] == 3 && pointCount[1] == 1);
            bool isTwoPair = (pointCount[0] == 2 && pointCount[1] == 2);
            bool isOnePair = (pointCount[0] == 2 && pointCount[1] == 1);

            string result = "";
            string handType = "";

            if (isRoyalisFlush)
            {
                result = $"{colorList[0]} 同花大順";
                handType = "皇家同花順";
            }
            else if (isStraightFlush)
            {
                result = $"{colorList[0]} 同花順";
                handType = "同花順";
            }
            else if (isFourOfAKind)
            {
                result = $"{pointList[0]} 鐵支";
                handType = "四條";
            }
            else if (isFullHouse)
            {
                result = $"{pointList[0]}三張{pointList[1]}兩張 葫蘆";
                handType = "葫蘆";
            }
            else if (isFlush)
            {
                result = $"{colorList[0]} 同花";
                handType = "同花";
            }
            else if (isStraight)
            {
                result = "順子";
                handType = "順子";
            }
            else if (isThreeOfAKind)
            {
                result = $"{pointList[0]} 三條";
                handType = "三條";
            }
            else if (isTwoPair)
            {
                result = $"{pointList[0]},{pointList[1]} 兩對";
                handType = "兩對";
            }
            else if (isOnePair)
            {
                result = $"{pointList[0]} 一對";
                handType = "一對";
            }
            else
            {
                result = "雜牌";
                handType = "雜牌";
            }

            lblResult.Text = result;

            SettleBet(handType);
        }

        /// <summary>
        /// 當表單被按下鍵盤時觸發
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPoker_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.btnDealCard.Enabled == false)
            {
                switch(e.KeyChar)
                {
                    case 'q':
                        // 同花大順
                        playerPoker[0] = 51;
                        playerPoker[1] = 47;
                        playerPoker[2] = 43;
                        playerPoker[3] = 39;
                        playerPoker[4] = 3;

                        break;
                    case 'w':
                        // 同花順
                        playerPoker[0] = 37;
                        playerPoker[1] = 33;
                        playerPoker[2] = 29;
                        playerPoker[3] = 25;
                        playerPoker[4] = 21;
                        break;
                    case 'e':
                        // 同花
                        playerPoker[0] = 50;
                        playerPoker[1] = 38;
                        playerPoker[2] = 34;
                        playerPoker[3] = 22;
                        playerPoker[4] = 18;
                        break;
                    case 'r':
                        // 鐵支
                        playerPoker[0] = 48;
                        playerPoker[1] = 39;
                        playerPoker[2] = 38;
                        playerPoker[3] = 37;
                        playerPoker[4] = 36;
                        break;
                    case 't':
                        // 葫蘆
                        playerPoker[0] = 30;
                        playerPoker[1] = 29;
                        playerPoker[2] = 6;
                        playerPoker[3] = 5;
                        playerPoker[4] = 4;
                        break;
                    case 'y':
                        // 三條
                        playerPoker[0] = 48;
                        playerPoker[1] = 39;
                        playerPoker[2] = 15;
                        playerPoker[3] = 14;
                        playerPoker[4] = 13;
                        break;
                }

                // 顯示五張撲克牌到桌面上
                this.ShowCards();
            }
        }
        private int GetOdds(string handType)
        {
            switch (handType)
            {
                case "皇家同花順":
                case "同花大順":
                    return 250;

                case "同花順":
                    return 50;

                case "四條":
                case "鐵支":
                    return 25;

                case "葫蘆":
                    return 9;

                case "同花":
                    return 6;

                case "順子":
                    return 4;

                case "三條":
                    return 3;

                case "兩對":
                    return 2;

                case "一對":
                    return 1;

                default:
                    return 0;
            }
        }
        private void SettleBet(string handType)
        {
            int odds = GetOdds(handType);
            int prize = currentBet * odds;

            totalMoney += prize;
            txtMoney.Text = totalMoney.ToString();

            MessageBox.Show(
                "牌型：" + handType +
                "\n賠率：" + odds +
                "\n中獎金額：" + prize +
                "\n目前總資金：" + totalMoney
            );

            currentBet = 0;
            hasBet = false;

            btnDealCard.Enabled = false;
            btnChangeCard.Enabled = false;
            btnCheck.Enabled = false;

            btnRecharge.Enabled = true;
            txtRechargeMoney.Enabled = true;

            if (CheckBankruptcy())
            {
                return;
            }

            btnBet.Enabled = true;
            txtBetMoney.Enabled = true;
            btnAllIn.Enabled = true;
        }
        private bool CheckBankruptcy()
        {
            if (totalMoney <= 0 && !hasBet)
            {
                totalMoney = 0;
                txtMoney.Text = totalMoney.ToString();

                lblResult.Text = "你破產了，請儲值後再繼續遊戲！";

                btnBet.Enabled = false;
                txtBetMoney.Enabled = false;
                btnAllIn.Enabled = false;

                btnDealCard.Enabled = false;
                btnChangeCard.Enabled = false;
                btnCheck.Enabled = false;

                btnRecharge.Enabled = true;
                txtRechargeMoney.Enabled = true;

                MessageBox.Show("你已經破產了！請按「儲值」後再繼續遊戲。");
                return true;
            }

            return false;
        }

        #endregion

        private void btnBet_Click(object sender, EventArgs e)
        {
            if (totalMoney <= 0)
            {
                CheckBankruptcy();
                return;
            }

            int bet;

            if (!int.TryParse(txtBetMoney.Text, out bet))
            {
                MessageBox.Show("請輸入正確的押注金額！");
                return;
            }

            if (bet <= 0)
            {
                MessageBox.Show("押注金額必須大於 0！");
                return;
            }

            if (bet > totalMoney)
            {
                MessageBox.Show("押注金額不能超過總資金！");
                return;
            }

            currentBet = bet;
            totalMoney -= currentBet;
            hasBet = true;

            txtMoney.Text = totalMoney.ToString();

            btnBet.Enabled = false;
            txtBetMoney.Enabled = false;
            btnAllIn.Enabled = false;

            btnRecharge.Enabled = false;
            txtRechargeMoney.Enabled = false;

            btnDealCard.Enabled = true;
            btnChangeCard.Enabled = false;
            btnCheck.Enabled = false;

            MessageBox.Show("下注成功！押注金額：" + currentBet);

        }

        private void btnAllIn_Click(object sender, EventArgs e)
        {
            if (hasBet)
            {
                MessageBox.Show("這局已經下注了！");
                return;
            }

            if (totalMoney <= 0)
            {
                CheckBankruptcy();
                return;
            }

            txtBetMoney.Text = totalMoney.ToString();

            btnBet_Click(sender, e);
        }

        private void btnRecharge_Click(object sender, EventArgs e)
        {
            if (hasBet)
            {
                MessageBox.Show("遊戲進行中不能儲值！");
                return;
            }

            int rechargeMoney;

            if (!int.TryParse(txtRechargeMoney.Text, out rechargeMoney))
            {
                MessageBox.Show("請輸入正確的儲值金額！");
                return;
            }

            if (rechargeMoney <= 0)
            {
                MessageBox.Show("儲值金額必須大於 0！");
                return;
            }

            totalMoney += rechargeMoney;
            txtMoney.Text = totalMoney.ToString();

            btnBet.Enabled = true;
            txtBetMoney.Enabled = true;
            btnAllIn.Enabled = true;

            btnDealCard.Enabled = false;
            btnChangeCard.Enabled = false;
            btnCheck.Enabled = false;

            btnRecharge.Enabled = true;
            txtRechargeMoney.Enabled = true;

            lblResult.Text = "儲值成功，目前總資金：" + totalMoney;

            MessageBox.Show("儲值成功！目前總資金：" + totalMoney);
        }
    }
}
