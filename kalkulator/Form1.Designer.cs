namespace kalkulator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            rad = new Button();
            deg = new Button();
            sin = new Button();
            inv = new Button();
            Cos = new Button();
            pi = new Button();
            tan = new Button();
            e = new Button();
            button11 = new Button();
            root = new Button();
            log = new Button();
            ln = new Button();
            silnia = new Button();
            jeden = new Button();
            cztery = new Button();
            siedem = new Button();
            lnawias = new Button();
            dwa = new Button();
            piec = new Button();
            osiem = new Button();
            pnawias = new Button();
            trzy = new Button();
            szesc = new Button();
            dziewiec = new Button();
            procent = new Button();
            odejmowanie = new Button();
            mnozenie = new Button();
            dzielenie = new Button();
            ac = new Button();
            dodawanie = new Button();
            rowna = new Button();
            dot = new Button();
            zero = new Button();
            xdoy = new Button();
            exp = new Button();
            ans = new Button();
            display = new TextBox();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            prostyKalkulatorToolStripMenuItem = new ToolStripMenuItem();
            naukowyKalkulatorToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // rad
            // 
            rad.Location = new Point(446, 66);
            rad.Name = "rad";
            rad.Size = new Size(100, 40);
            rad.TabIndex = 2;
            rad.Text = "Rad";
            rad.UseVisualStyleBackColor = true;
            rad.Click += rad_Click;
            // 
            // deg
            // 
            deg.Location = new Point(552, 66);
            deg.Name = "deg";
            deg.Size = new Size(100, 40);
            deg.TabIndex = 3;
            deg.Text = "Deg";
            deg.UseVisualStyleBackColor = true;
            deg.Click += deg_Click;
            // 
            // sin
            // 
            sin.Location = new Point(552, 112);
            sin.Name = "sin";
            sin.Size = new Size(100, 40);
            sin.TabIndex = 5;
            sin.Text = "Sin";
            sin.UseVisualStyleBackColor = true;
            sin.Click += sin_Click;
            // 
            // inv
            // 
            inv.Location = new Point(446, 112);
            inv.Name = "inv";
            inv.Size = new Size(100, 40);
            inv.TabIndex = 4;
            inv.Text = "Inv";
            inv.UseVisualStyleBackColor = true;
            inv.Click += inv_Click;
            // 
            // Cos
            // 
            Cos.Location = new Point(552, 158);
            Cos.Name = "Cos";
            Cos.Size = new Size(100, 40);
            Cos.TabIndex = 7;
            Cos.Text = "Cos";
            Cos.UseVisualStyleBackColor = true;
            Cos.Click += Cos_Click;
            // 
            // pi
            // 
            pi.Location = new Point(446, 158);
            pi.Name = "pi";
            pi.Size = new Size(100, 40);
            pi.TabIndex = 6;
            pi.Text = "π";
            pi.UseVisualStyleBackColor = true;
            pi.Click += pi_Click;
            // 
            // tan
            // 
            tan.Location = new Point(552, 204);
            tan.Name = "tan";
            tan.Size = new Size(100, 40);
            tan.TabIndex = 9;
            tan.Text = "Tan";
            tan.UseVisualStyleBackColor = true;
            tan.Click += tan_Click;
            // 
            // e
            // 
            e.Location = new Point(446, 204);
            e.Name = "e";
            e.Size = new Size(100, 40);
            e.TabIndex = 8;
            e.Text = "e";
            e.UseVisualStyleBackColor = true;
            e.Click += e_Click;
            // 
            // button11
            // 
            button11.Location = new Point(118, 277);
            button11.Name = "button11";
            button11.Size = new Size(100, 40);
            button11.TabIndex = 11;
            button11.Text = "button11";
            button11.UseVisualStyleBackColor = true;
            // 
            // root
            // 
            root.Location = new Point(658, 204);
            root.Name = "root";
            root.Size = new Size(100, 40);
            root.TabIndex = 13;
            root.Text = "√";
            root.UseVisualStyleBackColor = true;
            root.Click += root_Click;
            // 
            // log
            // 
            log.Location = new Point(658, 158);
            log.Name = "log";
            log.Size = new Size(100, 40);
            log.TabIndex = 12;
            log.Text = "log";
            log.UseVisualStyleBackColor = true;
            log.Click += log_Click;
            // 
            // ln
            // 
            ln.Location = new Point(658, 112);
            ln.Name = "ln";
            ln.Size = new Size(100, 40);
            ln.TabIndex = 11;
            ln.Text = "ln";
            ln.UseVisualStyleBackColor = true;
            ln.Click += ln_Click;
            // 
            // silnia
            // 
            silnia.Location = new Point(658, 66);
            silnia.Name = "silnia";
            silnia.Size = new Size(100, 40);
            silnia.TabIndex = 10;
            silnia.Text = "x!";
            silnia.UseVisualStyleBackColor = true;
            silnia.Click += silnia_Click;
            // 
            // jeden
            // 
            jeden.Location = new Point(13, 204);
            jeden.Name = "jeden";
            jeden.Size = new Size(100, 40);
            jeden.TabIndex = 17;
            jeden.Text = "1";
            jeden.UseVisualStyleBackColor = true;
            jeden.Click += EnterNumbers;
            // 
            // cztery
            // 
            cztery.Location = new Point(13, 158);
            cztery.Name = "cztery";
            cztery.Size = new Size(100, 40);
            cztery.TabIndex = 16;
            cztery.Text = "4";
            cztery.UseVisualStyleBackColor = true;
            cztery.Click += EnterNumbers;
            // 
            // siedem
            // 
            siedem.Location = new Point(13, 112);
            siedem.Name = "siedem";
            siedem.Size = new Size(100, 40);
            siedem.TabIndex = 15;
            siedem.Text = "7";
            siedem.UseVisualStyleBackColor = true;
            siedem.Click += EnterNumbers;
            // 
            // lnawias
            // 
            lnawias.Location = new Point(13, 66);
            lnawias.Name = "lnawias";
            lnawias.Size = new Size(100, 40);
            lnawias.TabIndex = 14;
            lnawias.Text = "(";
            lnawias.UseVisualStyleBackColor = true;
            lnawias.Click += lnawias_Click;
            // 
            // dwa
            // 
            dwa.Location = new Point(119, 204);
            dwa.Name = "dwa";
            dwa.Size = new Size(100, 40);
            dwa.TabIndex = 21;
            dwa.Text = "2";
            dwa.UseVisualStyleBackColor = true;
            dwa.Click += EnterNumbers;
            // 
            // piec
            // 
            piec.Location = new Point(119, 158);
            piec.Name = "piec";
            piec.Size = new Size(100, 40);
            piec.TabIndex = 20;
            piec.Text = "5";
            piec.UseVisualStyleBackColor = true;
            piec.Click += EnterNumbers;
            // 
            // osiem
            // 
            osiem.Location = new Point(119, 112);
            osiem.Name = "osiem";
            osiem.Size = new Size(100, 40);
            osiem.TabIndex = 19;
            osiem.Text = "8";
            osiem.UseVisualStyleBackColor = true;
            osiem.Click += EnterNumbers;
            // 
            // pnawias
            // 
            pnawias.Location = new Point(119, 66);
            pnawias.Name = "pnawias";
            pnawias.Size = new Size(100, 40);
            pnawias.TabIndex = 18;
            pnawias.Text = ")";
            pnawias.UseVisualStyleBackColor = true;
            pnawias.Click += pnawias_Click;
            // 
            // trzy
            // 
            trzy.Location = new Point(225, 204);
            trzy.Name = "trzy";
            trzy.Size = new Size(100, 40);
            trzy.TabIndex = 25;
            trzy.Text = "3";
            trzy.UseVisualStyleBackColor = true;
            trzy.Click += EnterNumbers;
            // 
            // szesc
            // 
            szesc.Location = new Point(225, 158);
            szesc.Name = "szesc";
            szesc.Size = new Size(100, 40);
            szesc.TabIndex = 24;
            szesc.Text = "6";
            szesc.UseVisualStyleBackColor = true;
            szesc.Click += EnterNumbers;
            // 
            // dziewiec
            // 
            dziewiec.Location = new Point(225, 112);
            dziewiec.Name = "dziewiec";
            dziewiec.Size = new Size(100, 40);
            dziewiec.TabIndex = 23;
            dziewiec.Text = "9";
            dziewiec.UseVisualStyleBackColor = true;
            dziewiec.Click += EnterNumbers;
            // 
            // procent
            // 
            procent.Location = new Point(225, 66);
            procent.Name = "procent";
            procent.Size = new Size(100, 40);
            procent.TabIndex = 22;
            procent.Text = "%";
            procent.UseVisualStyleBackColor = true;
            procent.Click += procent_Click;
            // 
            // odejmowanie
            // 
            odejmowanie.Location = new Point(331, 204);
            odejmowanie.Name = "odejmowanie";
            odejmowanie.Size = new Size(100, 40);
            odejmowanie.TabIndex = 29;
            odejmowanie.Text = "-";
            odejmowanie.UseVisualStyleBackColor = true;
            odejmowanie.Click += numop;
            // 
            // mnozenie
            // 
            mnozenie.Location = new Point(331, 158);
            mnozenie.Name = "mnozenie";
            mnozenie.RightToLeft = RightToLeft.Yes;
            mnozenie.Size = new Size(100, 40);
            mnozenie.TabIndex = 28;
            mnozenie.Text = "X";
            mnozenie.UseVisualStyleBackColor = true;
            mnozenie.Click += numop;
            // 
            // dzielenie
            // 
            dzielenie.Location = new Point(331, 112);
            dzielenie.Name = "dzielenie";
            dzielenie.Size = new Size(100, 40);
            dzielenie.TabIndex = 27;
            dzielenie.Text = "/";
            dzielenie.UseVisualStyleBackColor = true;
            dzielenie.Click += numop;
            // 
            // ac
            // 
            ac.Location = new Point(331, 66);
            ac.Name = "ac";
            ac.Size = new Size(100, 40);
            ac.TabIndex = 26;
            ac.Text = "AC";
            ac.UseVisualStyleBackColor = true;
            ac.Click += ac_Click;
            // 
            // dodawanie
            // 
            dodawanie.Location = new Point(331, 250);
            dodawanie.Name = "dodawanie";
            dodawanie.Size = new Size(100, 40);
            dodawanie.TabIndex = 36;
            dodawanie.Text = "+";
            dodawanie.UseVisualStyleBackColor = true;
            dodawanie.Click += numop;
            // 
            // rowna
            // 
            rowna.Location = new Point(225, 250);
            rowna.Name = "rowna";
            rowna.Size = new Size(100, 40);
            rowna.TabIndex = 35;
            rowna.Text = "=";
            rowna.UseVisualStyleBackColor = true;
            rowna.Click += rowna_Click;
            // 
            // dot
            // 
            dot.Location = new Point(119, 250);
            dot.Name = "dot";
            dot.Size = new Size(100, 40);
            dot.TabIndex = 34;
            dot.Text = ".";
            dot.UseVisualStyleBackColor = true;
            dot.Click += EnterNumbers;
            // 
            // zero
            // 
            zero.Location = new Point(13, 250);
            zero.Name = "zero";
            zero.Size = new Size(100, 40);
            zero.TabIndex = 33;
            zero.Text = "0";
            zero.UseVisualStyleBackColor = true;
            zero.Click += EnterNumbers;
            // 
            // xdoy
            // 
            xdoy.Location = new Point(658, 250);
            xdoy.Name = "xdoy";
            xdoy.Size = new Size(100, 40);
            xdoy.TabIndex = 32;
            xdoy.Text = "x^y";
            xdoy.UseVisualStyleBackColor = true;
            xdoy.Click += numop;
            // 
            // exp
            // 
            exp.Location = new Point(552, 250);
            exp.Name = "exp";
            exp.Size = new Size(100, 40);
            exp.TabIndex = 31;
            exp.Text = "Exp";
            exp.UseVisualStyleBackColor = true;
            exp.Click += numop;
            // 
            // ans
            // 
            ans.Location = new Point(446, 250);
            ans.Name = "ans";
            ans.Size = new Size(100, 40);
            ans.TabIndex = 30;
            ans.Text = "Ans";
            ans.UseVisualStyleBackColor = true;
            ans.Click += ans_Click;
            // 
            // display
            // 
            display.Location = new Point(12, 31);
            display.Name = "display";
            display.Size = new Size(746, 27);
            display.TabIndex = 37;
            display.TextChanged += display_TextChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(764, 28);
            menuStrip1.TabIndex = 38;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { prostyKalkulatorToolStripMenuItem, naukowyKalkulatorToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // prostyKalkulatorToolStripMenuItem
            // 
            prostyKalkulatorToolStripMenuItem.Name = "prostyKalkulatorToolStripMenuItem";
            prostyKalkulatorToolStripMenuItem.Size = new Size(222, 26);
            prostyKalkulatorToolStripMenuItem.Text = "Prosty kalkulator";
            prostyKalkulatorToolStripMenuItem.Click += prostyKalkulatorToolStripMenuItem_Click;
            // 
            // naukowyKalkulatorToolStripMenuItem
            // 
            naukowyKalkulatorToolStripMenuItem.Name = "naukowyKalkulatorToolStripMenuItem";
            naukowyKalkulatorToolStripMenuItem.Size = new Size(222, 26);
            naukowyKalkulatorToolStripMenuItem.Text = "Naukowy kalkulator";
            naukowyKalkulatorToolStripMenuItem.Click += naukowyKalkulatorToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(764, 294);
            Controls.Add(display);
            Controls.Add(dodawanie);
            Controls.Add(rowna);
            Controls.Add(dot);
            Controls.Add(zero);
            Controls.Add(xdoy);
            Controls.Add(exp);
            Controls.Add(ans);
            Controls.Add(odejmowanie);
            Controls.Add(mnozenie);
            Controls.Add(dzielenie);
            Controls.Add(ac);
            Controls.Add(trzy);
            Controls.Add(szesc);
            Controls.Add(dziewiec);
            Controls.Add(procent);
            Controls.Add(dwa);
            Controls.Add(piec);
            Controls.Add(osiem);
            Controls.Add(pnawias);
            Controls.Add(jeden);
            Controls.Add(cztery);
            Controls.Add(siedem);
            Controls.Add(lnawias);
            Controls.Add(root);
            Controls.Add(log);
            Controls.Add(ln);
            Controls.Add(silnia);
            Controls.Add(tan);
            Controls.Add(e);
            Controls.Add(Cos);
            Controls.Add(pi);
            Controls.Add(sin);
            Controls.Add(inv);
            Controls.Add(deg);
            Controls.Add(rad);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Click += EnterNumbers;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button rad;
        private Button deg;
        private Button sin;
        private Button inv;
        private Button Cos;
        private Button pi;
        private Button tan;
        private Button e;
        private Button button11;
        private Button root;
        private Button log;
        private Button ln;
        private Button silnia;
        private Button jeden;
        private Button cztery;
        private Button siedem;
        private Button lnawias;
        private Button dwa;
        private Button piec;
        private Button osiem;
        private Button pnawias;
        private Button trzy;
        private Button szesc;
        private Button dziewiec;
        private Button procent;
        private Button odejmowanie;
        private Button mnozenie;
        private Button dzielenie;
        private Button ac;
        private Button dodawanie;
        private Button rowna;
        private Button dot;
        private Button zero;
        private Button xdoy;
        private Button exp;
        private Button ans;
        private TextBox display;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem prostyKalkulatorToolStripMenuItem;
        private ToolStripMenuItem naukowyKalkulatorToolStripMenuItem;
    }
}