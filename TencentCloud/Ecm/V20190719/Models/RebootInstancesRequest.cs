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

namespace TencentCloud.Ecm.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RebootInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// List of IDs of the instances to be restarted. You can request up to 100 instances in a region at a time.
        /// </summary>
        [JsonProperty("InstanceIdSet")]
        public string[] InstanceIdSet{ get; set; }

        /// <summary>
        /// Whether to force restart the instance after it failed to be restarted normally. Valid values:
        /// TRUE: yes;
        /// FALSE: no;
        /// Default value: FALSE.
        /// </summary>
        [JsonProperty("ForceReboot")]
        public bool? ForceReboot{ get; set; }

        /// <summary>
        /// Shutdown type. Valid values:
        /// SOFT: soft shutdown
        /// HARD: hard shutdown
        /// SOFT_FIRST: perform a soft shutdown first; if it fails, perform a hard shutdown
        /// 
        /// Default value: SOFT.
        /// </summary>
        [JsonProperty("StopType")]
        public string StopType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "InstanceIdSet.", this.InstanceIdSet);
            this.SetParamSimple(map, prefix + "ForceReboot", this.ForceReboot);
            this.SetParamSimple(map, prefix + "StopType", this.StopType);
        }
    }
}

