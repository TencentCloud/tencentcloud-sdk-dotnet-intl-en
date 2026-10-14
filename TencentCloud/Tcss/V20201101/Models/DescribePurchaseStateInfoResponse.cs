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
        /// <p>0: available for trial application and purchase; 1: purchase only (including failed trial review and expired trial); 2: trial active; 3: Pro Edition active; 4: Pro Edition expired</p>
        /// </summary>
        [JsonProperty("State")]
        public long? State{ get; set; }

        /// <summary>
        /// <p>Total resource cores = total protected cores + unprotected cores</p>
        /// </summary>
        [JsonProperty("AllCoresCnt")]
        public ulong? AllCoresCnt{ get; set; }

        /// <summary>
        /// <p>Total protected cores = purchased cores + trial granted cores + elastic billing cores</p>
        /// </summary>
        [JsonProperty("CoresCnt")]
        public ulong? CoresCnt{ get; set; }

        /// <summary>
        /// <p>Unprotected cores (number of resource cores with protection not enabled)</p>
        /// </summary>
        [JsonProperty("UndefendCoresCnt")]
        public ulong? UndefendCoresCnt{ get; set; }

        /// <summary>
        /// <p>Number of purchased cores</p>
        /// </summary>
        [JsonProperty("AuthorizedCoresCnt")]
        public ulong? AuthorizedCoresCnt{ get; set; }

        /// <summary>
        /// <p>Trial giveaway of Pro Edition cores</p>
        /// </summary>
        [JsonProperty("GivenAuthorizedCoresCnt")]
        public long? GivenAuthorizedCoresCnt{ get; set; }

        /// <summary>
        /// <p>Current number of elastic billing cores</p>
        /// </summary>
        [JsonProperty("CurrentFlexibleCoresCnt")]
        public ulong? CurrentFlexibleCoresCnt{ get; set; }

        /// <summary>
        /// <p>Number of images.</p>
        /// </summary>
        [JsonProperty("ImageCnt")]
        public ulong? ImageCnt{ get; set; }

        /// <summary>
        /// <p>Number of licensed images</p>
        /// </summary>
        [JsonProperty("AuthorizedImageCnt")]
        public ulong? AuthorizedImageCnt{ get; set; }

        /// <summary>
        /// <p>Expiration time.</p>
        /// </summary>
        [JsonProperty("ExpirationTime")]
        public string ExpirationTime{ get; set; }

        /// <summary>
        /// <p>Number of purchased image licenses</p>
        /// </summary>
        [JsonProperty("PurchasedAuthorizedCnt")]
        public ulong? PurchasedAuthorizedCnt{ get; set; }

        /// <summary>
        /// <p>0 indicates the default state (not set by the user, i.e., the initial state), 1 indicates auto-renewal, and 2 indicates explicitly no auto-renewal (set by the user).</p>
        /// </summary>
        [JsonProperty("AutomaticRenewal")]
        public long? AutomaticRenewal{ get; set; }

        /// <summary>
        /// <p>Complimentary image licenses during the trial period may expire.</p>
        /// </summary>
        [JsonProperty("GivenAuthorizedCnt")]
        public ulong? GivenAuthorizedCnt{ get; set; }

        /// <summary>
        /// <p>Start time</p>
        /// </summary>
        [JsonProperty("BeginTime")]
        public string BeginTime{ get; set; }

        /// <summary>
        /// <p>Sub-status (specific meaning depending on the State field)<br>When State is 4, valid values: ISOLATE (isolated) DESTROED (terminated)</p>
        /// </summary>
        [JsonProperty("SubState")]
        public string SubState{ get; set; }

        /// <summary>
        /// <p>Billing key</p>
        /// </summary>
        [JsonProperty("InquireKey")]
        public string InquireKey{ get; set; }

        /// <summary>
        /// <p>Protection policy</p>
        /// </summary>
        [JsonProperty("DefendPolicy")]
        public string DefendPolicy{ get; set; }

        /// <summary>
        /// <p>Upper limit of elastic billing cores</p>
        /// </summary>
        [JsonProperty("FlexibleCoresLimit")]
        public ulong? FlexibleCoresLimit{ get; set; }

        /// <summary>
        /// <p>Number of cores in the protected cluster</p>
        /// </summary>
        [JsonProperty("DefendClusterCoresCnt")]
        public ulong? DefendClusterCoresCnt{ get; set; }

        /// <summary>
        /// <p>Protected host cores</p>
        /// </summary>
        [JsonProperty("DefendHostCoresCnt")]
        public ulong? DefendHostCoresCnt{ get; set; }

        /// <summary>
        /// <p>Number of cores of the Pro Edition for trial use</p>
        /// </summary>
        [JsonProperty("TrialCoresCnt")]
        public ulong? TrialCoresCnt{ get; set; }

        /// <summary>
        /// <p>Number of machines with zero protection containers.</p>
        /// </summary>
        [JsonProperty("NoContainerCoresCnt")]
        public ulong? NoContainerCoresCnt{ get; set; }

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
            this.SetParamSimple(map, prefix + "NoContainerCoresCnt", this.NoContainerCoresCnt);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

