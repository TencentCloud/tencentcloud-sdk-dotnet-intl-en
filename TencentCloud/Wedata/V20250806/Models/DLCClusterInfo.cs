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

namespace TencentCloud.Wedata.V20250806.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DLCClusterInfo : AbstractModel
    {
        
        /// <summary>
        /// dlc resource name (the role Uin needs to be added to dlc, otherwise the resource may be unavailable).
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ComputeResources")]
        public string[] ComputeResources{ get; set; }

        /// <summary>
        /// dlc region.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// Specify the default database for the DLC cluster.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DefaultDatabase")]
        public string DefaultDatabase{ get; set; }

        /// <summary>
        /// Cluster configuration tag (only applicable to projects in standard mode and required in standard mode). valid values:.
        /// -Prod (live production environment).
        /// -Dev (development environment).
        /// </summary>
        [JsonProperty("StandardModeEnvTag")]
        public string StandardModeEnvTag{ get; set; }

        /// <summary>
        /// Access account (only applicable to projects in standard mode and required in standard mode), used for submitting dlc tasks.
        /// Use a designated sub-account and set permissions to the corresponding database and table for the sub-account. task owner mode is prone to cause task failure after the person in charge leaves. master account mode is not easy to control permissions when permissions across multiple projects are different.
        /// 
        /// Enumeration value:.
        /// -TASK_RUNNER (task owner).
        /// -OWNER (master account mode).
        /// -SUB (sub-account mode).
        /// </summary>
        [JsonProperty("AccessAccount")]
        public string AccessAccount{ get; set; }

        /// <summary>
        /// Sub-Account id (only applicable to projects in standard mode). when AccessAccount is in sub-account mode, the designated sub-account id information is required. other modes do not require specifying.
        /// </summary>
        [JsonProperty("SubAccountUin")]
        public string SubAccountUin{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "ComputeResources.", this.ComputeResources);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "DefaultDatabase", this.DefaultDatabase);
            this.SetParamSimple(map, prefix + "StandardModeEnvTag", this.StandardModeEnvTag);
            this.SetParamSimple(map, prefix + "AccessAccount", this.AccessAccount);
            this.SetParamSimple(map, prefix + "SubAccountUin", this.SubAccountUin);
        }
    }
}

