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

namespace TencentCloud.Quota.V20241204.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UserQuota : AbstractModel
    {
        
        /// <summary>
        /// uin
        /// </summary>
        [JsonProperty("MemberUin")]
        public long? MemberUin{ get; set; }

        /// <summary>
        /// Account nickname
        /// </summary>
        [JsonProperty("MemberName")]
        public string MemberName{ get; set; }

        /// <summary>
        /// Quota Instance ID
        /// </summary>
        [JsonProperty("QuotaInstanceId")]
        public string QuotaInstanceId{ get; set; }

        /// <summary>
        /// Quota ID
        /// </summary>
        [JsonProperty("QuotaId")]
        public long? QuotaId{ get; set; }

        /// <summary>
        /// quota name
        /// </summary>
        [JsonProperty("QuotaName")]
        public string QuotaName{ get; set; }

        /// <summary>
        /// Product name
        /// </summary>
        [JsonProperty("ProductName")]
        public string ProductName{ get; set; }

        /// <summary>
        /// Quota unit
        /// </summary>
        [JsonProperty("QuotaUnit")]
        public string QuotaUnit{ get; set; }

        /// <summary>
        /// Quota application method, enumeration value: 1: Can apply, 2: Ticket application, 3: Cannot apply.
        /// </summary>
        [JsonProperty("ApplyType")]
        public long? ApplyType{ get; set; }

        /// <summary>
        /// User Total Quota
        /// </summary>
        [JsonProperty("TotalQuota")]
        public long? TotalQuota{ get; set; }

        /// <summary>
        /// Total usage of user quota
        /// </summary>
        [JsonProperty("TotalUsage")]
        public long? TotalUsage{ get; set; }

        /// <summary>
        /// Quota description
        /// </summary>
        [JsonProperty("QuotaDescription")]
        public string QuotaDescription{ get; set; }

        /// <summary>
        /// Quota Dimension Value
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("QuotaDimensions")]
        public QuotaDimension[] QuotaDimensions{ get; set; }

        /// <summary>
        /// Status 5 Pending Approval
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MemberUin", this.MemberUin);
            this.SetParamSimple(map, prefix + "MemberName", this.MemberName);
            this.SetParamSimple(map, prefix + "QuotaInstanceId", this.QuotaInstanceId);
            this.SetParamSimple(map, prefix + "QuotaId", this.QuotaId);
            this.SetParamSimple(map, prefix + "QuotaName", this.QuotaName);
            this.SetParamSimple(map, prefix + "ProductName", this.ProductName);
            this.SetParamSimple(map, prefix + "QuotaUnit", this.QuotaUnit);
            this.SetParamSimple(map, prefix + "ApplyType", this.ApplyType);
            this.SetParamSimple(map, prefix + "TotalQuota", this.TotalQuota);
            this.SetParamSimple(map, prefix + "TotalUsage", this.TotalUsage);
            this.SetParamSimple(map, prefix + "QuotaDescription", this.QuotaDescription);
            this.SetParamArrayObj(map, prefix + "QuotaDimensions.", this.QuotaDimensions);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

