using CoreLibrary.Core.Base;
using ModelLibrary.Models;

namespace BaseWeb.Areas.F00.Models.D0001
{
    /// <summary>
    /// �|�[�^��
    /// </summary>
    /// <remarks>
    /// �쐬���F2018/03/07
    /// �쐬�ҁFGon Etuun
    /// </remarks>
    [Serializable]
    public class D0001Model : CoreViewModel
    {
        /// <summary>
        /// �R���X�g���N�^
        /// </summary>
        public D0001Model()
        {
            this.VSyokuinRecords = new VSyokuin();
        }

        /// <summary>
        /// �E���}�X�^�̌�������
        /// </summary>
        public VSyokuin VSyokuinRecords { get; set; }

        /// <summary>
        ///�ŏI�p�X���[�h�X�V���b�Z�[�W �\��/��\��
        /// </summary>
        public bool PwdLabDisplay { get; set; }

        /// <summary>
        ///�O�񃍃O�C������
        /// </summary>
        public string LoginDate { get; set; }

        /// <summary>
        ///�ŏI�p�X���[�h����
        /// </summary>
        public string PwdLastUpdateYmd { get; set; }
    }
}