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
        /// 
        /// </summary>
        [JsonProperty("AllCoresCnt")]
        public ulong? AllCoresCnt{ get; set; }

        /// <summary>
        /// Total number of protected cores. It is the sum of the number of purchased cores, the number of free trial cores, and the number of elastic billing cores.
        /// </summary>
        [JsonProperty("CoresCnt")]
        public ulong? CoresCnt{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("UndefendCoresCnt")]
        public ulong? UndefendCoresCnt{ get; set; }

        /// <summary>
        /// Number of purchased cores
        /// </summary>
        [JsonProperty("AuthorizedCoresCnt")]
        public ulong? AuthorizedCoresCnt{ get; set; }

        /// <summary>
        /// Number of free trial cores for Pro Edition.
        /// </summary>
        [JsonProperty("GivenAuthorizedCoresCnt")]
        public long? GivenAuthorizedCoresCnt{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("CurrentFlexibleCoresCnt")]
        public ulong? CurrentFlexibleCoresCnt{ get; set; }

        /// <summary>
        /// Image count
        /// </summary>
        [JsonProperty("ImageCnt")]
        public ulong? ImageCnt{ get; set; }

        /// <summary>
        /// Number of licensed images
        /// </summary>
        [JsonProperty("AuthorizedImageCnt")]
        public ulong? AuthorizedImageCnt{ get; set; }

        /// <summary>
        /// Expiration time
        /// </summary>
        [JsonProperty("ExpirationTime")]
        public string ExpirationTime{ get; set; }

        /// <summary>
        /// Number of purchased image licenses
        /// </summary>
        [JsonProperty("PurchasedAuthorizedCnt")]
        public ulong? PurchasedAuthorizedCnt{ get; set; }

        /// <summary>
        /// 0 indicates the default status (it has not been set by the user, namely the initial status); 1 indicates automatic renewal; 2 indicates explicit non-automatic renewal (it has been set by the user).
        /// </summary>
        [JsonProperty("AutomaticRenewal")]
        public long? AutomaticRenewal{ get; set; }

        /// <summary>
        /// Complimentary image licenses during the trial period may expire.
        /// </summary>
        [JsonProperty("GivenAuthorizedCnt")]
        public ulong? GivenAuthorizedCnt{ get; set; }

        /// <summary>
        /// Start time.
        /// </summary>
        [JsonProperty("BeginTime")]
        public string BeginTime{ get; set; }

        /// <summary>
        /// Substatus (specific meaning depending on the State field)
        /// Valid values when State is 4: ISOLATE, TERMINATED.
        /// </summary>
        [JsonProperty("SubState")]
        public string SubState{ get; set; }

        /// <summary>
        /// Billing key.
        /// </summary>
        [JsonProperty("InquireKey")]
        public string InquireKey{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("DefendPolicy")]
        public string DefendPolicy{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("FlexibleCoresLimit")]
        public ulong? FlexibleCoresLimit{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("DefendClusterCoresCnt")]
        public ulong? DefendClusterCoresCnt{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("DefendHostCoresCnt")]
        public ulong? DefendHostCoresCnt{ get; set; }

        /// <summary>
        /// Number of trial cores for Pro Edition.
        /// </summary>
        [JsonProperty("TrialCoresCnt")]
        public ulong? TrialCoresCnt{ get; set; }

        /// <summary>
        /// The unique request ID, generated by the server, will be returned for every request (if the request fails to reach the server for other reasons, the request will not obtain a RequestId). RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "AllCoresCnt", this.AllCoresCnt);
            this.SetParamSimple(map, prefix + "CoresCnt", this.CoresCnt);
            this.SetParamSimple(map, prefix + "UndefendCoresCnt", this.UndefendCoresCnt);
            this.SetParamSimple(map, prefix + "AuthorizedCoresCnt", this.AuthorizedCoresCnt);
            this.SetParamSimple(map, prefix + "GivenAuthorizedCoresCnt", this.GivenAuthorizedCoresCnt);
            this.SetParamSimple(map, prefix + "CurrentFlexibleCoresCnt", this.CurrentFlexibleCoresCnt);
            this.SetParamSimple(map, prefix + "ImageCnt", this.ImageCnt);
            this.SetParamSimple(map, prefix + "AuthorizedImageCnt", this.AuthorizedImageCnt);
            this.SetParamSimple(map, prefix + "ExpirationTime", this.ExpirationTime);
            this.SetParamSimple(map, prefix + "PurchasedAuthorizedCnt", this.PurchasedAuthorizedCnt);
            this.SetParamSimple(map, prefix + "AutomaticRenewal", this.AutomaticRenewal);
            this.SetParamSimple(map, prefix + "GivenAuthorizedCnt", this.GivenAuthorizedCnt);
            this.SetParamSimple(map, prefix + "BeginTime", this.BeginTime);
            this.SetParamSimple(map, prefix + "SubState", this.SubState);
            this.SetParamSimple(map, prefix + "InquireKey", this.InquireKey);
            this.SetParamSimple(map, prefix + "DefendPolicy", this.DefendPolicy);
            this.SetParamSimple(map, prefix + "FlexibleCoresLimit", this.FlexibleCoresLimit);
            this.SetParamSimple(map, prefix + "DefendClusterCoresCnt", this.DefendClusterCoresCnt);
            this.SetParamSimple(map, prefix + "DefendHostCoresCnt", this.DefendHostCoresCnt);
            this.SetParamSimple(map, prefix + "TrialCoresCnt", this.TrialCoresCnt);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

