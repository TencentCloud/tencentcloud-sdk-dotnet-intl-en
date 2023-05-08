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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescAcItem : AbstractModel
    {
        
        /// <summary>
        /// Access source.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SourceContent")]
        public string SourceContent{ get; set; }

        /// <summary>
        /// Access destination.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TargetContent")]
        public string TargetContent{ get; set; }

        /// <summary>
        /// Protocol.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// Port.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Port")]
        public string Port{ get; set; }

        /// <summary>
        /// Action that Cloud Firewall performs on the traffic. Valid values: accept (allow), drop (reject), and log (monitor).
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RuleAction")]
        public string RuleAction{ get; set; }

        /// <summary>
        /// Description.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Number of rule matching times.
        /// </summary>
        [JsonProperty("Count")]
        public ulong? Count{ get; set; }

        /// <summary>
        /// Rule sequence number.
        /// </summary>
        [JsonProperty("OrderIndex")]
        public ulong? OrderIndex{ get; set; }

        /// <summary>
        /// Access source type. Valid values for an inbound rule: ip, net, template, and location; valid values for an outbound rule: ip, net, template, instance, group, and tag.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SourceType")]
        public string SourceType{ get; set; }

        /// <summary>
        /// Access destination type. Valid values for an inbound rule: ip, net, template, instance, group, and tag; valid values for an outbound rule: ip, net, domain, template, and location.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TargetType")]
        public string TargetType{ get; set; }

        /// <summary>
        /// Unique ID of the rule.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Uuid")]
        public ulong? Uuid{ get; set; }

        /// <summary>
        /// Rule validity.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Invalid")]
        public ulong? Invalid{ get; set; }

        /// <summary>
        /// Valid values: 0: common rules; 1: regional rules.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsRegion")]
        public ulong? IsRegion{ get; set; }

        /// <summary>
        /// Country ID.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CountryCode")]
        public ulong? CountryCode{ get; set; }

        /// <summary>
        /// City ID.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CityCode")]
        public ulong? CityCode{ get; set; }

        /// <summary>
        /// Country name.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CountryName")]
        public string CountryName{ get; set; }

        /// <summary>
        /// City name.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CityName")]
        public string CityName{ get; set; }

        /// <summary>
        /// Cloud provider code.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CloudCode")]
        public string CloudCode{ get; set; }

        /// <summary>
        /// Valid values: 0: common rules; 1: cloud provider rules.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsCloud")]
        public ulong? IsCloud{ get; set; }

        /// <summary>
        /// Rule status. Valid values: true: enabled; false: disabled.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Enable")]
        public string Enable{ get; set; }

        /// <summary>
        /// Rule direction. Valid values: 1: inbound; 0: outbound.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Direction")]
        public ulong? Direction{ get; set; }

        /// <summary>
        /// Instance name.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// UUID for internal use. Generally, this field is not required.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("InternalUuid")]
        public long? InternalUuid{ get; set; }

        /// <summary>
        /// Rule status. This field is valid when you query rule matching details. Valid values: 0: new; 1: deleted; 2: edited and deleted.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// Details of associated tasks
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BetaList")]
        public BetaInfoByACL[] BetaList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SourceContent", this.SourceContent);
            this.SetParamSimple(map, prefix + "TargetContent", this.TargetContent);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "RuleAction", this.RuleAction);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Count", this.Count);
            this.SetParamSimple(map, prefix + "OrderIndex", this.OrderIndex);
            this.SetParamSimple(map, prefix + "SourceType", this.SourceType);
            this.SetParamSimple(map, prefix + "TargetType", this.TargetType);
            this.SetParamSimple(map, prefix + "Uuid", this.Uuid);
            this.SetParamSimple(map, prefix + "Invalid", this.Invalid);
            this.SetParamSimple(map, prefix + "IsRegion", this.IsRegion);
            this.SetParamSimple(map, prefix + "CountryCode", this.CountryCode);
            this.SetParamSimple(map, prefix + "CityCode", this.CityCode);
            this.SetParamSimple(map, prefix + "CountryName", this.CountryName);
            this.SetParamSimple(map, prefix + "CityName", this.CityName);
            this.SetParamSimple(map, prefix + "CloudCode", this.CloudCode);
            this.SetParamSimple(map, prefix + "IsCloud", this.IsCloud);
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamSimple(map, prefix + "Direction", this.Direction);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "InternalUuid", this.InternalUuid);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArrayObj(map, prefix + "BetaList.", this.BetaList);
        }
    }
}

