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

    public class DescribeCWPMachinesRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Group account member id</p>
        /// </summary>
        [JsonProperty("MemberId")]
        public string[] MemberId{ get; set; }

        /// <summary>
        /// <p>1. Primary table field filtering (requires specifying OperatorType)<br>MachineName: host name, supports OperatorType 9 (fuzzy), 7 (IN), Values example: ["test-server"]<br>MachineIp: private IP address, supports OperatorType 9 (fuzzy), 7 (IN), Values example: ["10.0.0.1"]<br>MachineWanIp: public network IP, supports OperatorType 9 (fuzzy), 7 (IN), Values example: ["1.2.3.4"]<br>InstanceID: instance ID, supports OperatorType 9 (fuzzy), 7 (IN), Values example: ["ins-xxxxx"]<br>MachineStatus / InstanceStatus: instance status, supports OperatorType 7 (IN), 1 (equal), Values example: ["RUNNING"], available Values: RUNNING/STOPPED/EXPIRED<br>MachineOs: operating system type, supports OperatorType 7 (IN), Values example: ["1"], the value is a numeric code, see OsType description below<br>VpcId: VPC ID, supports OperatorType 7 (IN), 1 (equal), Values example: ["VPC-xxxxx"]<br>CloudFromEnum: cloud service provider, supports OperatorType 7 (IN), 1 (equal), Values example: ["0"], the value is a numeric code, see CloudFrom description below<br>Region: Region, supports OperatorType 7 (IN), 1 (equal), Values example: ["ap-guangzhou"]<br>AppId: account AppId, supports OperatorType 7 (IN), 1 (equal), Values example: ["1234567890"]<br>ProjectId: project ID, supports OperatorType 7 (IN), 1 (equal), Values example: ["0"]</p><p>2. Pre-filter fields (no OperatorType required)<br>AgentStatus: Agent status, single selection, Values example: ["ONLINE"], available Values: ONLINE/OFFLINE/UNINSTALL<br>ProtectType: protection type (comprehensive), Values example: ["ULTIMATE"], available Values: BASIC/PRO/ULTIMATE/NONE<br>CsipProtectType: CSIP protection type, Values example: ["ULTIMATE"], available Values: BASIC/PRO/ULTIMATE/NONE<br>CloudTags: cloud tag, Values example: ["tagKey$tagValue"], format: tagKey$tagValue or tagKey (matches key only), up to 5 Values<br>Tags: asset tag, Values example: ["123"], the value is a tag ID<br>ExposedStatus: exposure status, single selection, Values example: ["EXPOSED"], available Values: NOT_APPLICABLE/EXPOSED/UNEXPOSED</p><p>3. Special filter fields (no OperatorType required)<br>NetworkType: network type, single selection, Values example: ["1"], 1=VPC network, 2=BASIC network, 3=Non-Tencent Cloud Network<br>MachineType: machine type, multiple selections allowed, Values example: ["CVM"], available Values: CVM/BM/ECM/LH/EKS-NATIVE/ECS/EC2/VMS<br>Common: general search, single selection, Values example: ["keyword"], performs fuzzy matching on private IP address, public network IP, host name, and instance ID at the same time</p>
        /// </summary>
        [JsonProperty("Filter")]
        public Filter Filter{ get; set; }

        /// <summary>
        /// <p>Whether TAT status information is required</p>
        /// </summary>
        [JsonProperty("NeedTatStatus")]
        public bool? NeedTatStatus{ get; set; }

        /// <summary>
        /// <p>Whether additional information is required, such as security center tags and Tencent Cloud tags</p>
        /// </summary>
        [JsonProperty("MoreInformation")]
        public bool? MoreInformation{ get; set; }

        /// <summary>
        /// <p>Whether container information is required, such as number of containers, cores, and container protection status</p>
        /// </summary>
        [JsonProperty("NeedContainerInfo")]
        public bool? NeedContainerInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "MemberId.", this.MemberId);
            this.SetParamObj(map, prefix + "Filter.", this.Filter);
            this.SetParamSimple(map, prefix + "NeedTatStatus", this.NeedTatStatus);
            this.SetParamSimple(map, prefix + "MoreInformation", this.MoreInformation);
            this.SetParamSimple(map, prefix + "NeedContainerInfo", this.NeedContainerInfo);
        }
    }
}

