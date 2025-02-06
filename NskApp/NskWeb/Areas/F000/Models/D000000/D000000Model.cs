using CoreLibrary.Core.Base;
using ModelLibrary.Models;

namespace NskWeb.Areas.F000.Models.D000000
{
    /// <summary>
    /// �|�[�^��
    /// </summary>
    /// <remarks>
    /// �쐬���F2018/03/07
    /// �쐬�ҁFGon Etuun
    /// </remarks>
    [Serializable]
    public class D000000Model : CoreViewModel
    {
        /// <summary>
        /// �R���X�g���N�^
        /// </summary>
        public D000000Model()
        {
            this.VSyokuinRecords = new VSyokuin();
            this.D000000Info = new NSKPortalInfoModel();  // $$$$$$$$$$$$$$$$$$$
            this.D000000Info2 = new NSKPortalInfoModel();  // $$$$$$$$$$$$$$$$$$$
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

        // $$$$$$$$$$$$$$$$$$$$$
        public NSKPortalInfoModel D000000Info { get; set; }
        public NSKPortalInfoModel D000000Info2 { get; set; }
        // $$$$$$$$$$$$$$$$$$$$$
        public string wtest { get; set; }
    }
}