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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribePurchaseStateInfoResponse : AbstractModel
    {
        
        /// <summary>
        /// Valid values: `0` (available for trial and purchase); `1` (available for purchase only after failed trial review or trial expiration); `2` (trial effective); `3` (Pro Edition effective); `4` (Pro Edition expired).
        /// </summary>
        [JsonProperty("State")]
        public long? State{ get; set; }

        /// <summary>
        /// Total number of cores
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CoresCnt")]
        public ulong? CoresCnt{ get; set; }

        /// <summary>
        /// Number of purchased cores
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AuthorizedCoresCnt")]
        public ulong? AuthorizedCoresCnt{ get; set; }

        /// <summary>
        /// Number of images
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ImageCnt")]
        public ulong? ImageCnt{ get; set; }

        /// <summary>
        /// Number of licensed images
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AuthorizedImageCnt")]
        public ulong? AuthorizedImageCnt{ get; set; }

        /// <summary>
        /// Number of purchased image licenses
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PurchasedAuthorizedCnt")]
        public ulong? PurchasedAuthorizedCnt{ get; set; }

        /// <summary>
        /// Expiration time
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ExpirationTime")]
        public string ExpirationTime{ get; set; }

        /// <summary>
        /// Valid values: `0` (initial status, which is the default value and not set by the user); `1` (auto-renewal); `2` (no auto-renewal, which is specified by the user).
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AutomaticRenewal")]
        public long? AutomaticRenewal{ get; set; }

        /// <summary>
        /// Number of free image licenses during the trial, which may expire.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("GivenAuthorizedCnt")]
        public ulong? GivenAuthorizedCnt{ get; set; }

        /// <summary>
        /// Start time
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BeginTime")]
        public string BeginTime{ get; set; }

        /// <summary>
        /// Sub-status, the meaning of which is subject to the `State` field.
        /// Valid values when `State` is `4`: `ISOLATE` (isolated); `DESTROED` (terminated).
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SubState")]
        public string SubState{ get; set; }

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
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "CoresCnt", this.CoresCnt);
            this.SetParamSimple(map, prefix + "AuthorizedCoresCnt", this.AuthorizedCoresCnt);
            this.SetParamSimple(map, prefix + "ImageCnt", this.ImageCnt);
            this.SetParamSimple(map, prefix + "AuthorizedImageCnt", this.AuthorizedImageCnt);
            this.SetParamSimple(map, prefix + "PurchasedAuthorizedCnt", this.PurchasedAuthorizedCnt);
            this.SetParamSimple(map, prefix + "ExpirationTime", this.ExpirationTime);
            this.SetParamSimple(map, prefix + "AutomaticRenewal", this.AutomaticRenewal);
            this.SetParamSimple(map, prefix + "GivenAuthorizedCnt", this.GivenAuthorizedCnt);
            this.SetParamSimple(map, prefix + "BeginTime", this.BeginTime);
            this.SetParamSimple(map, prefix + "SubState", this.SubState);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

