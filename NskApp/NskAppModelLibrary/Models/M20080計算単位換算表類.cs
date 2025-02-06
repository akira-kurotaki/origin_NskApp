using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NskAppModelLibrary.Models
{
    /// <summary>
    /// m_20080_�v�Z�P�ʊ��Z�\��
    /// </summary>
    [Serializable]
    [Table("m_20080_�v�Z�P�ʊ��Z�\��")]
    [Keyless]
    public class M20080�v�Z�P�ʊ��Z�\�� : ModelBase
    {
        /// <summary>
        /// ���ϖړI�R�[�h
        /// </summary>
        [Column("���ϖړI�R�[�h")]
        [StringLength(2)]
        public string ���ϖړI�R�[�h { get; set; }

        /// <summary>
        /// �ދ敪
        /// </summary>
        [Column("�ދ敪")]
        [StringLength(2)]
        public string �ދ敪 { get; set; }

        /// <summary>
        /// �v�Z�P�ʗދ敪
        /// </summary>
        [Column("�v�Z�P�ʗދ敪")]
        [StringLength(2)]
        public string �v�Z�P�ʗދ敪 { get; set; }

        /// <summary>
        /// �v�Z�P�ʗޖ���
        /// </summary>
        [Column("�v�Z�P�ʗޖ���")]
        [StringLength(20)]
        public string �v�Z�P�ʗޖ��� { get; set; }

        /// <summary>
        /// �\�[�g�L�[
        /// </summary>
        [Column("�\�[�g�L�[")]
        public short? �\�[�g�L�[ { get; set; }

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

        /// <summary>
        /// �X�V����
        /// </summary>
        [Column("�X�V����")]
        public DateTime? �X�V���� { get; set; }

        /// <summary>
        /// �X�V���[�Uid
        /// </summary>
        [Column("�X�V���[�Uid")]
        public string �X�V���[�Uid { get; set; }
    }
}
