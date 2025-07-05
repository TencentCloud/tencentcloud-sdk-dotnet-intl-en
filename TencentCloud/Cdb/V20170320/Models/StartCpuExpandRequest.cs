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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class StartCpuExpandRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance ID.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Scale-out mode. Valid values: auto and
        /// manual.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Number of CPU cores to increase during manual scale-out. This parameter is required when Type is set to manual.
        /// </summary>
        [JsonProperty("ExpandCpu")]
        public long? ExpandCpu{ get; set; }

        /// <summary>
        /// Automatic scale-out policy. This parameter is required when Type is set to auto.
        /// </summary>
        [JsonProperty("AutoStrategy")]
        public AutoStrategy AutoStrategy{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "ExpandCpu", this.ExpandCpu);
            this.SetParamObj(map, prefix + "AutoStrategy.", this.AutoStrategy);
        }
    }
}

