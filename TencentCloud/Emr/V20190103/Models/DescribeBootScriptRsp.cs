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

    public class DescribeBootScriptRsp : AbstractModel
    {
        
        /// <summary>
        /// Custom script file when resource initialization ends.
        /// </summary>
        [JsonProperty("ResourceAfter")]
        public PreExecuteFileSetting[] ResourceAfter{ get; set; }

        /// <summary>
        /// Custom script file before cluster startup.
        /// </summary>
        [JsonProperty("ClusterBefore")]
        public PreExecuteFileSetting[] ClusterBefore{ get; set; }

        /// <summary>
        /// Custom script file after cluster startup.
        /// </summary>
        [JsonProperty("ClusterAfter")]
        public PreExecuteFileSetting[] ClusterAfter{ get; set; }

        /// <summary>
        /// Custom script before service decommissioning.
        /// </summary>
        [JsonProperty("ServiceBefore")]
        public PreExecuteFileSetting[] ServiceBefore{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "ResourceAfter.", this.ResourceAfter);
            this.SetParamArrayObj(map, prefix + "ClusterBefore.", this.ClusterBefore);
            this.SetParamArrayObj(map, prefix + "ClusterAfter.", this.ClusterAfter);
            this.SetParamArrayObj(map, prefix + "ServiceBefore.", this.ServiceBefore);
        }
    }
}

