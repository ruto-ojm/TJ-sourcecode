//=================================================================
// �쐬��   �FTJ
// ���ō쐬���F2025/06/17
// �ύX���� �F
//   - 2025/06/17 �V�K�쐬�i���Łj
//   - 2025/06/22 �ꗗ�ɕ��ёւ��@�\��ǉ�
//   - 2025/06/27 �폜�{�^���̃A�C�R���ύX
//   - 2025/07/01 �\�����C�A�E�g�̉��P�Ɨ񕝒���
// �\�[�X�T�v�F
//   �o�^���ꂽ��ʏ����ꗗ�\�������ʁB������폜���삪�\�B
//=================================================================

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApp1
{
    public partial class Form5 : Form
    {
        // ���͒l�i��ʗʁA�Ԑ����A���s�Ґ��j��ێ�����t�B�[���h
        private int x, y, z;

        // �v�Z�Ɏg�p����֐��̃��X�g�iFunctionInfo�N���X�Ŗ��O�Ə�����ێ��j
        private List<FunctionInfo> functions;

        // Form4 ����Ăяo����郁�C���̃R���X�g���N�^
        public Form5(int x, int y, int z)
        {
            InitializeComponent();

            // ���ʕ\���p�̃e�L�X�g�{�b�N�X�ݒ�
            textBox1.ReadOnly = true;                 // �ҏW�s��
            textBox1.Multiline = true;                // �����s�Ή�
            textBox1.ScrollBars = ScrollBars.Vertical; // �c�X�N���[����\��
            textBox1.BackColor = SystemColors.Control; // �w�i���V�X�e���W���F��
            textBox1.BorderStyle = BorderStyle.None;  // �g�����Ȃ���
            textBox1.TabStop = false;                 // �^�u�ړ��Ώۂ��珜�O

            // ���͒l���t�B�[���h�֊i�[�i���ƂŎg�p�j
            this.x = x;
            this.y = y;
            this.z = z;

            // �g�p����֐��̏�����
            // FunctionInfo(string name, Func<int, int, int, double> func)
            functions = new List<FunctionInfo>()
            {
                new FunctionInfo("���Z", (a, b, c) => a + b + c),        // �P���ȑ����Z
                new FunctionInfo("��Z", (a, b, c) => a * b * c),        // �|���Z�i�̐ϓI�ȈӖ��j
                // ���ɕK�v�Ȋ֐�������΂����ɒǉ��\
            };

            // ���ʕ\���̏��������s�i�e�L�X�g�{�b�N�X�֕\���j
            DisplayResults();
        }

        // Form4 ����Ăяo�����I�[�o�[���[�h�Fdummy �͎g�킸�ɃI�[�o�[���[�h���ʗp
        public Form5(int x, int y, int z, int dummy) : this(x, y, z)
        {
            // dummy �����͈Ӗ����������A�ʂ̌Ăяo�����Ƃ��ċ�ʂ��邽�߂����ɑ���
        }

        // ���͒l�ƌv�Z���ʂ��e�L�X�g�{�b�N�X�ɕ\�����鏈��
        private void DisplayResults()
        {
            var sb = new StringBuilder();

            // ���͒l�̃��x���t���\��
            sb.AppendLine($"���͒l: X={x}, Y={y}, Z={z}");
            sb.AppendLine("�œK������:");

            // ���ꂼ��̊֐������s���Č��ʂ𕶎���Ƃ��Ē~��
            foreach (var func in functions)
            {
                double result = func.Calculate(x, y, z);  // �֐��̎��s
                sb.AppendLine($"{func.Name}: {result}"); // �֐����ƌ��ʂ�\��
            }

            // �e�L�X�g�{�b�N�X�ɕ\�����e��ݒ�
            textBox1.Text = sb.ToString();
        }

        // �߂�{�^�����N���b�N���ꂽ���F���p�҃��j���[�ɖ߂�
        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(); // ���p�җp���j���[��V�K����
            form3.Show();              // �\��
            this.Close();              // ���̌��ʕ\���t�H�[�������i��\���łȂ��j���j
        }
    }
}