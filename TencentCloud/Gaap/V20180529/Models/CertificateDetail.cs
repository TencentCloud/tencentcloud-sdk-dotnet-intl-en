/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Gaap.V20180529.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CertificateDetail : AbstractModel
    {
        
        /// <summary>
        /// Certificate ID.
        /// </summary>
        [JsonProperty("CertificateId")]
        public string CertificateId{ get; set; }

        /// <summary>
        /// Certificate type.
        /// </summary>
        [JsonProperty("CertificateType")]
        public long? CertificateType{ get; set; }

        /// <summary>
        /// Certificate name.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CertificateAlias")]
        public string CertificateAlias{ get; set; }

        /// <summary>
        /// Certificate content.
        /// </summary>
        [JsonProperty("CertificateContent")]
        public string CertificateContent{ get; set; }

        /// <summary>
        /// Key content. This field will be returned if the certificate type is the SSL certificate.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CertificateKey")]
        public string CertificateKey{ get; set; }

        /// <summary>
        /// Creation time in the format of UNIX timestamp, indicating the number of seconds that have elapsed since January 1, 1970 (midnight in UTC/GMT).
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CreateTime")]
        public ulong? CreateTime{ get; set; }

        /// <summary>
        /// Certificate effective time in the format of UNIX timestamp, indicating the number of seconds that have elapsed since January 1, 1970 (midnight in UTC/GMT).
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BeginTime")]
        public ulong? BeginTime{ get; set; }

        /// <summary>
        /// Certificate expiration time in the format of UNIX timestamp, indicating the number of seconds that have elapsed since January 1, 1970 (midnight in UTC/GMT).
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EndTime")]
        public ulong? EndTime{ get; set; }

        /// <summary>
        /// Common name of the certificate's issuer.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IssuerCN")]
        public string IssuerCN{ get; set; }

        /// <summary>
        /// Common name of the certificate subject.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SubjectCN")]
        public string SubjectCN{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CertificateId", this.CertificateId);
            this.SetParamSimple(map, prefix + "CertificateType", this.CertificateType);
            this.SetParamSimple(map, prefix + "CertificateAlias", this.CertificateAlias);
            this.SetParamSimple(map, prefix + "CertificateContent", this.CertificateContent);
            this.SetParamSimple(map, prefix + "CertificateKey", this.CertificateKey);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "BeginTime", this.BeginTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "IssuerCN", this.IssuerCN);
            this.SetParamSimple(map, prefix + "SubjectCN", this.SubjectCN);
        }
    }
}

