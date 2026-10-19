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

    public class CosAuditPayInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>APPID</p>
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }

        /// <summary>
        /// <p>Order status. 0: Not purchased; 1: Normal; 2: Isolated; 3: Terminated; 6: In trial; 7: Expired</p>
        /// </summary>
        [JsonProperty("OrderStatus")]
        public ulong? OrderStatus{ get; set; }

        /// <summary>
        /// <p>The number of purchased object storage entries</p>
        /// </summary>
        [JsonProperty("BucketNum")]
        public ulong? BucketNum{ get; set; }

        /// <summary>
        /// <p>Payment mode. 0: postpaid. 1: prepaid.</p>
        /// </summary>
        [JsonProperty("PayMode")]
        public ulong? PayMode{ get; set; }

        /// <summary>
        /// <p>Whether to purchase separately. 1: purchase separately; 2: shared by other accounts</p>
        /// </summary>
        [JsonProperty("IsSelfBuy")]
        public ulong? IsSelfBuy{ get; set; }

        /// <summary>
        /// <p>Order start time.</p>
        /// </summary>
        [JsonProperty("BeginTime")]
        public string BeginTime{ get; set; }

        /// <summary>
        /// <p>Order expiration time</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <p>0: not set by the user, 1: set to auto-renew by the user, 2: set not to auto-renew by the user</p>
        /// </summary>
        [JsonProperty("AutoRenew")]
        public ulong? AutoRenew{ get; set; }

        /// <summary>
        /// <p>Order duration</p>
        /// </summary>
        [JsonProperty("TimeSpan")]
        public ulong? TimeSpan{ get; set; }

        /// <summary>
        /// <p>Duration unit</p>
        /// </summary>
        [JsonProperty("TimeUnit")]
        public string TimeUnit{ get; set; }

        /// <summary>
        /// <p>Resource id</p>
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// <p>Open beta end time</p>
        /// </summary>
        [JsonProperty("BetaEndTime")]
        public string BetaEndTime{ get; set; }

        /// <summary>
        /// <p>Current system time.</p>
        /// </summary>
        [JsonProperty("TimeNow")]
        public string TimeNow{ get; set; }

        /// <summary>
        /// <p>Whether to share with other accounts. 1: yes; 2: no</p>
        /// </summary>
        [JsonProperty("IsShareToOther")]
        public ulong? IsShareToOther{ get; set; }

        /// <summary>
        /// <p>uin</p>
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// <p>Nickname</p>
        /// </summary>
        [JsonProperty("NickName")]
        public string NickName{ get; set; }

        /// <summary>
        /// <p>Shared bucketIdSet</p>
        /// </summary>
        [JsonProperty("BindBucket")]
        public CosBucketId[] BindBucket{ get; set; }

        /// <summary>
        /// <p>Shared appid</p>
        /// </summary>
        [JsonProperty("SharedAppIdSet")]
        public ulong?[] SharedAppIdSet{ get; set; }

        /// <summary>
        /// <p>Whether pay-as-you-go is enabled</p>
        /// </summary>
        [JsonProperty("PostPayStatus")]
        public ulong? PostPayStatus{ get; set; }

        /// <summary>
        /// <p>0: No trial use yet   1: Trial use completed</p>
        /// </summary>
        [JsonProperty("IsTestUser")]
        public ulong? IsTestUser{ get; set; }

        /// <summary>
        /// <p>Remaining available quantity</p>
        /// </summary>
        [JsonProperty("AvailableBucketNum")]
        public ulong? AvailableBucketNum{ get; set; }

        /// <summary>
        /// <p>Number of buckets with monitoring on</p>
        /// </summary>
        [JsonProperty("MonitorBucketNum")]
        public ulong? MonitorBucketNum{ get; set; }

        /// <summary>
        /// <p>Total number of buckets</p>
        /// </summary>
        [JsonProperty("TotalBucketNum")]
        public ulong? TotalBucketNum{ get; set; }

        /// <summary>
        /// <p>Postpaid product switch state</p>
        /// </summary>
        [JsonProperty("PostProductStatusList")]
        public ulong?[] PostProductStatusList{ get; set; }

        /// <summary>
        /// <p>Purchase status of postpaid products.</p>
        /// </summary>
        [JsonProperty("PostProductBuyStatusList")]
        public ulong?[] PostProductBuyStatusList{ get; set; }

        /// <summary>
        /// <p>New postpaid resource ID</p>
        /// </summary>
        [JsonProperty("NewPostPayResourceId")]
        public string NewPostPayResourceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "OrderStatus", this.OrderStatus);
            this.SetParamSimple(map, prefix + "BucketNum", this.BucketNum);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "IsSelfBuy", this.IsSelfBuy);
            this.SetParamSimple(map, prefix + "BeginTime", this.BeginTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "AutoRenew", this.AutoRenew);
            this.SetParamSimple(map, prefix + "TimeSpan", this.TimeSpan);
            this.SetParamSimple(map, prefix + "TimeUnit", this.TimeUnit);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "BetaEndTime", this.BetaEndTime);
            this.SetParamSimple(map, prefix + "TimeNow", this.TimeNow);
            this.SetParamSimple(map, prefix + "IsShareToOther", this.IsShareToOther);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "NickName", this.NickName);
            this.SetParamArrayObj(map, prefix + "BindBucket.", this.BindBucket);
            this.SetParamArraySimple(map, prefix + "SharedAppIdSet.", this.SharedAppIdSet);
            this.SetParamSimple(map, prefix + "PostPayStatus", this.PostPayStatus);
            this.SetParamSimple(map, prefix + "IsTestUser", this.IsTestUser);
            this.SetParamSimple(map, prefix + "AvailableBucketNum", this.AvailableBucketNum);
            this.SetParamSimple(map, prefix + "MonitorBucketNum", this.MonitorBucketNum);
            this.SetParamSimple(map, prefix + "TotalBucketNum", this.TotalBucketNum);
            this.SetParamArraySimple(map, prefix + "PostProductStatusList.", this.PostProductStatusList);
            this.SetParamArraySimple(map, prefix + "PostProductBuyStatusList.", this.PostProductBuyStatusList);
            this.SetParamSimple(map, prefix + "NewPostPayResourceId", this.NewPostPayResourceId);
        }
    }
}

