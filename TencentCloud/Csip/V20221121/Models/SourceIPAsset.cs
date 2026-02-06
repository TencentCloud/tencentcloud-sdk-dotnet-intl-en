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

    public class SourceIPAsset : AbstractModel
    {
        
        /// <summary>
        /// id of the source IP.
        /// </summary>
        [JsonProperty("ID")]
        public ulong? ID{ get; set; }

        /// <summary>
        /// Source IP.
        /// </summary>
        [JsonProperty("SourceIP")]
        public string SourceIP{ get; set; }

        /// <summary>
        /// Remarks
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// Account associate APPID.
        /// </summary>
        [JsonProperty("AppID")]
        public long? AppID{ get; set; }

        /// <summary>
        /// IP region.
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// API call method.
        /// -1: uncounted.
        /// 0: console invocation.
        /// 1:API
        /// </summary>
        [JsonProperty("EventType")]
        public long? EventType{ get; set; }

        /// <summary>
        /// IP type.
        /// 0: within the account (unremarked).
        /// 1: external accounts (unremarked).
        /// 2: within the account (remarked).
        /// 3: external account (remarked).
        /// </summary>
        [JsonProperty("IPType")]
        public long? IPType{ get; set; }

        /// <summary>
        /// Alarm information list.
        /// </summary>
        [JsonProperty("AccessKeyAlarmList")]
        public AccessKeyAlarmInfo[] AccessKeyAlarmList{ get; set; }

        /// <summary>
        /// ak information list.
        /// </summary>
        [JsonProperty("AKInfo")]
        public AKInfo[] AKInfo{ get; set; }

        /// <summary>
        /// Number of API calls.
        /// </summary>
        [JsonProperty("ActionCount")]
        public long? ActionCount{ get; set; }

        /// <summary>
        /// Last access Time
        /// </summary>
        [JsonProperty("LastAccessTime")]
        public string LastAccessTime{ get; set; }

        /// <summary>
        /// IP associated instance ID. if an empty string, represents an asset not within the account.
        /// </summary>
        [JsonProperty("InstanceID")]
        public string InstanceID{ get; set; }

        /// <summary>
        /// Associated instance name.
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// Account associate Uin.
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// Nickname.
        /// </summary>
        [JsonProperty("Nickname")]
        public string Nickname{ get; set; }

        /// <summary>
        /// Display status.
        /// </summary>
        [JsonProperty("ShowStatus")]
        public bool? ShowStatus{ get; set; }

        /// <summary>
        /// ISP field.
        /// </summary>
        [JsonProperty("ISP")]
        public string ISP{ get; set; }

        /// <summary>
        /// vpc information outside the account.
        /// </summary>
        [JsonProperty("VpcInfo")]
        public SourceIPVpcInfo[] VpcInfo{ get; set; }

        /// <summary>
        /// Cloud type.
        /// 0 for tencent cloud.
        /// </summary>
        [JsonProperty("CloudType")]
        public long? CloudType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamSimple(map, prefix + "SourceIP", this.SourceIP);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "AppID", this.AppID);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "EventType", this.EventType);
            this.SetParamSimple(map, prefix + "IPType", this.IPType);
            this.SetParamArrayObj(map, prefix + "AccessKeyAlarmList.", this.AccessKeyAlarmList);
            this.SetParamArrayObj(map, prefix + "AKInfo.", this.AKInfo);
            this.SetParamSimple(map, prefix + "ActionCount", this.ActionCount);
            this.SetParamSimple(map, prefix + "LastAccessTime", this.LastAccessTime);
            this.SetParamSimple(map, prefix + "InstanceID", this.InstanceID);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "Nickname", this.Nickname);
            this.SetParamSimple(map, prefix + "ShowStatus", this.ShowStatus);
            this.SetParamSimple(map, prefix + "ISP", this.ISP);
            this.SetParamArrayObj(map, prefix + "VpcInfo.", this.VpcInfo);
            this.SetParamSimple(map, prefix + "CloudType", this.CloudType);
        }
    }
}

