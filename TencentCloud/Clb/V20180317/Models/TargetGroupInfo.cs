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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TargetGroupInfo : AbstractModel
    {
        
        /// <summary>
        /// Target group ID
        /// </summary>
        [JsonProperty("TargetGroupId")]
        public string TargetGroupId{ get; set; }

        /// <summary>
        /// `vpcid` of target group
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// Target group name
        /// </summary>
        [JsonProperty("TargetGroupName")]
        public string TargetGroupName{ get; set; }

        /// <summary>
        /// Specifies the default port of the target group. for a full listen target group, this field returns 0, indicating an invalid port.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Port")]
        public ulong? Port{ get; set; }

        /// <summary>
        /// Target group creation time
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// Target group modification time
        /// </summary>
        [JsonProperty("UpdatedTime")]
        public string UpdatedTime{ get; set; }

        /// <summary>
        /// Associated rule array. This parameter cannot be obtained when the DescribeTargetGroupList API is called.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AssociatedRule")]
        public AssociationItem[] AssociatedRule{ get; set; }

        /// <summary>
        /// Backend forwarding protocol of the target group. only returns valid values for the new version (v2) target group.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// Scheduling algorithm. returns a valid value only when the backend forwarding protocol is HTTP, HTTPS, or GRPC. available values:.
        /// <ur>
        /// <Li>WRR: weighted round-robin.</li>.
        /// <Li>LEAST_CONN: specifies the least connection.</li>.
        /// <Li>IP_HASH: based on ip hash.</li>.
        /// </ur>
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ScheduleAlgorithm")]
        public string ScheduleAlgorithm{ get; set; }

        /// <summary>
        /// Health check details.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("HealthCheck")]
        public TargetGroupHealthCheck HealthCheck{ get; set; }

        /// <summary>
        /// Target group type, currently supported v1 (legacy version target group) and v2 (new version target group). defaults to v1 (legacy version target group).
        /// </summary>
        [JsonProperty("TargetGroupType")]
        public string TargetGroupType{ get; set; }

        /// <summary>
        /// Number of rules associated with the target group.
        /// </summary>
        [JsonProperty("AssociatedRuleCount")]
        public long? AssociatedRuleCount{ get; set; }

        /// <summary>
        /// Specifies the number of instances in the target group.
        /// </summary>
        [JsonProperty("RegisteredInstancesCount")]
        public long? RegisteredInstancesCount{ get; set; }

        /// <summary>
        /// Tag.
        /// </summary>
        [JsonProperty("Tag")]
        public TagInfo[] Tag{ get; set; }

        /// <summary>
        /// Default weight. only target groups of v2 type return this field. when NULL is returned, it means the default weight is not set.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Weight")]
        public ulong? Weight{ get; set; }

        /// <summary>
        /// Specifies whether to listen to all target groups.
        /// </summary>
        [JsonProperty("FullListenSwitch")]
        public bool? FullListenSwitch{ get; set; }

        /// <summary>
        /// Whether to enable persistent connections. valid only when the backend forwarding protocol is HTTP/HTTPS/GRPC and returned by the target group.
        /// </summary>
        [JsonProperty("KeepaliveEnable")]
        public bool? KeepaliveEnable{ get; set; }

        /// <summary>
        /// Session persistence time. valid only when the backend forwarding protocol is HTTP/HTTPS/GRPC and the target group returns a valid value.
        /// </summary>
        [JsonProperty("SessionExpireTime")]
        public long? SessionExpireTime{ get; set; }

        /// <summary>
        /// IP version.
        /// </summary>
        [JsonProperty("IpVersion")]
        public string IpVersion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TargetGroupId", this.TargetGroupId);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "TargetGroupName", this.TargetGroupName);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "UpdatedTime", this.UpdatedTime);
            this.SetParamArrayObj(map, prefix + "AssociatedRule.", this.AssociatedRule);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "ScheduleAlgorithm", this.ScheduleAlgorithm);
            this.SetParamObj(map, prefix + "HealthCheck.", this.HealthCheck);
            this.SetParamSimple(map, prefix + "TargetGroupType", this.TargetGroupType);
            this.SetParamSimple(map, prefix + "AssociatedRuleCount", this.AssociatedRuleCount);
            this.SetParamSimple(map, prefix + "RegisteredInstancesCount", this.RegisteredInstancesCount);
            this.SetParamArrayObj(map, prefix + "Tag.", this.Tag);
            this.SetParamSimple(map, prefix + "Weight", this.Weight);
            this.SetParamSimple(map, prefix + "FullListenSwitch", this.FullListenSwitch);
            this.SetParamSimple(map, prefix + "KeepaliveEnable", this.KeepaliveEnable);
            this.SetParamSimple(map, prefix + "SessionExpireTime", this.SessionExpireTime);
            this.SetParamSimple(map, prefix + "IpVersion", this.IpVersion);
        }
    }
}

