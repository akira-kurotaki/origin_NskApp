using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// t_13060_����ʒm��
    /// </summary>
    [Serializable]
    [Table("t_13060_����ʒm��")]
    [PrimaryKey(nameof(�g�����R�[�h), nameof(�N�Y), nameof(���ϖړI�R�[�h), nameof(�ދ敪), nameof(�������))]
    public class T13060����ʒm�� : ModelBase
    {
        /// <summary>
        /// �g�����R�[�h
        /// </summary>
        [Required]
        [Column("�g�����R�[�h", Order = 1)]
        [StringLength(3)]
        public string �g�����R�[�h { get; set; }

        /// <summary>
        /// �N�Y
        /// </summary>
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("�N�Y", Order = 2)]
        public short �N�Y { get; set; }

        /// <summary>
        /// ���ϖړI�R�[�h
        /// </summary>
        [Required]
        [Column("���ϖړI�R�[�h", Order = 3)]
        [StringLength(2)]
        public string ���ϖړI�R�[�h { get; set; }

        /// <summary>
        /// �ދ敪
        /// </summary>
        [Required]
        [Column("�ދ敪", Order = 4)]
        [StringLength(2)]
        public string �ދ敪 { get; set; }

        /// <summary>
        /// �������
        /// </summary>
        [Required]
        [Column("�������", Order = 5)]
        [StringLength(1)]
        public string ������� { get; set; }

        /// <summary>
        /// �����������
        /// </summary>
        [Column("�����������")]
        public string ����������� { get; set; }

        /// <summary>
        /// �g������������
        /// </summary>
        [Column("�g������������")]
        public string �g������������ { get; set; }

        /// <summary>
        /// ��\�Җ�E��
        /// </summary>
        [Column("��\�Җ�E��")]
        public string ��\�Җ�E�� { get; set; }

        /// <summary>
        /// �g��������
        /// </summary>
        [Column("�g��������")]
        public string �g�������� { get; set; }

        /// <summary>
        /// �A���������
        /// </summary>
        [Column("�A���������")]
        public string �A��������� { get; set; }

        /// <summary>
        /// �A�����
        /// </summary>
        [Column("�A�����")]
        public string �A����� { get; set; }

        /// <summary>
        /// ���ϖړI����
        /// </summary>
        [Column("���ϖړI����")]
        public string ���ϖړI���� { get; set; }

        /// <summary>
        /// ���s��P��
        /// </summary>
        [Column("���s��P��")]
        public Decimal? ���s��P�� { get; set; }

        /// <summary>
        /// ���ʒm�w���P��
        /// </summary>
        [Column("���ʒm�w���P��")]
        public Decimal? ���ʒm�w���P�� { get; set; }

        /// <summary>
        /// ����1�ތ��w���P��
        /// </summary>
        [Column("����1�ތ��w���P��")]
        public Decimal? ����1�ތ��w���P�� { get; set; }

        /// <summary>
        /// ����2�ތ��w���P��
        /// </summary>
        [Column("����2�ތ��w���P��")]
        public Decimal? ����2�ތ��w���P�� { get; set; }

        /// <summary>
        /// ����3�ތ��w���P��
        /// </summary>
        [Column("����3�ތ��w���P��")]
        public Decimal? ����3�ތ��w���P�� { get; set; }

        /// <summary>
        /// ����4�ތ��w���P��
        /// </summary>
        [Column("����4�ތ��w���P��")]
        public Decimal? ����4�ތ��w���P�� { get; set; }

        /// <summary>
        /// ����5�ތ��w���P��
        /// </summary>
        [Column("����5�ތ��w���P��")]
        public Decimal? ����5�ތ��w���P�� { get; set; }

        /// <summary>
        /// ����6�ތ��w���P��
        /// </summary>
        [Column("����6�ތ��w���P��")]
        public Decimal? ����6�ތ��w���P�� { get; set; }

        /// <summary>
        /// ����1�ތ��w���P��
        /// </summary>
        [Column("����1�ތ��w���P��")]
        public Decimal? ����1�ތ��w���P�� { get; set; }

        /// <summary>
        /// ��1�ތ��w���P��
        /// </summary>
        [Column("��1�ތ��w���P��")]
        public Decimal? ��1�ތ��w���P�� { get; set; }

        /// <summary>
        /// ��5�ތ��w���P��
        /// </summary>
        [Column("��5�ތ��w���P��")]
        public Decimal? ��5�ތ��w���P�� { get; set; }

        /// <summary>
        /// ��9�ތ��w���P��
        /// </summary>
        [Column("��9�ތ��w���P��")]
        public Decimal? ��9�ތ��w���P�� { get; set; }

        /// <summary>
        /// ��12�ތ��w���P��
        /// </summary>
        [Column("��12�ތ��w���P��")]
        public Decimal? ��12�ތ��w���P�� { get; set; }

        /// <summary>
        /// ��15�ތ��w���P��
        /// </summary>
        [Column("��15�ތ��w���P��")]
        public Decimal? ��15�ތ��w���P�� { get; set; }

        /// <summary>
        /// ��42�ތ��w���P��
        /// </summary>
        [Column("��42�ތ��w���P��")]
        public Decimal? ��42�ތ��w���P�� { get; set; }

        /// <summary>
        /// ��6�ތ��w���P��
        /// </summary>
        [Column("��6�ތ��w���P��")]
        public Decimal? ��6�ތ��w���P�� { get; set; }

        /// <summary>
        /// ��16�ތ��w���P��
        /// </summary>
        [Column("��16�ތ��w���P��")]
        public Decimal? ��16�ތ��w���P�� { get; set; }

        /// <summary>
        /// �⏞1_�⏞�����R�[�h
        /// </summary>
        [Column("�⏞1_�⏞�����R�[�h")]
        [StringLength(2)]
        public string �⏞1_�⏞�����R�[�h { get; set; }

        /// <summary>
        /// �⏞1_�⏞��������
        /// </summary>
        [Column("�⏞1_�⏞��������")]
        public string �⏞1_�⏞�������� { get; set; }

        /// <summary>
        /// �⏞1_�g�����v����ː�
        /// </summary>
        [Column("�⏞1_�g�����v����ː�")]
        public Decimal? �⏞1_�g�����v����ː� { get; set; }

        /// <summary>
        /// �⏞1_���󉄌ː�
        /// </summary>
        [Column("�⏞1_���󉄌ː�")]
        public Decimal? �⏞1_���󉄌ː� { get; set; }

        /// <summary>
        /// �⏞1_�g�����v����ʐ�
        /// </summary>
        [Column("�⏞1_�g�����v����ʐ�")]
        public Decimal? �⏞1_�g�����v����ʐ� { get; set; }

        /// <summary>
        /// �⏞1_�g�����v����n��
        /// </summary>
        [Column("�⏞1_�g�����v����n��")]
        public Decimal? �⏞1_�g�����v����n�� { get; set; }

        /// <summary>
        /// �⏞1_�g�����v�������
        /// </summary>
        [Column("�⏞1_�g�����v�������")]
        public Decimal? �⏞1_�g�����v������� { get; set; }

        /// <summary>
        /// �⏞1_�g�����v���ϋ��z
        /// </summary>
        [Column("�⏞1_�g�����v���ϋ��z")]
        public Decimal? �⏞1_�g�����v���ϋ��z { get; set; }

        /// <summary>
        /// �⏞1_�g�����v����ϊ|��
        /// </summary>
        [Column("�⏞1_�g�����v����ϊ|��")]
        public Decimal? �⏞1_�g�����v����ϊ|�� { get; set; }

        /// <summary>
        /// �⏞1_�g�����v���ϊ|��
        /// </summary>
        [Column("�⏞1_�g�����v���ϊ|��")]
        public Decimal? �⏞1_�g�����v���ϊ|�� { get; set; }

        /// <summary>
        /// �⏞1_�g�����v��t�a�������ϊz
        /// </summary>
        [Column("�⏞1_�g�����v��t�a�������ϊz")]
        public Decimal? �⏞1_�g�����v��t�a�������ϊz { get; set; }

        /// <summary>
        /// �⏞1_�g�����v�����a�������ϊz
        /// </summary>
        [Column("�⏞1_�g�����v�����a�������ϊz")]
        public Decimal? �⏞1_�g�����v�����a�������ϊz { get; set; }

        /// <summary>
        /// �⏞1_�g�����v�ی����z
        /// </summary>
        [Column("�⏞1_�g�����v�ی����z")]
        public Decimal? �⏞1_�g�����v�ی����z { get; set; }

        /// <summary>
        /// �⏞1_�g�����ی������z
        /// </summary>
        [Column("�⏞1_�g�����ی������z")]
        public Decimal? �⏞1_�g�����ی������z { get; set; }

        /// <summary>
        /// �⏞1_�ی���
        /// </summary>
        [Column("�⏞1_�ی���")]
        public Decimal? �⏞1_�ی��� { get; set; }

        /// <summary>
        /// �⏞1_����1�ވ���ʐ�
        /// </summary>
        [Column("�⏞1_����1�ވ���ʐ�")]
        public Decimal? �⏞1_����1�ވ���ʐ� { get; set; }

        /// <summary>
        /// �⏞1_����1�ޑ�����n��
        /// </summary>
        [Column("�⏞1_����1�ޑ�����n��")]
        public Decimal? �⏞1_����1�ޑ�����n�� { get; set; }

        /// <summary>
        /// �⏞1_����2�ވ���ʐ�
        /// </summary>
        [Column("�⏞1_����2�ވ���ʐ�")]
        public Decimal? �⏞1_����2�ވ���ʐ� { get; set; }

        /// <summary>
        /// �⏞1_����2�ޑ�����n��
        /// </summary>
        [Column("�⏞1_����2�ޑ�����n��")]
        public Decimal? �⏞1_����2�ޑ�����n�� { get; set; }

        /// <summary>
        /// �⏞1_����3�ވ���ʐ�
        /// </summary>
        [Column("�⏞1_����3�ވ���ʐ�")]
        public Decimal? �⏞1_����3�ވ���ʐ� { get; set; }

        /// <summary>
        /// �⏞1_����3�ޑ�����n��
        /// </summary>
        [Column("�⏞1_����3�ޑ�����n��")]
        public Decimal? �⏞1_����3�ޑ�����n�� { get; set; }

        /// <summary>
        /// �⏞1_����4�ވ���ʐ�
        /// </summary>
        [Column("�⏞1_����4�ވ���ʐ�")]
        public Decimal? �⏞1_����4�ވ���ʐ� { get; set; }

        /// <summary>
        /// �⏞1_����4�ޑ�����n��
        /// </summary>
        [Column("�⏞1_����4�ޑ�����n��")]
        public Decimal? �⏞1_����4�ޑ�����n�� { get; set; }

        /// <summary>
        /// �⏞1_����5�ވ���ʐ�
        /// </summary>
        [Column("�⏞1_����5�ވ���ʐ�")]
        public Decimal? �⏞1_����5�ވ���ʐ� { get; set; }

        /// <summary>
        /// �⏞1_����5�ޑ�����n��
        /// </summary>
        [Column("�⏞1_����5�ޑ�����n��")]
        public Decimal? �⏞1_����5�ޑ�����n�� { get; set; }

        /// <summary>
        /// �⏞1_����6�ވ���ʐ�
        /// </summary>
        [Column("�⏞1_����6�ވ���ʐ�")]
        public Decimal? �⏞1_����6�ވ���ʐ� { get; set; }

        /// <summary>
        /// �⏞1_����6�ޑ�����n��
        /// </summary>
        [Column("�⏞1_����6�ޑ�����n��")]
        public Decimal? �⏞1_����6�ޑ�����n�� { get; set; }

        /// <summary>
        /// �⏞1_����1�ވ���ʐ�
        /// </summary>
        [Column("�⏞1_����1�ވ���ʐ�")]
        public Decimal? �⏞1_����1�ވ���ʐ� { get; set; }

        /// <summary>
        /// �⏞1_����1�ޑ�����n��
        /// </summary>
        [Column("�⏞1_����1�ޑ�����n��")]
        public Decimal? �⏞1_����1�ޑ�����n�� { get; set; }

        /// <summary>
        /// �⏞1_��1�ވ���ʐ�
        /// </summary>
        [Column("�⏞1_��1�ވ���ʐ�")]
        public Decimal? �⏞1_��1�ވ���ʐ� { get; set; }

        /// <summary>
        /// �⏞1_��1�ޑ�����n��
        /// </summary>
        [Column("�⏞1_��1�ޑ�����n��")]
        public Decimal? �⏞1_��1�ޑ�����n�� { get; set; }

        /// <summary>
        /// �⏞1_��5�ވ���ʐ�
        /// </summary>
        [Column("�⏞1_��5�ވ���ʐ�")]
        public Decimal? �⏞1_��5�ވ���ʐ� { get; set; }

        /// <summary>
        /// �⏞1_��5�ޑ�����n��
        /// </summary>
        [Column("�⏞1_��5�ޑ�����n��")]
        public Decimal? �⏞1_��5�ޑ�����n�� { get; set; }

        /// <summary>
        /// �⏞1_��9�ވ���ʐ�
        /// </summary>
        [Column("�⏞1_��9�ވ���ʐ�")]
        public Decimal? �⏞1_��9�ވ���ʐ� { get; set; }

        /// <summary>
        /// �⏞1_��9�ޑ�����n��
        /// </summary>
        [Column("�⏞1_��9�ޑ�����n��")]
        public Decimal? �⏞1_��9�ޑ�����n�� { get; set; }

        /// <summary>
        /// �⏞1_��12�ވ���ʐ�
        /// </summary>
        [Column("�⏞1_��12�ވ���ʐ�")]
        public Decimal? �⏞1_��12�ވ���ʐ� { get; set; }

        /// <summary>
        /// �⏞1_��12�ޑ�����n��
        /// </summary>
        [Column("�⏞1_��12�ޑ�����n��")]
        public Decimal? �⏞1_��12�ޑ�����n�� { get; set; }

        /// <summary>
        /// �⏞1_��15�ވ���ʐ�
        /// </summary>
        [Column("�⏞1_��15�ވ���ʐ�")]
        public Decimal? �⏞1_��15�ވ���ʐ� { get; set; }

        /// <summary>
        /// �⏞1_��15�ޑ�����n��
        /// </summary>
        [Column("�⏞1_��15�ޑ�����n��")]
        public Decimal? �⏞1_��15�ޑ�����n�� { get; set; }

        /// <summary>
        /// �⏞1_��42�ވ���ʐ�
        /// </summary>
        [Column("�⏞1_��42�ވ���ʐ�")]
        public Decimal? �⏞1_��42�ވ���ʐ� { get; set; }

        /// <summary>
        /// �⏞1_��42�ޑ�����n��
        /// </summary>
        [Column("�⏞1_��42�ޑ�����n��")]
        public Decimal? �⏞1_��42�ޑ�����n�� { get; set; }

        /// <summary>
        /// �⏞1_��6�ވ���ʐ�
        /// </summary>
        [Column("�⏞1_��6�ވ���ʐ�")]
        public Decimal? �⏞1_��6�ވ���ʐ� { get; set; }

        /// <summary>
        /// �⏞1_��6�ޑ�����n��
        /// </summary>
        [Column("�⏞1_��6�ޑ�����n��")]
        public Decimal? �⏞1_��6�ޑ�����n�� { get; set; }

        /// <summary>
        /// �⏞1_��16�ވ���ʐ�
        /// </summary>
        [Column("�⏞1_��16�ވ���ʐ�")]
        public Decimal? �⏞1_��16�ވ���ʐ� { get; set; }

        /// <summary>
        /// �⏞1_��16�ޑ�����n��
        /// </summary>
        [Column("�⏞1_��16�ޑ�����n��")]
        public Decimal? �⏞1_��16�ޑ�����n�� { get; set; }

        /// <summary>
        /// �⏞2_�⏞�����R�[�h
        /// </summary>
        [Column("�⏞2_�⏞�����R�[�h")]
        public Decimal? �⏞2_�⏞�����R�[�h { get; set; }

        /// <summary>
        /// �⏞2_�⏞��������
        /// </summary>
        [Column("�⏞2_�⏞��������")]
        public Decimal? �⏞2_�⏞�������� { get; set; }

        /// <summary>
        /// �⏞2_�g�����v����ː�
        /// </summary>
        [Column("�⏞2_�g�����v����ː�")]
        public Decimal? �⏞2_�g�����v����ː� { get; set; }

        /// <summary>
        /// �⏞2_���󉄌ː�
        /// </summary>
        [Column("�⏞2_���󉄌ː�")]
        public Decimal? �⏞2_���󉄌ː� { get; set; }

        /// <summary>
        /// �⏞2_�g�����v����ʐ�
        /// </summary>
        [Column("�⏞2_�g�����v����ʐ�")]
        public Decimal? �⏞2_�g�����v����ʐ� { get; set; }

        /// <summary>
        /// �⏞2_�g�����v����n��
        /// </summary>
        [Column("�⏞2_�g�����v����n��")]
        public Decimal? �⏞2_�g�����v����n�� { get; set; }

        /// <summary>
        /// �⏞2_�g�����v�������
        /// </summary>
        [Column("�⏞2_�g�����v�������")]
        public Decimal? �⏞2_�g�����v������� { get; set; }

        /// <summary>
        /// �⏞2_�g�����v���ϋ��z
        /// </summary>
        [Column("�⏞2_�g�����v���ϋ��z")]
        public Decimal? �⏞2_�g�����v���ϋ��z { get; set; }

        /// <summary>
        /// �⏞2_�g�����v����ϊ|��
        /// </summary>
        [Column("�⏞2_�g�����v����ϊ|��")]
        public Decimal? �⏞2_�g�����v����ϊ|�� { get; set; }

        /// <summary>
        /// �⏞2_�g�����v���ϊ|��
        /// </summary>
        [Column("�⏞2_�g�����v���ϊ|��")]
        public Decimal? �⏞2_�g�����v���ϊ|�� { get; set; }

        /// <summary>
        /// �⏞2_�g�����v��t�a�������ϊz
        /// </summary>
        [Column("�⏞2_�g�����v��t�a�������ϊz")]
        public Decimal? �⏞2_�g�����v��t�a�������ϊz { get; set; }

        /// <summary>
        /// �⏞2_�g�����v�����a�������ϊz
        /// </summary>
        [Column("�⏞2_�g�����v�����a�������ϊz")]
        public Decimal? �⏞2_�g�����v�����a�������ϊz { get; set; }

        /// <summary>
        /// �⏞2_�g�����v�ی����z
        /// </summary>
        [Column("�⏞2_�g�����v�ی����z")]
        public Decimal? �⏞2_�g�����v�ی����z { get; set; }

        /// <summary>
        /// �⏞2_�g�����ی������z
        /// </summary>
        [Column("�⏞2_�g�����ی������z")]
        public Decimal? �⏞2_�g�����ی������z { get; set; }

        /// <summary>
        /// �⏞2_�ی���
        /// </summary>
        [Column("�⏞2_�ی���")]
        public Decimal? �⏞2_�ی��� { get; set; }

        /// <summary>
        /// �⏞2_����1�ވ���ʐ�
        /// </summary>
        [Column("�⏞2_����1�ވ���ʐ�")]
        public Decimal? �⏞2_����1�ވ���ʐ� { get; set; }

        /// <summary>
        /// �⏞2_����1�ޑ�����n��
        /// </summary>
        [Column("�⏞2_����1�ޑ�����n��")]
        public Decimal? �⏞2_����1�ޑ�����n�� { get; set; }

        /// <summary>
        /// �⏞2_����2�ވ���ʐ�
        /// </summary>
        [Column("�⏞2_����2�ވ���ʐ�")]
        public Decimal? �⏞2_����2�ވ���ʐ� { get; set; }

        /// <summary>
        /// �⏞2_����2�ޑ�����n��
        /// </summary>
        [Column("�⏞2_����2�ޑ�����n��")]
        public Decimal? �⏞2_����2�ޑ�����n�� { get; set; }

        /// <summary>
        /// �⏞2_����3�ވ���ʐ�
        /// </summary>
        [Column("�⏞2_����3�ވ���ʐ�")]
        public Decimal? �⏞2_����3�ވ���ʐ� { get; set; }

        /// <summary>
        /// �⏞2_����3�ޑ�����n��
        /// </summary>
        [Column("�⏞2_����3�ޑ�����n��")]
        public Decimal? �⏞2_����3�ޑ�����n�� { get; set; }

        /// <summary>
        /// �⏞2_����4�ވ���ʐ�
        /// </summary>
        [Column("�⏞2_����4�ވ���ʐ�")]
        public Decimal? �⏞2_����4�ވ���ʐ� { get; set; }

        /// <summary>
        /// �⏞2_����4�ޑ�����n��
        /// </summary>
        [Column("�⏞2_����4�ޑ�����n��")]
        public Decimal? �⏞2_����4�ޑ�����n�� { get; set; }

        /// <summary>
        /// �⏞2_����5�ވ���ʐ�
        /// </summary>
        [Column("�⏞2_����5�ވ���ʐ�")]
        public Decimal? �⏞2_����5�ވ���ʐ� { get; set; }

        /// <summary>
        /// �⏞2_����5�ޑ�����n��
        /// </summary>
        [Column("�⏞2_����5�ޑ�����n��")]
        public Decimal? �⏞2_����5�ޑ�����n�� { get; set; }

        /// <summary>
        /// �⏞2_����6�ވ���ʐ�
        /// </summary>
        [Column("�⏞2_����6�ވ���ʐ�")]
        public Decimal? �⏞2_����6�ވ���ʐ� { get; set; }

        /// <summary>
        /// �⏞2_����6�ޑ�����n��
        /// </summary>
        [Column("�⏞2_����6�ޑ�����n��")]
        public Decimal? �⏞2_����6�ޑ�����n�� { get; set; }

        /// <summary>
        /// �⏞2_����1�ވ���ʐ�
        /// </summary>
        [Column("�⏞2_����1�ވ���ʐ�")]
        public Decimal? �⏞2_����1�ވ���ʐ� { get; set; }

        /// <summary>
        /// �⏞2_����1�ޑ�����n��
        /// </summary>
        [Column("�⏞2_����1�ޑ�����n��")]
        public Decimal? �⏞2_����1�ޑ�����n�� { get; set; }

        /// <summary>
        /// �⏞2_��1�ވ���ʐ�
        /// </summary>
        [Column("�⏞2_��1�ވ���ʐ�")]
        public Decimal? �⏞2_��1�ވ���ʐ� { get; set; }

        /// <summary>
        /// �⏞2_��1�ޑ�����n��
        /// </summary>
        [Column("�⏞2_��1�ޑ�����n��")]
        public Decimal? �⏞2_��1�ޑ�����n�� { get; set; }

        /// <summary>
        /// �⏞2_��5�ވ���ʐ�
        /// </summary>
        [Column("�⏞2_��5�ވ���ʐ�")]
        public Decimal? �⏞2_��5�ވ���ʐ� { get; set; }

        /// <summary>
        /// �⏞2_��5�ޑ�����n��
        /// </summary>
        [Column("�⏞2_��5�ޑ�����n��")]
        public Decimal? �⏞2_��5�ޑ�����n�� { get; set; }

        /// <summary>
        /// �⏞2_��9�ވ���ʐ�
        /// </summary>
        [Column("�⏞2_��9�ވ���ʐ�")]
        public Decimal? �⏞2_��9�ވ���ʐ� { get; set; }

        /// <summary>
        /// �⏞2_��9�ޑ�����n��
        /// </summary>
        [Column("�⏞2_��9�ޑ�����n��")]
        public Decimal? �⏞2_��9�ޑ�����n�� { get; set; }

        /// <summary>
        /// �⏞2_��12�ވ���ʐ�
        /// </summary>
        [Column("�⏞2_��12�ވ���ʐ�")]
        public Decimal? �⏞2_��12�ވ���ʐ� { get; set; }

        /// <summary>
        /// �⏞2_��12�ޑ�����n��
        /// </summary>
        [Column("�⏞2_��12�ޑ�����n��")]
        public Decimal? �⏞2_��12�ޑ�����n�� { get; set; }

        /// <summary>
        /// �⏞2_��15�ވ���ʐ�
        /// </summary>
        [Column("�⏞2_��15�ވ���ʐ�")]
        public Decimal? �⏞2_��15�ވ���ʐ� { get; set; }

        /// <summary>
        /// �⏞2_��15�ޑ�����n��
        /// </summary>
        [Column("�⏞2_��15�ޑ�����n��")]
        public Decimal? �⏞2_��15�ޑ�����n�� { get; set; }

        /// <summary>
        /// �⏞2_��42�ވ���ʐ�
        /// </summary>
        [Column("�⏞2_��42�ވ���ʐ�")]
        public Decimal? �⏞2_��42�ވ���ʐ� { get; set; }

        /// <summary>
        /// �⏞2_��42�ޑ�����n��
        /// </summary>
        [Column("�⏞2_��42�ޑ�����n��")]
        public Decimal? �⏞2_��42�ޑ�����n�� { get; set; }

        /// <summary>
        /// �⏞2_��6�ވ���ʐ�
        /// </summary>
        [Column("�⏞2_��6�ވ���ʐ�")]
        public Decimal? �⏞2_��6�ވ���ʐ� { get; set; }

        /// <summary>
        /// �⏞2_��6�ޑ�����n��
        /// </summary>
        [Column("�⏞2_��6�ޑ�����n��")]
        public Decimal? �⏞2_��6�ޑ�����n�� { get; set; }

        /// <summary>
        /// �⏞2_��16�ވ���ʐ�
        /// </summary>
        [Column("�⏞2_��16�ވ���ʐ�")]
        public Decimal? �⏞2_��16�ވ���ʐ� { get; set; }

        /// <summary>
        /// �⏞2_��16�ޑ�����n��
        /// </summary>
        [Column("�⏞2_��16�ޑ�����n��")]
        public Decimal? �⏞2_��16�ޑ�����n�� { get; set; }

        /// <summary>
        /// �⏞3_�⏞�����R�[�h
        /// </summary>
        [Column("�⏞3_�⏞�����R�[�h")]
        public Decimal? �⏞3_�⏞�����R�[�h { get; set; }

        /// <summary>
        /// �⏞3_�⏞��������
        /// </summary>
        [Column("�⏞3_�⏞��������")]
        public Decimal? �⏞3_�⏞�������� { get; set; }

        /// <summary>
        /// �⏞3_�g�����v����ː�
        /// </summary>
        [Column("�⏞3_�g�����v����ː�")]
        public Decimal? �⏞3_�g�����v����ː� { get; set; }

        /// <summary>
        /// �⏞3_���󉄌ː�
        /// </summary>
        [Column("�⏞3_���󉄌ː�")]
        public Decimal? �⏞3_���󉄌ː� { get; set; }

        /// <summary>
        /// �⏞3_�g�����v����ʐ�
        /// </summary>
        [Column("�⏞3_�g�����v����ʐ�")]
        public Decimal? �⏞3_�g�����v����ʐ� { get; set; }

        /// <summary>
        /// �⏞3_�g�����v����n��
        /// </summary>
        [Column("�⏞3_�g�����v����n��")]
        public Decimal? �⏞3_�g�����v����n�� { get; set; }

        /// <summary>
        /// �⏞3_�g�����v�������
        /// </summary>
        [Column("�⏞3_�g�����v�������")]
        public Decimal? �⏞3_�g�����v������� { get; set; }

        /// <summary>
        /// �⏞3_�g�����v���ϋ��z
        /// </summary>
        [Column("�⏞3_�g�����v���ϋ��z")]
        public Decimal? �⏞3_�g�����v���ϋ��z { get; set; }

        /// <summary>
        /// �⏞3_�g�����v����ϊ|��
        /// </summary>
        [Column("�⏞3_�g�����v����ϊ|��")]
        public Decimal? �⏞3_�g�����v����ϊ|�� { get; set; }

        /// <summary>
        /// �⏞3_�g�����v���ϊ|��
        /// </summary>
        [Column("�⏞3_�g�����v���ϊ|��")]
        public Decimal? �⏞3_�g�����v���ϊ|�� { get; set; }

        /// <summary>
        /// �⏞3_�g�����v��t�a�������ϊz
        /// </summary>
        [Column("�⏞3_�g�����v��t�a�������ϊz")]
        public Decimal? �⏞3_�g�����v��t�a�������ϊz { get; set; }

        /// <summary>
        /// �⏞3_�g�����v�����a�������ϊz
        /// </summary>
        [Column("�⏞3_�g�����v�����a�������ϊz")]
        public Decimal? �⏞3_�g�����v�����a�������ϊz { get; set; }

        /// <summary>
        /// �⏞3_�g�����v�ی����z
        /// </summary>
        [Column("�⏞3_�g�����v�ی����z")]
        public Decimal? �⏞3_�g�����v�ی����z { get; set; }

        /// <summary>
        /// �⏞3_�g�����ی������z
        /// </summary>
        [Column("�⏞3_�g�����ی������z")]
        public Decimal? �⏞3_�g�����ی������z { get; set; }

        /// <summary>
        /// �⏞3_�ی���
        /// </summary>
        [Column("�⏞3_�ی���")]
        public Decimal? �⏞3_�ی��� { get; set; }

        /// <summary>
        /// �⏞3_����1�ވ���ʐ�
        /// </summary>
        [Column("�⏞3_����1�ވ���ʐ�")]
        public Decimal? �⏞3_����1�ވ���ʐ� { get; set; }

        /// <summary>
        /// �⏞3_����1�ޑ�����n��
        /// </summary>
        [Column("�⏞3_����1�ޑ�����n��")]
        public Decimal? �⏞3_����1�ޑ�����n�� { get; set; }

        /// <summary>
        /// �⏞3_����2�ވ���ʐ�
        /// </summary>
        [Column("�⏞3_����2�ވ���ʐ�")]
        public Decimal? �⏞3_����2�ވ���ʐ� { get; set; }

        /// <summary>
        /// �⏞3_����2�ޑ�����n��
        /// </summary>
        [Column("�⏞3_����2�ޑ�����n��")]
        public Decimal? �⏞3_����2�ޑ�����n�� { get; set; }

        /// <summary>
        /// �⏞3_����3�ވ���ʐ�
        /// </summary>
        [Column("�⏞3_����3�ވ���ʐ�")]
        public Decimal? �⏞3_����3�ވ���ʐ� { get; set; }

        /// <summary>
        /// �⏞3_����3�ޑ�����n��
        /// </summary>
        [Column("�⏞3_����3�ޑ�����n��")]
        public Decimal? �⏞3_����3�ޑ�����n�� { get; set; }

        /// <summary>
        /// �⏞3_����4�ވ���ʐ�
        /// </summary>
        [Column("�⏞3_����4�ވ���ʐ�")]
        public Decimal? �⏞3_����4�ވ���ʐ� { get; set; }

        /// <summary>
        /// �⏞3_����4�ޑ�����n��
        /// </summary>
        [Column("�⏞3_����4�ޑ�����n��")]
        public Decimal? �⏞3_����4�ޑ�����n�� { get; set; }

        /// <summary>
        /// �⏞3_����5�ވ���ʐ�
        /// </summary>
        [Column("�⏞3_����5�ވ���ʐ�")]
        public Decimal? �⏞3_����5�ވ���ʐ� { get; set; }

        /// <summary>
        /// �⏞3_����5�ޑ�����n��
        /// </summary>
        [Column("�⏞3_����5�ޑ�����n��")]
        public Decimal? �⏞3_����5�ޑ�����n�� { get; set; }

        /// <summary>
        /// �⏞3_����6�ވ���ʐ�
        /// </summary>
        [Column("�⏞3_����6�ވ���ʐ�")]
        public Decimal? �⏞3_����6�ވ���ʐ� { get; set; }

        /// <summary>
        /// �⏞3_����1�ވ���ʐ�
        /// </summary>
        [Column("�⏞3_����1�ވ���ʐ�")]
        public Decimal? �⏞3_����1�ވ���ʐ� { get; set; }

        /// <summary>
        /// �⏞3_����1�ޑ�����n��
        /// </summary>
        [Column("�⏞3_����1�ޑ�����n��")]
        public Decimal? �⏞3_����1�ޑ�����n�� { get; set; }

        /// <summary>
        /// �⏞3_����6�ޑ�����n��
        /// </summary>
        [Column("�⏞3_����6�ޑ�����n��")]
        public Decimal? �⏞3_����6�ޑ�����n�� { get; set; }

        /// <summary>
        /// �⏞3_��1�ވ���ʐ�
        /// </summary>
        [Column("�⏞3_��1�ވ���ʐ�")]
        public Decimal? �⏞3_��1�ވ���ʐ� { get; set; }

        /// <summary>
        /// �⏞3_��1�ޑ�����n��
        /// </summary>
        [Column("�⏞3_��1�ޑ�����n��")]
        public Decimal? �⏞3_��1�ޑ�����n�� { get; set; }

        /// <summary>
        /// �⏞3_��5�ވ���ʐ�
        /// </summary>
        [Column("�⏞3_��5�ވ���ʐ�")]
        public Decimal? �⏞3_��5�ވ���ʐ� { get; set; }

        /// <summary>
        /// �⏞3_��5�ޑ�����n��
        /// </summary>
        [Column("�⏞3_��5�ޑ�����n��")]
        public Decimal? �⏞3_��5�ޑ�����n�� { get; set; }

        /// <summary>
        /// �⏞3_��9�ވ���ʐ�
        /// </summary>
        [Column("�⏞3_��9�ވ���ʐ�")]
        public Decimal? �⏞3_��9�ވ���ʐ� { get; set; }

        /// <summary>
        /// �⏞3_��9�ޑ�����n��
        /// </summary>
        [Column("�⏞3_��9�ޑ�����n��")]
        public Decimal? �⏞3_��9�ޑ�����n�� { get; set; }

        /// <summary>
        /// �⏞3_��12�ވ���ʐ�
        /// </summary>
        [Column("�⏞3_��12�ވ���ʐ�")]
        public Decimal? �⏞3_��12�ވ���ʐ� { get; set; }

        /// <summary>
        /// �⏞3_��12�ޑ�����n��
        /// </summary>
        [Column("�⏞3_��12�ޑ�����n��")]
        public Decimal? �⏞3_��12�ޑ�����n�� { get; set; }

        /// <summary>
        /// �⏞3_��15�ވ���ʐ�
        /// </summary>
        [Column("�⏞3_��15�ވ���ʐ�")]
        public Decimal? �⏞3_��15�ވ���ʐ� { get; set; }

        /// <summary>
        /// �⏞3_��15�ޑ�����n��
        /// </summary>
        [Column("�⏞3_��15�ޑ�����n��")]
        public Decimal? �⏞3_��15�ޑ�����n�� { get; set; }

        /// <summary>
        /// �⏞3_��42�ވ���ʐ�
        /// </summary>
        [Column("�⏞3_��42�ވ���ʐ�")]
        public Decimal? �⏞3_��42�ވ���ʐ� { get; set; }

        /// <summary>
        /// �⏞3_��42�ޑ�����n��
        /// </summary>
        [Column("�⏞3_��42�ޑ�����n��")]
        public Decimal? �⏞3_��42�ޑ�����n�� { get; set; }

        /// <summary>
        /// �⏞3_��6�ވ���ʐ�
        /// </summary>
        [Column("�⏞3_��6�ވ���ʐ�")]
        public Decimal? �⏞3_��6�ވ���ʐ� { get; set; }

        /// <summary>
        /// �⏞3_��6�ޑ�����n��
        /// </summary>
        [Column("�⏞3_��6�ޑ�����n��")]
        public Decimal? �⏞3_��6�ޑ�����n�� { get; set; }

        /// <summary>
        /// �⏞3_��16�ވ���ʐ�
        /// </summary>
        [Column("�⏞3_��16�ވ���ʐ�")]
        public Decimal? �⏞3_��16�ވ���ʐ� { get; set; }

        /// <summary>
        /// �⏞3_��16�ޑ�����n��
        /// </summary>
        [Column("�⏞3_��16�ޑ�����n��")]
        public Decimal? �⏞3_��16�ޑ�����n�� { get; set; }

        /// <summary>
        /// �⍇_�g�����v����ː�
        /// </summary>
        [Column("�⍇_�g�����v����ː�")]
        public Decimal? �⍇_�g�����v����ː� { get; set; }

        /// <summary>
        /// �⍇_���󉄌ː�
        /// </summary>
        [Column("�⍇_���󉄌ː�")]
        public Decimal? �⍇_���󉄌ː� { get; set; }

        /// <summary>
        /// �⍇_�g�����v����ʐ�
        /// </summary>
        [Column("�⍇_�g�����v����ʐ�")]
        public Decimal? �⍇_�g�����v����ʐ� { get; set; }

        /// <summary>
        /// �⍇_�g�����v����n��
        /// </summary>
        [Column("�⍇_�g�����v����n��")]
        public Decimal? �⍇_�g�����v����n�� { get; set; }

        /// <summary>
        /// �⍇_�g�����v�������
        /// </summary>
        [Column("�⍇_�g�����v�������")]
        public Decimal? �⍇_�g�����v������� { get; set; }

        /// <summary>
        /// �⍇_�g�����v���ϋ��z
        /// </summary>
        [Column("�⍇_�g�����v���ϋ��z")]
        public Decimal? �⍇_�g�����v���ϋ��z { get; set; }

        /// <summary>
        /// �⍇_�g�����v����ϊ|��
        /// </summary>
        [Column("�⍇_�g�����v����ϊ|��")]
        public Decimal? �⍇_�g�����v����ϊ|�� { get; set; }

        /// <summary>
        /// �⍇_�g�����v���ϊ|��
        /// </summary>
        [Column("�⍇_�g�����v���ϊ|��")]
        public Decimal? �⍇_�g�����v���ϊ|�� { get; set; }

        /// <summary>
        /// �⍇_�g�����v��t�a�������ϊz
        /// </summary>
        [Column("�⍇_�g�����v��t�a�������ϊz")]
        public Decimal? �⍇_�g�����v��t�a�������ϊz { get; set; }

        /// <summary>
        /// �⍇_�g�����v�����a�������ϊz
        /// </summary>
        [Column("�⍇_�g�����v�����a�������ϊz")]
        public Decimal? �⍇_�g�����v�����a�������ϊz { get; set; }

        /// <summary>
        /// �⍇_�g�����v�ی����z
        /// </summary>
        [Column("�⍇_�g�����v�ی����z")]
        public Decimal? �⍇_�g�����v�ی����z { get; set; }

        /// <summary>
        /// �⍇_�g�����ی������z
        /// </summary>
        [Column("�⍇_�g�����ی������z")]
        public Decimal? �⍇_�g�����ی������z { get; set; }

        /// <summary>
        /// �⍇_�ی���
        /// </summary>
        [Column("�⍇_�ی���")]
        public Decimal? �⍇_�ی��� { get; set; }

        /// <summary>
        /// �⍇_����1�ވ���ʐ�
        /// </summary>
        [Column("�⍇_����1�ވ���ʐ�")]
        public Decimal? �⍇_����1�ވ���ʐ� { get; set; }

        /// <summary>
        /// �⍇_����1�ޑ�����n��
        /// </summary>
        [Column("�⍇_����1�ޑ�����n��")]
        public Decimal? �⍇_����1�ޑ�����n�� { get; set; }

        /// <summary>
        /// �⍇_����2�ވ���ʐ�
        /// </summary>
        [Column("�⍇_����2�ވ���ʐ�")]
        public Decimal? �⍇_����2�ވ���ʐ� { get; set; }

        /// <summary>
        /// �⍇_����2�ޑ�����n��
        /// </summary>
        [Column("�⍇_����2�ޑ�����n��")]
        public Decimal? �⍇_����2�ޑ�����n�� { get; set; }

        /// <summary>
        /// �⍇_����3�ވ���ʐ�
        /// </summary>
        [Column("�⍇_����3�ވ���ʐ�")]
        public Decimal? �⍇_����3�ވ���ʐ� { get; set; }

        /// <summary>
        /// �⍇_����3�ޑ�����n��
        /// </summary>
        [Column("�⍇_����3�ޑ�����n��")]
        public Decimal? �⍇_����3�ޑ�����n�� { get; set; }

        /// <summary>
        /// �⍇_����4�ވ���ʐ�
        /// </summary>
        [Column("�⍇_����4�ވ���ʐ�")]
        public Decimal? �⍇_����4�ވ���ʐ� { get; set; }

        /// <summary>
        /// �⍇_����4�ޑ�����n��
        /// </summary>
        [Column("�⍇_����4�ޑ�����n��")]
        public Decimal? �⍇_����4�ޑ�����n�� { get; set; }

        /// <summary>
        /// �⍇_����5�ވ���ʐ�
        /// </summary>
        [Column("�⍇_����5�ވ���ʐ�")]
        public Decimal? �⍇_����5�ވ���ʐ� { get; set; }

        /// <summary>
        /// �⍇_����5�ޑ�����n��
        /// </summary>
        [Column("�⍇_����5�ޑ�����n��")]
        public Decimal? �⍇_����5�ޑ�����n�� { get; set; }

        /// <summary>
        /// �⍇_����6�ވ���ʐ�
        /// </summary>
        [Column("�⍇_����6�ވ���ʐ�")]
        public Decimal? �⍇_����6�ވ���ʐ� { get; set; }

        /// <summary>
        /// �⍇_����6�ޑ�����n��
        /// </summary>
        [Column("�⍇_����6�ޑ�����n��")]
        public Decimal? �⍇_����6�ޑ�����n�� { get; set; }

        /// <summary>
        /// �⍇_����1�ވ���ʐ�
        /// </summary>
        [Column("�⍇_����1�ވ���ʐ�")]
        public Decimal? �⍇_����1�ވ���ʐ� { get; set; }

        /// <summary>
        /// �⍇_����1�ޑ�����n��
        /// </summary>
        [Column("�⍇_����1�ޑ�����n��")]
        public Decimal? �⍇_����1�ޑ�����n�� { get; set; }

        /// <summary>
        /// �⍇_��1�ވ���ʐ�
        /// </summary>
        [Column("�⍇_��1�ވ���ʐ�")]
        public Decimal? �⍇_��1�ވ���ʐ� { get; set; }

        /// <summary>
        /// �⍇_��1�ޑ�����n��
        /// </summary>
        [Column("�⍇_��1�ޑ�����n��")]
        public Decimal? �⍇_��1�ޑ�����n�� { get; set; }

        /// <summary>
        /// �⍇_��5�ވ���ʐ�
        /// </summary>
        [Column("�⍇_��5�ވ���ʐ�")]
        public Decimal? �⍇_��5�ވ���ʐ� { get; set; }

        /// <summary>
        /// �⍇_��5�ޑ�����n��
        /// </summary>
        [Column("�⍇_��5�ޑ�����n��")]
        public Decimal? �⍇_��5�ޑ�����n�� { get; set; }

        /// <summary>
        /// �⍇_��9�ވ���ʐ�
        /// </summary>
        [Column("�⍇_��9�ވ���ʐ�")]
        public Decimal? �⍇_��9�ވ���ʐ� { get; set; }

        /// <summary>
        /// �⍇_��9�ޑ�����n��
        /// </summary>
        [Column("�⍇_��9�ޑ�����n��")]
        public Decimal? �⍇_��9�ޑ�����n�� { get; set; }

        /// <summary>
        /// �⍇_��12�ވ���ʐ�
        /// </summary>
        [Column("�⍇_��12�ވ���ʐ�")]
        public Decimal? �⍇_��12�ވ���ʐ� { get; set; }

        /// <summary>
        /// �⍇_��12�ޑ�����n��
        /// </summary>
        [Column("�⍇_��12�ޑ�����n��")]
        public Decimal? �⍇_��12�ޑ�����n�� { get; set; }

        /// <summary>
        /// �⍇_��15�ވ���ʐ�
        /// </summary>
        [Column("�⍇_��15�ވ���ʐ�")]
        public Decimal? �⍇_��15�ވ���ʐ� { get; set; }

        /// <summary>
        /// �⍇_��15�ޑ�����n��
        /// </summary>
        [Column("�⍇_��15�ޑ�����n��")]
        public Decimal? �⍇_��15�ޑ�����n�� { get; set; }

        /// <summary>
        /// �⍇_��42�ވ���ʐ�
        /// </summary>
        [Column("�⍇_��42�ވ���ʐ�")]
        public Decimal? �⍇_��42�ވ���ʐ� { get; set; }

        /// <summary>
        /// �⍇_��42�ޑ�����n��
        /// </summary>
        [Column("�⍇_��42�ޑ�����n��")]
        public Decimal? �⍇_��42�ޑ�����n�� { get; set; }

        /// <summary>
        /// �⍇_��6�ވ���ʐ�
        /// </summary>
        [Column("�⍇_��6�ވ���ʐ�")]
        public Decimal? �⍇_��6�ވ���ʐ� { get; set; }

        /// <summary>
        /// �⍇_��6�ޑ�����n��
        /// </summary>
        [Column("�⍇_��6�ޑ�����n��")]
        public Decimal? �⍇_��6�ޑ�����n�� { get; set; }

        /// <summary>
        /// �⍇_��16�ވ���ʐ�
        /// </summary>
        [Column("�⍇_��16�ވ���ʐ�")]
        public Decimal? �⍇_��16�ވ���ʐ� { get; set; }

        /// <summary>
        /// �⍇_��16�ޑ�����n��
        /// </summary>
        [Column("�⍇_��16�ޑ�����n��")]
        public Decimal? �⍇_��16�ޑ�����n�� { get; set; }

        /// <summary>
        /// �o�^����
        /// </summary>
        [Column("�o�^����")]
        public DateTime? �o�^���� { get; set; }

        /// <summary>
        /// �o�^���[�Uid
        /// </summary>
        [Column("�o�^���[�Uid")]
        public string �o�^���[�Uid { get; set; }
    }
}
