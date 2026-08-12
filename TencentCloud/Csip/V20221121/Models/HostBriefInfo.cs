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

    public class HostBriefInfo : AbstractModel
    {
        
        /// <summary>
        /// Cloud host instance ID
        /// Parameter format: such as ins-instance
        /// </summary>
        [JsonProperty("InstanceID")]
        public string InstanceID{ get; set; }

        /// <summary>
        /// Host QUUID (CWP internal unique identifier)
        /// </summary>
        [JsonProperty("QUUID")]
        public string QUUID{ get; set; }

        /// <summary>
        /// Host UUID
        /// </summary>
        [JsonProperty("UUID")]
        public string UUID{ get; set; }

        /// <summary>
        /// Public network IP address
        /// </summary>
        [JsonProperty("PublicIP")]
        public string PublicIP{ get; set; }

        /// <summary>
        /// Private IP address
        /// </summary>
        [JsonProperty("PrivateIP")]
        public string PrivateIP{ get; set; }

        /// <summary>
        /// CWP Agent status
        /// Enumeration value:
        /// ONLINE: Online
        /// OFFLINE: Offline
        /// UNINSTALLED: Not installed
        /// </summary>
        [JsonProperty("AgentStatus")]
        public string AgentStatus{ get; set; }

        /// <summary>
        /// CVM instance status
        /// Enumeration value:
        /// RUNNING: running.
        /// STOPPED: Stopped
        /// UNKNOWN: unknown
        /// </summary>
        [JsonProperty("InstanceStatus")]
        public string InstanceStatus{ get; set; }

        /// <summary>
        /// Host name
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Account information belonging to
        /// </summary>
        [JsonProperty("Account")]
        public AccountBriefInfo Account{ get; set; }

        /// <summary>
        /// Asset tag list (CSIP internal assets)
        /// </summary>
        [JsonProperty("TagItem")]
        public MiniTagItem[] TagItem{ get; set; }

        /// <summary>
        /// Tag list on cloud (Tag on cloud asset)
        /// </summary>
        [JsonProperty("CloudTag")]
        public Tag[] CloudTag{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceID", this.InstanceID);
            this.SetParamSimple(map, prefix + "QUUID", this.QUUID);
            this.SetParamSimple(map, prefix + "UUID", this.UUID);
            this.SetParamSimple(map, prefix + "PublicIP", this.PublicIP);
            this.SetParamSimple(map, prefix + "PrivateIP", this.PrivateIP);
            this.SetParamSimple(map, prefix + "AgentStatus", this.AgentStatus);
            this.SetParamSimple(map, prefix + "InstanceStatus", this.InstanceStatus);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamObj(map, prefix + "Account.", this.Account);
            this.SetParamArrayObj(map, prefix + "TagItem.", this.TagItem);
            this.SetParamArrayObj(map, prefix + "CloudTag.", this.CloudTag);
        }
    }
}

