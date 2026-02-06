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

    public class CallRecord : AbstractModel
    {
        
        /// <summary>
        /// Invocation record ID.
        /// </summary>
        [JsonProperty("CallID")]
        public string CallID{ get; set; }

        /// <summary>
        /// Access key.
        /// </summary>
        [JsonProperty("AccessKey")]
        public string AccessKey{ get; set; }

        /// <summary>
        /// Access key remark.
        /// </summary>
        [JsonProperty("AccessKeyRemark")]
        public string AccessKeyRemark{ get; set; }

        /// <summary>
        /// Access key ID.
        /// </summary>
        [JsonProperty("AccessKeyID")]
        public ulong? AccessKeyID{ get; set; }

        /// <summary>
        /// Source IP of the call.
        /// </summary>
        [JsonProperty("SourceIP")]
        public string SourceIP{ get; set; }

        /// <summary>
        /// Source IP of the call remark.
        /// </summary>
        [JsonProperty("SourceIPRemark")]
        public string SourceIPRemark{ get; set; }

        /// <summary>
        /// Source IP region of the call.
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// IP type 0: within the account (unremarked) 1: outside the account (unremarked) 2: within the account (remarked) 3: outside the account (remarked).
        /// </summary>
        [JsonProperty("IPType")]
        public long? IPType{ get; set; }

        /// <summary>
        /// Call interface name.
        /// </summary>
        [JsonProperty("EventName")]
        public string EventName{ get; set; }

        /// <summary>
        /// Call the product name.
        /// </summary>
        [JsonProperty("ProductName")]
        public string ProductName{ get; set; }

        /// <summary>
        /// Invocation type.
        /// 0: console invocation.
        /// 1:API
        /// </summary>
        [JsonProperty("EventType")]
        public long? EventType{ get; set; }

        /// <summary>
        /// Type of user: CAMUser/root/AssumedRole.
        /// </summary>
        [JsonProperty("UserType")]
        public string UserType{ get; set; }

        /// <summary>
        /// User/Role name.
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// Policy List
        /// </summary>
        [JsonProperty("PolicySet")]
        public string[] PolicySet{ get; set; }

        /// <summary>
        /// Number of calls.
        /// </summary>
        [JsonProperty("CallCount")]
        public long? CallCount{ get; set; }

        /// <summary>
        /// Error code.
        /// 0: Successful
        /// </summary>
        [JsonProperty("Code")]
        public long? Code{ get; set; }

        /// <summary>
        /// First time call time.
        /// </summary>
        [JsonProperty("FirstCallTime")]
        public string FirstCallTime{ get; set; }

        /// <summary>
        /// Call time.
        /// </summary>
        [JsonProperty("LastCallTime")]
        public string LastCallTime{ get; set; }

        /// <summary>
        /// IP associated asset ID. if an empty string, means not associated with.
        /// </summary>
        [JsonProperty("InstanceID")]
        public string InstanceID{ get; set; }

        /// <summary>
        /// Associated asset name of the IP.
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// Aggregate date.
        /// </summary>
        [JsonProperty("Date")]
        public string Date{ get; set; }

        /// <summary>
        /// appid
        /// </summary>
        [JsonProperty("AppID")]
        public long? AppID{ get; set; }

        /// <summary>
        /// Display status.
        /// </summary>
        [JsonProperty("ShowStatus")]
        public bool? ShowStatus{ get; set; }

        /// <summary>
        /// Carrier.
        /// </summary>
        [JsonProperty("ISP")]
        public string ISP{ get; set; }

        /// <summary>
        /// vpc information list outside the account.
        /// </summary>
        [JsonProperty("VpcInfo")]
        public SourceIPVpcInfo[] VpcInfo{ get; set; }

        /// <summary>
        /// Request client list.
        /// </summary>
        [JsonProperty("ReqClient")]
        public string[] ReqClient{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CallID", this.CallID);
            this.SetParamSimple(map, prefix + "AccessKey", this.AccessKey);
            this.SetParamSimple(map, prefix + "AccessKeyRemark", this.AccessKeyRemark);
            this.SetParamSimple(map, prefix + "AccessKeyID", this.AccessKeyID);
            this.SetParamSimple(map, prefix + "SourceIP", this.SourceIP);
            this.SetParamSimple(map, prefix + "SourceIPRemark", this.SourceIPRemark);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "IPType", this.IPType);
            this.SetParamSimple(map, prefix + "EventName", this.EventName);
            this.SetParamSimple(map, prefix + "ProductName", this.ProductName);
            this.SetParamSimple(map, prefix + "EventType", this.EventType);
            this.SetParamSimple(map, prefix + "UserType", this.UserType);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamArraySimple(map, prefix + "PolicySet.", this.PolicySet);
            this.SetParamSimple(map, prefix + "CallCount", this.CallCount);
            this.SetParamSimple(map, prefix + "Code", this.Code);
            this.SetParamSimple(map, prefix + "FirstCallTime", this.FirstCallTime);
            this.SetParamSimple(map, prefix + "LastCallTime", this.LastCallTime);
            this.SetParamSimple(map, prefix + "InstanceID", this.InstanceID);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "Date", this.Date);
            this.SetParamSimple(map, prefix + "AppID", this.AppID);
            this.SetParamSimple(map, prefix + "ShowStatus", this.ShowStatus);
            this.SetParamSimple(map, prefix + "ISP", this.ISP);
            this.SetParamArrayObj(map, prefix + "VpcInfo.", this.VpcInfo);
            this.SetParamArraySimple(map, prefix + "ReqClient.", this.ReqClient);
        }
    }
}

