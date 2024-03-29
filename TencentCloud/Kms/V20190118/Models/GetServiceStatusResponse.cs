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

namespace TencentCloud.Kms.V20190118.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetServiceStatusResponse : AbstractModel
    {
        
        /// <summary>
        /// Whether the KMS service has been activated. true: activated
        /// </summary>
        [JsonProperty("ServiceEnabled")]
        public bool? ServiceEnabled{ get; set; }

        /// <summary>
        /// Service unavailability type. 0: not purchased; 1: normal; 2: suspended due to arrears; 3: resource released
        /// </summary>
        [JsonProperty("InvalidType")]
        public long? InvalidType{ get; set; }

        /// <summary>
        /// 0: Basic Edition, 1: Ultimate Edition
        /// </summary>
        [JsonProperty("UserLevel")]
        public ulong? UserLevel{ get; set; }

        /// <summary>
        /// Expiration time of the KMS Ultimate edition. It’s represented in a Unix Epoch timestamp.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ProExpireTime")]
        public ulong? ProExpireTime{ get; set; }

        /// <summary>
        /// Whether to automatically renew Ultimate Edition. 0: no, 1: yes
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ProRenewFlag")]
        public ulong? ProRenewFlag{ get; set; }

        /// <summary>
        /// Unique ID of the Ultimate Edition purchase record. If the Ultimate Edition is not activated, the returned value will be null.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ProResourceId")]
        public string ProResourceId{ get; set; }

        /// <summary>
        /// Whether to activate Managed KMS
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ExclusiveVSMEnabled")]
        public bool? ExclusiveVSMEnabled{ get; set; }

        /// <summary>
        /// Whether to activate Exclusive KMS
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ExclusiveHSMEnabled")]
        public bool? ExclusiveHSMEnabled{ get; set; }

        /// <summary>
        /// KMS subscription information.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SubscriptionInfo")]
        public string SubscriptionInfo{ get; set; }

        /// <summary>
        /// The unique request ID, which is returned for each request. RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ServiceEnabled", this.ServiceEnabled);
            this.SetParamSimple(map, prefix + "InvalidType", this.InvalidType);
            this.SetParamSimple(map, prefix + "UserLevel", this.UserLevel);
            this.SetParamSimple(map, prefix + "ProExpireTime", this.ProExpireTime);
            this.SetParamSimple(map, prefix + "ProRenewFlag", this.ProRenewFlag);
            this.SetParamSimple(map, prefix + "ProResourceId", this.ProResourceId);
            this.SetParamSimple(map, prefix + "ExclusiveVSMEnabled", this.ExclusiveVSMEnabled);
            this.SetParamSimple(map, prefix + "ExclusiveHSMEnabled", this.ExclusiveHSMEnabled);
            this.SetParamSimple(map, prefix + "SubscriptionInfo", this.SubscriptionInfo);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

