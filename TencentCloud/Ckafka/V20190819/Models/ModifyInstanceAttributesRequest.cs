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

namespace TencentCloud.Ckafka.V20190819.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyInstanceAttributesRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>ckafka cluster instance Id, which can be obtained through the <a href="https://www.tencentcloud.com/document/product/597/40835?from_cn_redirect=1">DescribeInstances</a> API</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>Maximum retention time of instance log, in minutes, with a maximum of 90 days and a minimum of 1 min</p>
        /// </summary>
        [JsonProperty("MsgRetentionTime")]
        public long? MsgRetentionTime{ get; set; }

        /// <summary>
        /// <p>ckafka cluster instance Name</p>
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// <p>Instance configuration</p>
        /// </summary>
        [JsonProperty("Config")]
        public ModifyInstanceAttributesConfig Config{ get; set; }

        /// <summary>
        /// <p>Dynamic message retention policy configuration</p>
        /// </summary>
        [JsonProperty("DynamicRetentionConfig")]
        public DynamicRetentionTime DynamicRetentionConfig{ get; set; }

        /// <summary>
        /// <p>Used to modify the scheduled task execution time for edition upgrade or upgrade version, Unix timestamp, accurate to the second</p>
        /// </summary>
        [JsonProperty("RebalanceTime")]
        public long? RebalanceTime{ get; set; }

        /// <summary>
        /// <p>Public network bandwidth: minimum 3Mbps, maximum 999Mbps. Only the Pro Edition supports filling in.</p>
        /// </summary>
        [JsonProperty("PublicNetwork")]
        public long? PublicNetwork{ get; set; }

        /// <summary>
        /// <p>Configure dynamic disk expansion policy</p>
        /// </summary>
        [JsonProperty("DynamicDiskConfig")]
        [System.Obsolete]
        public DynamicDiskConfig DynamicDiskConfig{ get; set; }

        /// <summary>
        /// <p>Single message size at the instance level (unit: byte) Maximum 12582912 (excluding) Minimum 1024 (excluding)</p>
        /// </summary>
        [JsonProperty("MaxMessageByte")]
        public ulong? MaxMessageByte{ get; set; }

        /// <summary>
        /// <p>Whether to allow unsynchronized replicas to be elected as leader: 1 Enable 0 Disable</p>
        /// </summary>
        [JsonProperty("UncleanLeaderElectionEnable")]
        public long? UncleanLeaderElectionEnable{ get; set; }

        /// <summary>
        /// <p>Instance deletion protection switch: 1: enabled 0: disabled</p>
        /// </summary>
        [JsonProperty("DeleteProtectionEnable")]
        public long? DeleteProtectionEnable{ get; set; }

        /// <summary>
        /// <p>Message retention size at the instance level</p>Measurement unit: byte<br>Default value: -1<br><p>Message retention size at the instance level</p>
        /// </summary>
        [JsonProperty("RetentionBytes")]
        public long? RetentionBytes{ get; set; }

        /// <summary>
        /// <p>Ban Status for high-risk admin interface; true to ban high-risk adminApi; no support for turning on after closing, only supported in Pro Edition; default false, no action taken for high-risk admin interface</p>
        /// </summary>
        [JsonProperty("AdminSecurity")]
        public bool? AdminSecurity{ get; set; }

        /// <summary>
        /// <p>The maximum idle time of a transaction ID. Uncommitted transactions that time out will be marked with expiration.</p>Value ranges from 3600000 to 604800000.<br>Unit: ms
        /// </summary>
        [JsonProperty("TransactionalIdExpirationMs")]
        public long? TransactionalIdExpirationMs{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "MsgRetentionTime", this.MsgRetentionTime);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamObj(map, prefix + "Config.", this.Config);
            this.SetParamObj(map, prefix + "DynamicRetentionConfig.", this.DynamicRetentionConfig);
            this.SetParamSimple(map, prefix + "RebalanceTime", this.RebalanceTime);
            this.SetParamSimple(map, prefix + "PublicNetwork", this.PublicNetwork);
            this.SetParamObj(map, prefix + "DynamicDiskConfig.", this.DynamicDiskConfig);
            this.SetParamSimple(map, prefix + "MaxMessageByte", this.MaxMessageByte);
            this.SetParamSimple(map, prefix + "UncleanLeaderElectionEnable", this.UncleanLeaderElectionEnable);
            this.SetParamSimple(map, prefix + "DeleteProtectionEnable", this.DeleteProtectionEnable);
            this.SetParamSimple(map, prefix + "RetentionBytes", this.RetentionBytes);
            this.SetParamSimple(map, prefix + "AdminSecurity", this.AdminSecurity);
            this.SetParamSimple(map, prefix + "TransactionalIdExpirationMs", this.TransactionalIdExpirationMs);
        }
    }
}

