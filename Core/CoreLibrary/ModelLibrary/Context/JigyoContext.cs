using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using ModelLibrary.Models;

namespace ModelLibrary.Context
{
    /// <summary>
    /// ���ƃV�X�e���R���e�L�X�g�N���X�x�[�X
    /// 
    /// �쐬���F
    /// �쐬�ҁF
    /// </summary>
    public class JigyoContext : ContextBase
    {
        /// <summary>
        /// �R���X�g���N�^
        /// </summary>
        /// <param name="connectionString">�ڑ�������</param>
        /// <param name="defaultSchema">�f�t�H���g�X�L�[�}</param>
        /// <param name="commandTimeout">�R���e�L�X�g����̃^�C���A�E�g�l(�b)
        /// �l�����w��A�܂��́A0�����̒l�ꍇ�A�ݒ�t�@�C������^�C���A�E�g�l���擾����</param>
        public JigyoContext(string connectionString, string defaultSchema, int commandTimeout = 0) : 
            base(connectionString, defaultSchema, commandTimeout)
        {
            ;
        }

        /// <summary>
        /// �R���X�g���N�^
        /// </summary>
        /// <param name="connectionString">�ڑ�������</param>
        /// <param name="defaultSchema">�f�t�H���g�X�L�[�}</param>
        /// <param name="userId">���[�UID</param>
        /// <param name="ipAddress">IP�A�h���X</param>
        /// <param name="commandTimeout">�R���e�L�X�g����̃^�C���A�E�g�l(�b)
        /// �l�����w��A�܂��́A0�����̒l�ꍇ�A�ݒ�t�@�C������^�C���A�E�g�l���擾����</param>
        public JigyoContext(string connectionString, string defaultSchema, string userId, string ipAddress, int commandTimeout = 0) :
            base(connectionString, defaultSchema, userId, ipAddress, commandTimeout)
        {
            ;
        }

        #region OnConfiguring
        /// <summary>
        /// ���O�o�͐ݒ�A�ڑ���ݒ�
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.ReplaceService<IModelCacheKeyFactory, DynamicModelCacheKeyFactory>();
        }
        #endregion

        /// <summary>
        /// �E���}�X�^
        /// </summary>
        public DbSet<VSyokuin> VSyokuins { get; set; }

        /// <summary>
        /// �_�Ǝҏ��
        /// </summary>
        public DbSet<VNogyosha> VNogyoshas { get; set; }

        /// <summary>
        /// �s���{���}�X�^
        /// </summary>
        public DbSet<VTodofuken> VTodofukens { get; set; }

        /// <summary>
        /// �g�����}�X�^
        /// </summary>
        public DbSet<VKumiaito> VKumiaitos { get; set; }

        /// <summary>
        /// ����M�x��
        /// </summary>
        public DbSet<VShishoNm> VShishoNms { get; set; }

        /// <summary>
        /// ����M��n��
        /// </summary>
        public DbSet<VDaichikuNm> VDaichikuNms { get; set; }

        /// <summary>
        /// ����M���n��
        /// </summary>
        public DbSet<VShochikuNm> VShochikuNms { get; set; }

        /// <summary>
        /// ����M�s����
        /// </summary>
        public DbSet<VShichosonNm> VShichosonNms { get; set; }

        /// <summary>
        /// ��ʋ@�\�����}�X�^
        /// </summary>
        public DbSet<VScreenKinoKengen> VScreenKinoKengens { get; set; }

        /// <summary>
        /// ��ʑ��쌠���}�X�^
        /// </summary>
        public DbSet<VScreenSosaKengen> VScreenSosaKengens { get; set; }

        /// <summary>
        /// �x���O���[�v�}�X�^
        /// </summary>
        public DbSet<VShishoGroup> VShishoGroups { get; set; }

        /// <summary>
        /// �x���O���[�v�ڍ׃}�X�^
        /// </summary>
        public DbSet<VShishoGroupShosai> VShishoGroupShosais { get; set; }

        /// <summary>
        /// �ėp�敪�}�X�^
        /// </summary>
        public DbSet<VHanyokubun> VHanyokubuns { get; set; }

        /// <summary>
        /// ���[����
        /// </summary>
        public DbSet<TReportJouken> TReportJoukens { get; set; }
    }
}