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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GroupGlobalConfs : AbstractModel
    {
        
        /// <summary>
        /// Scaling group information.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("GroupGlobalConf")]
        public AutoScaleResourceConf GroupGlobalConf{ get; set; }

        /// <summary>
        /// Number of nodes scaled out in the current scaling group.
        /// </summary>
        [JsonProperty("CurrentNodes")]
        public long? CurrentNodes{ get; set; }

        /// <summary>
        /// Number of postpaid nodes scaled out in the current scaling group.
        /// </summary>
        [JsonProperty("CurrentPostPaidNodes")]
        public long? CurrentPostPaidNodes{ get; set; }

        /// <summary>
        /// Number of spot instance nodes scaled out in the current scaling group.
        /// </summary>
        [JsonProperty("CurrentSpotPaidNodes")]
        public long? CurrentSpotPaidNodes{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "GroupGlobalConf.", this.GroupGlobalConf);
            this.SetParamSimple(map, prefix + "CurrentNodes", this.CurrentNodes);
            this.SetParamSimple(map, prefix + "CurrentPostPaidNodes", this.CurrentPostPaidNodes);
            this.SetParamSimple(map, prefix + "CurrentSpotPaidNodes", this.CurrentSpotPaidNodes);
        }
    }
}

