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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MachineGroupInfo : AbstractModel
    {
        
        /// <summary>
        /// Machine group ID
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// Machine group name
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }

        /// <summary>
        /// Machine group type
        /// </summary>
        [JsonProperty("MachineGroupType")]
        public MachineGroupTypeInfo MachineGroupType{ get; set; }

        /// <summary>
        /// Creation time
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// List of tags bound to machine group
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// Whether to enable automatic update for the machine group
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AutoUpdate")]
        public string AutoUpdate{ get; set; }

        /// <summary>
        /// Update start time. We recommend you update LogListener during off-peak hours.
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UpdateStartTime")]
        public string UpdateStartTime{ get; set; }

        /// <summary>
        /// Update end time. We recommend you update LogListener during off-peak hours.
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UpdateEndTime")]
        public string UpdateEndTime{ get; set; }

        /// <summary>
        /// Whether to enable the service log to record the logs generated by the LogListener service itself. After it is enabled, the internal logset `cls_service_logging` and the `loglistener_status`, `loglistener_alarm`, and `loglistener_business` log topics will be created, which will not incur fees.
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ServiceLogging")]
        public bool? ServiceLogging{ get; set; }

        /// <summary>
        /// Regular cleanup time for offline machines in the machine group
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DelayCleanupTime")]
        public long? DelayCleanupTime{ get; set; }

        /// <summary>
        /// Metadata information list of a machine group
        /// </summary>
        [JsonProperty("MetaTags")]
        public MetaTagInfo[] MetaTags{ get; set; }

        /// <summary>
        /// Operating system type, 0: Linux, 1: Windows
        /// </summary>
        [JsonProperty("OSType")]
        public ulong? OSType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
            this.SetParamObj(map, prefix + "MachineGroupType.", this.MachineGroupType);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "AutoUpdate", this.AutoUpdate);
            this.SetParamSimple(map, prefix + "UpdateStartTime", this.UpdateStartTime);
            this.SetParamSimple(map, prefix + "UpdateEndTime", this.UpdateEndTime);
            this.SetParamSimple(map, prefix + "ServiceLogging", this.ServiceLogging);
            this.SetParamSimple(map, prefix + "DelayCleanupTime", this.DelayCleanupTime);
            this.SetParamArrayObj(map, prefix + "MetaTags.", this.MetaTags);
            this.SetParamSimple(map, prefix + "OSType", this.OSType);
        }
    }
}

