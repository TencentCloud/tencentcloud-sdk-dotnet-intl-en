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

namespace TencentCloud.Smh.V20210712.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Instance : AbstractModel
    {
        
        /// <summary>
        /// Instance ID.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Dedicated domain name. if the instance has no dedicated domain name, this attribute is null.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// Effective time.
        /// </summary>
        [JsonProperty("EffectiveTime")]
        public string EffectiveTime{ get; set; }

        /// <summary>
        /// Expiration time. if the instance is pay-as-you-go or permanently valid, this attribute is null.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// Number of users. if the instance uses pay-as-you-go billing or has unlimited users, this attribute is null.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UserLimit")]
        public ulong? UserLimit{ get; set; }

        /// <summary>
        /// Storage capacity in Bytes. this field is of String type due to precision limitations of numeric types. this property is null for pay-as-you-go instances or instances with unlimited storage capacity.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("StorageLimit")]
        public string StorageLimit{ get; set; }

        /// <summary>
        /// Storage capacity in GB. if the instance uses pay-as-you-go billing or has unlimited storage capacity, this attribute is null.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("StorageLimitGB")]
        public ulong? StorageLimitGB{ get; set; }

        /// <summary>
        /// Is expired isolation.
        /// </summary>
        [JsonProperty("Isolated")]
        public bool? Isolated{ get; set; }

        /// <summary>
        /// Renewal flag. 0: manual renewal; 1: automatic renewal; 2: non-renewal upon expiration.
        /// </summary>
        [JsonProperty("AutoRenew")]
        public ulong? AutoRenew{ get; set; }

        /// <summary>
        /// Specifies the super administrator account. if no selection query is made for the instance-bound super administrator account or the current instance is not bound to a super administrator account, this attribute is null.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SuperAdminAccount")]
        public string SuperAdminAccount{ get; set; }

        /// <summary>
        /// In selected bucket mode, shows bucket usage.
        /// </summary>
        [JsonProperty("Bucket")]
        public string Bucket{ get; set; }

        /// <summary>
        /// Specifies the log bucket usage in selected mode.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LogBucket")]
        public string LogBucket{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "EffectiveTime", this.EffectiveTime);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "UserLimit", this.UserLimit);
            this.SetParamSimple(map, prefix + "StorageLimit", this.StorageLimit);
            this.SetParamSimple(map, prefix + "StorageLimitGB", this.StorageLimitGB);
            this.SetParamSimple(map, prefix + "Isolated", this.Isolated);
            this.SetParamSimple(map, prefix + "AutoRenew", this.AutoRenew);
            this.SetParamSimple(map, prefix + "SuperAdminAccount", this.SuperAdminAccount);
            this.SetParamSimple(map, prefix + "Bucket", this.Bucket);
            this.SetParamSimple(map, prefix + "LogBucket", this.LogBucket);
        }
    }
}

