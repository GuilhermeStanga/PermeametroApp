namespace PermeametroApp
{
    partial class Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageMon = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.chartE = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartD = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.textColeta = new System.Windows.Forms.TextBox();
            this.butStart = new System.Windows.Forms.Button();
            this.butStop = new System.Windows.Forms.Button();
            this.butGerarPlanilha = new System.Windows.Forms.Button();
            this.tabPageConf = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textPorta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBaudRate = new System.Windows.Forms.TextBox();
            this.texDataBits = new System.Windows.Forms.TextBox();
            this.textStopBits = new System.Windows.Forms.TextBox();
            this.textParidade = new System.Windows.Forms.TextBox();
            this.textPeriodoAtualizacao = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.textPastaExportacao = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.checkExport = new System.Windows.Forms.CheckBox();
            this.textSomador = new System.Windows.Forms.TextBox();
            this.textMultiplicador = new System.Windows.Forms.TextBox();
            this.comboGrafico = new System.Windows.Forms.ComboBox();
            this.btnRegExcluir = new System.Windows.Forms.Button();
            this.btnRegAdd = new System.Windows.Forms.Button();
            this.textRegOffset = new System.Windows.Forms.TextBox();
            this.textRegEscravo = new System.Windows.Forms.TextBox();
            this.textRegNome = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IDEscravo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Offset = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Grafico = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Multiplicador = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Somador = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl1.SuspendLayout();
            this.tabPageMon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartD)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPageConf.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageMon);
            this.tabControl1.Controls.Add(this.tabPageConf);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(934, 481);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageMon
            // 
            this.tabPageMon.Controls.Add(this.splitContainer1);
            this.tabPageMon.Controls.Add(this.panel1);
            this.tabPageMon.Location = new System.Drawing.Point(4, 22);
            this.tabPageMon.Name = "tabPageMon";
            this.tabPageMon.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMon.Size = new System.Drawing.Size(926, 455);
            this.tabPageMon.TabIndex = 0;
            this.tabPageMon.Text = "Monitorar";
            this.tabPageMon.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 103);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.chartE);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.chartD);
            this.splitContainer1.Size = new System.Drawing.Size(920, 349);
            this.splitContainer1.SplitterDistance = 460;
            this.splitContainer1.TabIndex = 0;
            // 
            // chartE
            // 
            this.chartE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea3.Name = "ChartArea1";
            this.chartE.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartE.Legends.Add(legend3);
            this.chartE.Location = new System.Drawing.Point(15, 15);
            this.chartE.Name = "chartE";
            this.chartE.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            this.chartE.Size = new System.Drawing.Size(430, 320);
            this.chartE.TabIndex = 4;
            this.chartE.Text = "chartE";
            // 
            // chartD
            // 
            this.chartD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartD.BorderSkin.BorderColor = System.Drawing.Color.Gray;
            chartArea4.Name = "ChartArea1";
            this.chartD.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartD.Legends.Add(legend4);
            this.chartD.Location = new System.Drawing.Point(15, 15);
            this.chartD.Name = "chartD";
            this.chartD.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            this.chartD.Size = new System.Drawing.Size(430, 320);
            this.chartD.TabIndex = 5;
            this.chartD.Text = "chartD";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.textColeta);
            this.panel1.Controls.Add(this.butStart);
            this.panel1.Controls.Add(this.butStop);
            this.panel1.Controls.Add(this.butGerarPlanilha);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(920, 100);
            this.panel1.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Nome da Coleta:";
            // 
            // textColeta
            // 
            this.textColeta.Location = new System.Drawing.Point(105, 32);
            this.textColeta.Name = "textColeta";
            this.textColeta.Size = new System.Drawing.Size(212, 20);
            this.textColeta.TabIndex = 6;
            // 
            // butStart
            // 
            this.butStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butStart.Location = new System.Drawing.Point(477, 29);
            this.butStart.Name = "butStart";
            this.butStart.Size = new System.Drawing.Size(139, 23);
            this.butStart.TabIndex = 0;
            this.butStart.Text = "Iniciar";
            this.butStart.UseVisualStyleBackColor = true;
            this.butStart.Click += new System.EventHandler(this.butStart_Click);
            // 
            // butStop
            // 
            this.butStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butStop.Location = new System.Drawing.Point(666, 29);
            this.butStop.Name = "butStop";
            this.butStop.Size = new System.Drawing.Size(75, 23);
            this.butStop.TabIndex = 1;
            this.butStop.Text = "Parar";
            this.butStop.UseVisualStyleBackColor = true;
            this.butStop.Click += new System.EventHandler(this.butStop_Click);
            // 
            // butGerarPlanilha
            // 
            this.butGerarPlanilha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butGerarPlanilha.Location = new System.Drawing.Point(666, 62);
            this.butGerarPlanilha.Name = "butGerarPlanilha";
            this.butGerarPlanilha.Size = new System.Drawing.Size(168, 23);
            this.butGerarPlanilha.TabIndex = 2;
            this.butGerarPlanilha.Text = "Exportar Captura";
            this.butGerarPlanilha.UseVisualStyleBackColor = true;
            this.butGerarPlanilha.Click += new System.EventHandler(this.butGerarPlanilha_Click);
            // 
            // tabPageConf
            // 
            this.tabPageConf.Controls.Add(this.panel4);
            this.tabPageConf.Controls.Add(this.panel3);
            this.tabPageConf.Controls.Add(this.panel2);
            this.tabPageConf.Location = new System.Drawing.Point(4, 22);
            this.tabPageConf.Name = "tabPageConf";
            this.tabPageConf.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConf.Size = new System.Drawing.Size(926, 455);
            this.tabPageConf.TabIndex = 1;
            this.tabPageConf.Text = "Configrações";
            this.tabPageConf.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(346, 321);
            this.panel3.TabIndex = 31;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textPorta);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBaudRate);
            this.groupBox1.Controls.Add(this.texDataBits);
            this.groupBox1.Controls.Add(this.textStopBits);
            this.groupBox1.Controls.Add(this.textParidade);
            this.groupBox1.Controls.Add(this.textPeriodoAtualizacao);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 321);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Comunicação com Escravo";
            // 
            // textPorta
            // 
            this.textPorta.Location = new System.Drawing.Point(155, 58);
            this.textPorta.Name = "textPorta";
            this.textPorta.Size = new System.Drawing.Size(100, 20);
            this.textPorta.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Porta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Baud Rate:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data Bits:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Stop Bits:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Paridade:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Periodo de Atualização (ms):";
            // 
            // textBaudRate
            // 
            this.textBaudRate.Location = new System.Drawing.Point(155, 89);
            this.textBaudRate.Name = "textBaudRate";
            this.textBaudRate.Size = new System.Drawing.Size(100, 20);
            this.textBaudRate.TabIndex = 7;
            // 
            // texDataBits
            // 
            this.texDataBits.Location = new System.Drawing.Point(155, 122);
            this.texDataBits.Name = "texDataBits";
            this.texDataBits.Size = new System.Drawing.Size(100, 20);
            this.texDataBits.TabIndex = 8;
            // 
            // textStopBits
            // 
            this.textStopBits.Location = new System.Drawing.Point(155, 157);
            this.textStopBits.Name = "textStopBits";
            this.textStopBits.Size = new System.Drawing.Size(100, 20);
            this.textStopBits.TabIndex = 9;
            // 
            // textParidade
            // 
            this.textParidade.Location = new System.Drawing.Point(155, 188);
            this.textParidade.Name = "textParidade";
            this.textParidade.Size = new System.Drawing.Size(100, 20);
            this.textParidade.TabIndex = 10;
            // 
            // textPeriodoAtualizacao
            // 
            this.textPeriodoAtualizacao.Location = new System.Drawing.Point(155, 222);
            this.textPeriodoAtualizacao.Name = "textPeriodoAtualizacao";
            this.textPeriodoAtualizacao.Size = new System.Drawing.Size(100, 20);
            this.textPeriodoAtualizacao.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Controls.Add(this.textPastaExportacao);
            this.panel2.Controls.Add(this.btnSalvar);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.checkExport);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 324);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(920, 128);
            this.panel2.TabIndex = 30;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(60, 72);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 23);
            this.btnCancelar.TabIndex = 24;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // textPastaExportacao
            // 
            this.textPastaExportacao.Location = new System.Drawing.Point(197, 6);
            this.textPastaExportacao.Name = "textPastaExportacao";
            this.textPastaExportacao.Size = new System.Drawing.Size(421, 20);
            this.textPastaExportacao.TabIndex = 29;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Location = new System.Drawing.Point(670, 72);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(193, 23);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(57, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Pasta para Exportação:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(57, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Exportar dados após parar:";
            // 
            // checkExport
            // 
            this.checkExport.AutoSize = true;
            this.checkExport.Location = new System.Drawing.Point(197, 35);
            this.checkExport.Name = "checkExport";
            this.checkExport.Size = new System.Drawing.Size(15, 14);
            this.checkExport.TabIndex = 22;
            this.checkExport.UseVisualStyleBackColor = true;
            // 
            // textSomador
            // 
            this.textSomador.Location = new System.Drawing.Point(432, 165);
            this.textSomador.Name = "textSomador";
            this.textSomador.Size = new System.Drawing.Size(59, 20);
            this.textSomador.TabIndex = 27;
            // 
            // textMultiplicador
            // 
            this.textMultiplicador.Location = new System.Drawing.Point(367, 165);
            this.textMultiplicador.Name = "textMultiplicador";
            this.textMultiplicador.Size = new System.Drawing.Size(59, 20);
            this.textMultiplicador.TabIndex = 26;
            // 
            // comboGrafico
            // 
            this.comboGrafico.FormattingEnabled = true;
            this.comboGrafico.Items.AddRange(new object[] {
            "Nenhum",
            "Esquerdo",
            "Direito"});
            this.comboGrafico.Location = new System.Drawing.Point(285, 164);
            this.comboGrafico.Name = "comboGrafico";
            this.comboGrafico.Size = new System.Drawing.Size(76, 21);
            this.comboGrafico.TabIndex = 25;
            // 
            // btnRegExcluir
            // 
            this.btnRegExcluir.Location = new System.Drawing.Point(70, 203);
            this.btnRegExcluir.Name = "btnRegExcluir";
            this.btnRegExcluir.Size = new System.Drawing.Size(100, 23);
            this.btnRegExcluir.TabIndex = 23;
            this.btnRegExcluir.Text = "Excluir";
            this.btnRegExcluir.UseVisualStyleBackColor = true;
            this.btnRegExcluir.Click += new System.EventHandler(this.btnRegExcluir_Click);
            // 
            // btnRegAdd
            // 
            this.btnRegAdd.Location = new System.Drawing.Point(389, 203);
            this.btnRegAdd.Name = "btnRegAdd";
            this.btnRegAdd.Size = new System.Drawing.Size(122, 23);
            this.btnRegAdd.TabIndex = 20;
            this.btnRegAdd.Text = "Adicionar";
            this.btnRegAdd.UseVisualStyleBackColor = true;
            this.btnRegAdd.Click += new System.EventHandler(this.btnRegAdd_Click);
            // 
            // textRegOffset
            // 
            this.textRegOffset.Location = new System.Drawing.Point(235, 164);
            this.textRegOffset.Name = "textRegOffset";
            this.textRegOffset.Size = new System.Drawing.Size(44, 20);
            this.textRegOffset.TabIndex = 19;
            // 
            // textRegEscravo
            // 
            this.textRegEscravo.Location = new System.Drawing.Point(171, 164);
            this.textRegEscravo.Name = "textRegEscravo";
            this.textRegEscravo.Size = new System.Drawing.Size(58, 20);
            this.textRegEscravo.TabIndex = 18;
            // 
            // textRegNome
            // 
            this.textRegNome.Location = new System.Drawing.Point(70, 164);
            this.textRegNome.Name = "textRegNome";
            this.textRegNome.Size = new System.Drawing.Size(100, 20);
            this.textRegNome.TabIndex = 17;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nome,
            this.IDEscravo,
            this.Offset,
            this.Grafico,
            this.Multiplicador,
            this.Somador});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(70, 58);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(441, 97);
            this.listView1.TabIndex = 16;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            this.Nome.Width = 48;
            // 
            // IDEscravo
            // 
            this.IDEscravo.Text = "IDEscravo";
            this.IDEscravo.Width = 66;
            // 
            // Offset
            // 
            this.Offset.Text = "Offset";
            this.Offset.Width = 46;
            // 
            // Grafico
            // 
            this.Grafico.Text = "Gráfico";
            this.Grafico.Width = 79;
            // 
            // Multiplicador
            // 
            this.Multiplicador.Text = "Multiplicador";
            this.Multiplicador.Width = 71;
            // 
            // Somador
            // 
            this.Somador.Text = "Somador";
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(355, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(568, 321);
            this.panel4.TabIndex = 32;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listView1);
            this.groupBox2.Controls.Add(this.textRegNome);
            this.groupBox2.Controls.Add(this.textRegEscravo);
            this.groupBox2.Controls.Add(this.textSomador);
            this.groupBox2.Controls.Add(this.textRegOffset);
            this.groupBox2.Controls.Add(this.textMultiplicador);
            this.groupBox2.Controls.Add(this.btnRegExcluir);
            this.groupBox2.Controls.Add(this.comboGrafico);
            this.groupBox2.Controls.Add(this.btnRegAdd);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(568, 321);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Holding Registers";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 481);
            this.Controls.Add(this.tabControl1);
            this.Name = "Principal";
            this.Text = "Coletor de Dados V. 1.0.0";
            this.tabControl1.ResumeLayout(false);
            this.tabPageMon.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartD)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPageConf.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageMon;
        private System.Windows.Forms.TabPage tabPageConf;
        private System.Windows.Forms.Button butGerarPlanilha;
        private System.Windows.Forms.Button butStop;
        private System.Windows.Forms.Button butStart;
        private System.Windows.Forms.TextBox textPorta;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBaudRate;
        private System.Windows.Forms.TextBox texDataBits;
        private System.Windows.Forms.TextBox textStopBits;
        private System.Windows.Forms.TextBox textParidade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textPeriodoAtualizacao;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader IDEscravo;
        private System.Windows.Forms.ColumnHeader Offset;
        private System.Windows.Forms.TextBox textRegNome;
        private System.Windows.Forms.TextBox textRegEscravo;
        private System.Windows.Forms.TextBox textRegOffset;
        private System.Windows.Forms.Button btnRegAdd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkExport;
        private System.Windows.Forms.Button btnRegExcluir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textColeta;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ColumnHeader Grafico;
        private System.Windows.Forms.ComboBox comboGrafico;
        private System.Windows.Forms.ColumnHeader Multiplicador;
        private System.Windows.Forms.ColumnHeader Somador;
        private System.Windows.Forms.TextBox textMultiplicador;
        private System.Windows.Forms.TextBox textSomador;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textPastaExportacao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartE;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartD;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

