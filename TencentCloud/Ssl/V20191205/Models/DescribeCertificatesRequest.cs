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

namespace TencentCloud.Ssl.V20191205.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCertificatesRequest : AbstractModel
    {
        
        /// <summary>
        /// Pagination offset, starting from 0
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// Number of entries per page. Default value: `20`. Maximum value: `1000`.
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// Keyword for search, which can be a certificate ID, alias, or domain name, for example, a8xHcaIs
        /// </summary>
        [JsonProperty("SearchKey")]
        public string SearchKey{ get; set; }

        /// <summary>
        /// Certificate type. `CA`: client certificate; `SVR`: server certificate
        /// </summary>
        [JsonProperty("CertificateType")]
        public string CertificateType{ get; set; }

        /// <summary>
        /// Project ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public ulong? ProjectId{ get; set; }

        /// <summary>
        /// Sorting by expiration time. `DESC`: descending; `ASC`: ascending
        /// </summary>
        [JsonProperty("ExpirationSort")]
        public string ExpirationSort{ get; set; }

        /// <summary>
        /// Certificate status. `0`: Reviewing; `1`: Approved; `2`: Unapproved; `3`: Expired; `4`: DNS record added; `5`: Enterprise-grade certificate, pending submission; `6`: Canceling order; `7`: Canceled; `8`: Information submitted, pending confirmation letter upload; `9`: Revoking certificate; `10`: Revoked; `11`: Reissuing; `12`: Pending revocation confirmation letter upload; `13`: Pending information submission for the free certificate.
        /// </summary>
        [JsonProperty("CertificateStatus")]
        public ulong?[] CertificateStatus{ get; set; }

        /// <summary>
        /// Whether the certificate can be deployed. `1`: yes; `0`: no
        /// </summary>
        [JsonProperty("Deployable")]
        public ulong? Deployable{ get; set; }

        /// <summary>
        /// Whether to filter uploaded hosted certificates. `1`: Yes; `0`: No.
        /// </summary>
        [JsonProperty("Upload")]
        public long? Upload{ get; set; }

        /// <summary>
        /// Whether to filter renewable certificates. `1`: Yes; `0`: No.
        /// </summary>
        [JsonProperty("Renew")]
        public long? Renew{ get; set; }

        /// <summary>
        /// Filter by source. `upload`: Uploaded certificate; `buy`: Tencent Cloud certificate. If this parameter is left empty, all certificates will be queried.
        /// </summary>
        [JsonProperty("FilterSource")]
        public string FilterSource{ get; set; }

        /// <summary>
        /// Whether to filter Chinese SM certificates. `1`: Yes; `0`: No.
        /// </summary>
        [JsonProperty("IsSM")]
        public long? IsSM{ get; set; }

        /// <summary>
        /// Whether to filter expiring certificates. `1`: Yes; `0`: No.
        /// </summary>
        [JsonProperty("FilterExpiring")]
        public ulong? FilterExpiring{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "SearchKey", this.SearchKey);
            this.SetParamSimple(map, prefix + "CertificateType", this.CertificateType);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "ExpirationSort", this.ExpirationSort);
            this.SetParamArraySimple(map, prefix + "CertificateStatus.", this.CertificateStatus);
            this.SetParamSimple(map, prefix + "Deployable", this.Deployable);
            this.SetParamSimple(map, prefix + "Upload", this.Upload);
            this.SetParamSimple(map, prefix + "Renew", this.Renew);
            this.SetParamSimple(map, prefix + "FilterSource", this.FilterSource);
            this.SetParamSimple(map, prefix + "IsSM", this.IsSM);
            this.SetParamSimple(map, prefix + "FilterExpiring", this.FilterExpiring);
        }
    }
}

