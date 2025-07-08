//=================================================================
// �쐬��   �FTJ
// ���ō쐬���F2025/06/17
// �ύX���� �F
//   - 2025/06/17 �V�K�쐬�i���Łj
//   - 2025/06/22 �O���t�`�惉�C�u�����̍X�V
//   - 2025/06/27 �\���`���ؑցi�_/�܂���j�@�\�̒ǉ�
//   - 2025/07/01 �f�[�^�����������ꍇ�̕\�����P
// �\�[�X�T�v�F
//   ��ʏ����O���t�ŉ��������ʁB�܂����_�O���t�\���ɑΉ�����B
//=================================================================

using System;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApp1
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            DisplayHistory(); // �t�H�[���̏��������ɗ�����ǂݍ���ŕ\��
        }

        // ���͗����iInputHistory.History�j����ʂɈꗗ�\������
        private void DisplayHistory()
        {
            var sb = new StringBuilder();

            // ��������̏ꍇ�͈ē����b�Z�[�W��\��
            if (InputHistory.History.Count == 0)
            {
                sb.AppendLine("�����͂���܂���B���͂��s���Ă��������B");
            }
            else
            {
                // �����̊e FunctionEntry �I�u�W�F�N�g�𕶎���Ƃ��Ēǉ�
                foreach (var entry in InputHistory.History)
                {
                    sb.AppendLine(entry.ToString()); // ���O�� .ToString() ���K�؂ɒ�`����Ă���O��
                }
            }

            // �\���p�e�L�X�g�{�b�N�X�̏����ݒ�
            textBox1.ReadOnly = true;                 // �ҏW�s��
            textBox1.Multiline = true;                // �����s�\��
            textBox1.ScrollBars = ScrollBars.Vertical; // �c�X�N���[���o�[��t����
            textBox1.BackColor = SystemColors.Control; // �w�i�F��W����
            textBox1.BorderStyle = BorderStyle.None;  // �g���Ȃ�
            textBox1.TabStop = false;                 // �^�u�L�[�ɂ��t�H�[�J�X�����O

            // ������e���e�L�X�g�{�b�N�X�ɕ\��
            textBox1.Text = sb.ToString();
        }

        // �߂�{�^���̏����F���p�҃��j���[�ɑJ��
        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide(); // ��\���ɂ��邱�ƂŖ߂�Ƃ��̕����������iClose �ł͔j�������j
        }

        // �����폜�{�^���̏����F�������N���A���ĉ�ʂ��X�V
        private void button2_Click(object sender, EventArgs e)
        {
            // �m�F���b�Z�[�W��\���i�둀��h�~�j
            var confirm = MessageBox.Show("���������ׂč폜���܂����H", "�m�F", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                InputHistory.History.Clear();  // �����̃��X�g���N���A�i���g���폜�j
                DisplayHistory();              // �\�����X�V�i��̏�ԂɂȂ�j
                MessageBox.Show("�������폜���܂����B", "����", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
