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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CosBucketBillingInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>appid</p>
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }

        /// <summary>
        /// <p>uin</p>
        /// </summary>
        [JsonProperty("OwnerUin")]
        public string OwnerUin{ get; set; }

        /// <summary>
        /// <p>Nickname</p>
        /// </summary>
        [JsonProperty("OwnerNickName")]
        public string OwnerNickName{ get; set; }

        /// <summary>
        /// <p>Number of buckets</p>
        /// </summary>
        [JsonProperty("BucketCount")]
        public ulong? BucketCount{ get; set; }

        /// <summary>
        /// <p>0 Not purchased 1 Purchased separately 2 Shared</p>
        /// </summary>
        [JsonProperty("BuyStatus")]
        public ulong? BuyStatus{ get; set; }

        /// <summary>
        /// <p>Shared account appid.</p>
        /// </summary>
        [JsonProperty("ShareFromAppId")]
        public ulong? ShareFromAppId{ get; set; }

        /// <summary>
        /// <p>uin of the shared account</p>
        /// </summary>
        [JsonProperty("ShareFromUin")]
        public string ShareFromUin{ get; set; }

        /// <summary>
        /// <p>Shared account nickname</p>
        /// </summary>
        [JsonProperty("ShareFromNickName")]
        public string ShareFromNickName{ get; set; }

        /// <summary>
        /// <p>Number of monitored buckets</p>
        /// </summary>
        [JsonProperty("MonitorBucketCount")]
        public ulong? MonitorBucketCount{ get; set; }

        /// <summary>
        /// <p>0: disable; 1: enable</p>
        /// </summary>
        [JsonProperty("IsAutoMonitor")]
        public ulong? IsAutoMonitor{ get; set; }

        /// <summary>
        /// <p>Whether to enable the allowlist log feature</p>
        /// </summary>
        [JsonProperty("LogFeatureWhitelist")]
        public bool? LogFeatureWhitelist{ get; set; }

        /// <summary>
        /// <p>Existence of new postpaid orders</p>
        /// </summary>
        [JsonProperty("IsHaveNewPostOrder")]
        public bool? IsHaveNewPostOrder{ get; set; }

        /// <summary>
        /// <p>Existence of legacy postpaid orders</p>
        /// </summary>
        [JsonProperty("IsHaveOldPostOrder")]
        public bool? IsHaveOldPostOrder{ get; set; }

        /// <summary>
        /// <p>Postpaid Product List</p>
        /// </summary>
        [JsonProperty("PostProductList")]
        public long?[] PostProductList{ get; set; }

        /// <summary>
        /// <p>Default sampling rate for newly-added buckets under this AppId, unit: ratio from 0 to 1</p><p>Value range: [0.001, 1]</p>
        /// </summary>
        [JsonProperty("DefaultSampleRate")]
        public float? DefaultSampleRate{ get; set; }

        /// <summary>
        /// <p>Whether it is a whitelist, used only to control the frontend range and accuracy</p>
        /// </summary>
        [JsonProperty("BucketSamplingRateWhitelist")]
        public bool? BucketSamplingRateWhitelist{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "OwnerUin", this.OwnerUin);
            this.SetParamSimple(map, prefix + "OwnerNickName", this.OwnerNickName);
            this.SetParamSimple(map, prefix + "BucketCount", this.BucketCount);
            this.SetParamSimple(map, prefix + "BuyStatus", this.BuyStatus);
            this.SetParamSimple(map, prefix + "ShareFromAppId", this.ShareFromAppId);
            this.SetParamSimple(map, prefix + "ShareFromUin", this.ShareFromUin);
            this.SetParamSimple(map, prefix + "ShareFromNickName", this.ShareFromNickName);
            this.SetParamSimple(map, prefix + "MonitorBucketCount", this.MonitorBucketCount);
            this.SetParamSimple(map, prefix + "IsAutoMonitor", this.IsAutoMonitor);
            this.SetParamSimple(map, prefix + "LogFeatureWhitelist", this.LogFeatureWhitelist);
            this.SetParamSimple(map, prefix + "IsHaveNewPostOrder", this.IsHaveNewPostOrder);
            this.SetParamSimple(map, prefix + "IsHaveOldPostOrder", this.IsHaveOldPostOrder);
            this.SetParamArraySimple(map, prefix + "PostProductList.", this.PostProductList);
            this.SetParamSimple(map, prefix + "DefaultSampleRate", this.DefaultSampleRate);
            this.SetParamSimple(map, prefix + "BucketSamplingRateWhitelist", this.BucketSamplingRateWhitelist);
        }
    }
}

