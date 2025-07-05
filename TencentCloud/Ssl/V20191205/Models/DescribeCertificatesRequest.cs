/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
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
        /// Pagination offset, starting from 0. default is 0.
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// Number of items per page. default is 10. maximum value is 1000; values exceeding 1000 will be treated as 1000.
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// Search keywords, supporting fuzzy match by certificate id, remark name, and certificate domain name.
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
        /// Default sorting is by certificate application time in descending order. Sort by expiration date if the following values are passed: DESC for descending order of certificate expiration time, ASC for ascending order.
        /// </summary>
        [JsonProperty("ExpirationSort")]
        public string ExpirationSort{ get; set; }

        /// <summary>
        /// Certificate status: 0=under review, 1=approved, 2=review failed, 3=expired, 4=dns record added, 5=enterprise certificate, pending submission, 6=order cancellation in progress, 7=canceled, 8=documents submitted, pending upload of confirmation letter, 9=certificate revocation in progress, 10=revoked, 11=reissue in progress, 12=pending upload of revocation confirmation letter, 13=free certificate pending document submission, 14=refunded, 15=certificate migration in progress.
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
        /// Whether the certificate can be hosted. Valid values: `1` for yes and `0` for no.
        /// </summary>
        [JsonProperty("Hostable")]
        public ulong? Hostable{ get; set; }

        /// <summary>
        /// Filter certificates with specified tags.
        /// </summary>
        [JsonProperty("Tags")]
        public Tags[] Tags{ get; set; }

        /// <summary>
        /// Whether to filter certificates pending issue: 1 for filtering, 0 and null for no filtering.
        /// </summary>
        [JsonProperty("IsPendingIssue")]
        public long? IsPendingIssue{ get; set; }

        /// <summary>
        /// Filter certificates by the specified certificate id, only supports certificate ids with permission.
        /// </summary>
        [JsonProperty("CertIds")]
        public string[] CertIds{ get; set; }


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
            this.SetParamSimple(map, prefix + "Hostable", this.Hostable);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "IsPendingIssue", this.IsPendingIssue);
            this.SetParamArraySimple(map, prefix + "CertIds.", this.CertIds);
        }
    }
}

