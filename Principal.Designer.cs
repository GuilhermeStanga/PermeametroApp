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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageMon = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.textColeta = new System.Windows.Forms.TextBox();
            this.butStart = new System.Windows.Forms.Button();
            this.butStop = new System.Windows.Forms.Button();
            this.butGerarPlanilha = new System.Windows.Forms.Button();
            this.chartD = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartE = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPageConf = new System.Windows.Forms.TabPage();
            this.textPastaExportacao = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textSomador = new System.Windows.Forms.TextBox();
            this.textMultiplicador = new System.Windows.Forms.TextBox();
            this.comboGrafico = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRegExcluir = new System.Windows.Forms.Button();
            this.checkExport = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
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
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textPeriodoAtualizacao = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textParidade = new System.Windows.Forms.TextBox();
            this.textStopBits = new System.Windows.Forms.TextBox();
            this.texDataBits = new System.Windows.Forms.TextBox();
            this.textBaudRate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textPorta = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabPageMon.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartE)).BeginInit();
            this.tabPageConf.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(886, 486);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageMon
            // 
            this.tabPageMon.Controls.Add(this.panel3);
            this.tabPageMon.Controls.Add(this.panel2);
            this.tabPageMon.Controls.Add(this.statusStrip1);
            this.tabPageMon.Controls.Add(this.panel1);
            this.tabPageMon.Location = new System.Drawing.Point(4, 22);
            this.tabPageMon.Name = "tabPageMon";
            this.tabPageMon.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMon.Size = new System.Drawing.Size(878, 460);
            this.tabPageMon.TabIndex = 0;
            this.tabPageMon.Text = "Monitorar";
            this.tabPageMon.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(3, 435);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(872, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.textColeta);
            this.panel1.Controls.Add(this.butStart);
            this.panel1.Controls.Add(this.butStop);
            this.panel1.Controls.Add(this.butGerarPlanilha);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(872, 100);
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
            this.butStart.Location = new System.Drawing.Point(429, 29);
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
            this.butStop.Location = new System.Drawing.Point(618, 29);
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
            this.butGerarPlanilha.Location = new System.Drawing.Point(618, 62);
            this.butGerarPlanilha.Name = "butGerarPlanilha";
            this.butGerarPlanilha.Size = new System.Drawing.Size(168, 23);
            this.butGerarPlanilha.TabIndex = 2;
            this.butGerarPlanilha.Text = "Exportar Captura";
            this.butGerarPlanilha.UseVisualStyleBackColor = true;
            this.butGerarPlanilha.Click += new System.EventHandler(this.butGerarPlanilha_Click);
            // 
            // chartD
            // 
            this.chartD.BorderSkin.BorderColor = System.Drawing.Color.Gray;
            chartArea7.Name = "ChartArea1";
            this.chartD.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chartD.Legends.Add(legend7);
            this.chartD.Location = new System.Drawing.Point(3, 12);
            this.chartD.Name = "chartD";
            this.chartD.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            this.chartD.Size = new System.Drawing.Size(419, 293);
            this.chartD.TabIndex = 4;
            this.chartD.Text = "chartD";
            // 
            // chartE
            // 
            chartArea8.Name = "ChartArea1";
            this.chartE.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.chartE.Legends.Add(legend8);
            this.chartE.Location = new System.Drawing.Point(16, 12);
            this.chartE.Name = "chartE";
            this.chartE.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            this.chartE.Size = new System.Drawing.Size(419, 293);
            this.chartE.TabIndex = 3;
            this.chartE.Text = "chartE";
            // 
            // tabPageConf
            // 
            this.tabPageConf.Controls.Add(this.textPastaExportacao);
            this.tabPageConf.Controls.Add(this.label11);
            this.tabPageConf.Controls.Add(this.textSomador);
            this.tabPageConf.Controls.Add(this.textMultiplicador);
            this.tabPageConf.Controls.Add(this.comboGrafico);
            this.tabPageConf.Controls.Add(this.btnCancelar);
            this.tabPageConf.Controls.Add(this.btnRegExcluir);
            this.tabPageConf.Controls.Add(this.checkExport);
            this.tabPageConf.Controls.Add(this.label9);
            this.tabPageConf.Controls.Add(this.btnRegAdd);
            this.tabPageConf.Controls.Add(this.textRegOffset);
            this.tabPageConf.Controls.Add(this.textRegEscravo);
            this.tabPageConf.Controls.Add(this.textRegNome);
            this.tabPageConf.Controls.Add(this.listView1);
            this.tabPageConf.Controls.Add(this.label8);
            this.tabPageConf.Controls.Add(this.label7);
            this.tabPageConf.Controls.Add(this.textPeriodoAtualizacao);
            this.tabPageConf.Controls.Add(this.label6);
            this.tabPageConf.Controls.Add(this.textParidade);
            this.tabPageConf.Controls.Add(this.textStopBits);
            this.tabPageConf.Controls.Add(this.texDataBits);
            this.tabPageConf.Controls.Add(this.textBaudRate);
            this.tabPageConf.Controls.Add(this.label5);
            this.tabPageConf.Controls.Add(this.label4);
            this.tabPageConf.Controls.Add(this.label3);
            this.tabPageConf.Controls.Add(this.label2);
            this.tabPageConf.Controls.Add(this.textPorta);
            this.tabPageConf.Controls.Add(this.btnSalvar);
            this.tabPageConf.Controls.Add(this.label1);
            this.tabPageConf.Location = new System.Drawing.Point(4, 22);
            this.tabPageConf.Name = "tabPageConf";
            this.tabPageConf.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConf.Size = new System.Drawing.Size(878, 460);
            this.tabPageConf.TabIndex = 1;
            this.tabPageConf.Text = "Configrações";
            this.tabPageConf.UseVisualStyleBackColor = true;
            // 
            // textPastaExportacao
            // 
            this.textPastaExportacao.Location = new System.Drawing.Point(148, 272);
            this.textPastaExportacao.Name = "textPastaExportacao";
            this.textPastaExportacao.Size = new System.Drawing.Size(421, 20);
            this.textPastaExportacao.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 272);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Pasta para Exportação:";
            // 
            // textSomador
            // 
            this.textSomador.Location = new System.Drawing.Point(664, 201);
            this.textSomador.Name = "textSomador";
            this.textSomador.Size = new System.Drawing.Size(59, 20);
            this.textSomador.TabIndex = 27;
            // 
            // textMultiplicador
            // 
            this.textMultiplicador.Location = new System.Drawing.Point(599, 201);
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
            this.comboGrafico.Location = new System.Drawing.Point(517, 200);
            this.comboGrafico.Name = "comboGrafico";
            this.comboGrafico.Size = new System.Drawing.Size(76, 21);
            this.comboGrafico.TabIndex = 25;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(63, 348);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 23);
            this.btnCancelar.TabIndex = 24;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRegExcluir
            // 
            this.btnRegExcluir.Location = new System.Drawing.Point(403, 239);
            this.btnRegExcluir.Name = "btnRegExcluir";
            this.btnRegExcluir.Size = new System.Drawing.Size(100, 23);
            this.btnRegExcluir.TabIndex = 23;
            this.btnRegExcluir.Text = "Excluir";
            this.btnRegExcluir.UseVisualStyleBackColor = true;
            this.btnRegExcluir.Click += new System.EventHandler(this.btnRegExcluir_Click);
            // 
            // checkExport
            // 
            this.checkExport.AutoSize = true;
            this.checkExport.Location = new System.Drawing.Point(148, 304);
            this.checkExport.Name = "checkExport";
            this.checkExport.Size = new System.Drawing.Size(15, 14);
            this.checkExport.TabIndex = 22;
            this.checkExport.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 304);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Exportar dados após parar:";
            // 
            // btnRegAdd
            // 
            this.btnRegAdd.Location = new System.Drawing.Point(569, 239);
            this.btnRegAdd.Name = "btnRegAdd";
            this.btnRegAdd.Size = new System.Drawing.Size(122, 23);
            this.btnRegAdd.TabIndex = 20;
            this.btnRegAdd.Text = "Adicionar";
            this.btnRegAdd.UseVisualStyleBackColor = true;
            this.btnRegAdd.Click += new System.EventHandler(this.btnRegAdd_Click);
            // 
            // textRegOffset
            // 
            this.textRegOffset.Location = new System.Drawing.Point(467, 200);
            this.textRegOffset.Name = "textRegOffset";
            this.textRegOffset.Size = new System.Drawing.Size(44, 20);
            this.textRegOffset.TabIndex = 19;
            // 
            // textRegEscravo
            // 
            this.textRegEscravo.Location = new System.Drawing.Point(403, 201);
            this.textRegEscravo.Name = "textRegEscravo";
            this.textRegEscravo.Size = new System.Drawing.Size(58, 20);
            this.textRegEscravo.TabIndex = 18;
            // 
            // textRegNome
            // 
            this.textRegNome.Location = new System.Drawing.Point(302, 201);
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
            this.listView1.Location = new System.Drawing.Point(302, 82);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(447, 97);
            this.listView1.TabIndex = 16;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            this.Nome.Width = 93;
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(400, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Configurações Holding Registers";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Configurações de comunicação";
            // 
            // textPeriodoAtualizacao
            // 
            this.textPeriodoAtualizacao.Location = new System.Drawing.Point(153, 222);
            this.textPeriodoAtualizacao.Name = "textPeriodoAtualizacao";
            this.textPeriodoAtualizacao.Size = new System.Drawing.Size(100, 20);
            this.textPeriodoAtualizacao.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Periodo de Atualização (ms):";
            // 
            // textParidade
            // 
            this.textParidade.Location = new System.Drawing.Point(91, 188);
            this.textParidade.Name = "textParidade";
            this.textParidade.Size = new System.Drawing.Size(100, 20);
            this.textParidade.TabIndex = 10;
            // 
            // textStopBits
            // 
            this.textStopBits.Location = new System.Drawing.Point(91, 163);
            this.textStopBits.Name = "textStopBits";
            this.textStopBits.Size = new System.Drawing.Size(100, 20);
            this.textStopBits.TabIndex = 9;
            // 
            // texDataBits
            // 
            this.texDataBits.Location = new System.Drawing.Point(91, 138);
            this.texDataBits.Name = "texDataBits";
            this.texDataBits.Size = new System.Drawing.Size(100, 20);
            this.texDataBits.TabIndex = 8;
            // 
            // textBaudRate
            // 
            this.textBaudRate.Location = new System.Drawing.Point(91, 112);
            this.textBaudRate.Name = "textBaudRate";
            this.textBaudRate.Size = new System.Drawing.Size(100, 20);
            this.textBaudRate.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Paridade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Stop Bits:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data Bits:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Baud Rate:";
            // 
            // textPorta
            // 
            this.textPorta.Location = new System.Drawing.Point(91, 82);
            this.textPorta.Name = "textPorta";
            this.textPorta.Size = new System.Drawing.Size(100, 20);
            this.textPorta.TabIndex = 2;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(255, 348);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(193, 23);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Porta:";
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.chartE);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(3, 103);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(434, 332);
            this.panel2.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.chartD);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(441, 103);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(434, 332);
            this.panel3.TabIndex = 10;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 486);
            this.Controls.Add(this.tabControl1);
            this.Name = "Principal";
            this.Text = "Coletor de Dados";
            this.tabControl1.ResumeLayout(false);
            this.tabPageMon.ResumeLayout(false);
            this.tabPageMon.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartE)).EndInit();
            this.tabPageConf.ResumeLayout(false);
            this.tabPageConf.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chartE;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartD;
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
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
    }
}

