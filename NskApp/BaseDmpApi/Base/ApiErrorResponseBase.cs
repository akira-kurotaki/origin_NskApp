﻿using System.Runtime.Serialization;

namespace BaseDmpApi.Base
{
    /// <summary>
    /// データ連携REST APIサービスのレスポンスの基底クラス
    /// </summary>
    [DataContract]
    public class ApiErrorResponseBase : IApiResponse
    {
        /// <summary>
        /// エラーメッセージ
        /// </summary>
        [DataMember(Name = "messages")]
        public List<Message> messages { get; set; }
    }
}
