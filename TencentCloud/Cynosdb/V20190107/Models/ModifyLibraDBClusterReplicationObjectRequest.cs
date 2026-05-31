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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyLibraDBClusterReplicationObjectRequest : AbstractModel
    {
        
        /// <summary>
        /// Analysis Cluster ID
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// Read-only analysis engine instance ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Map mode
        /// </summary>
        [JsonProperty("ForceDefaultMapRule")]
        public string ForceDefaultMapRule{ get; set; }

        /// <summary>
        /// sync object
        /// </summary>
        [JsonProperty("Objects")]
        public ReplicationObject[] Objects{ get; set; }

        /// <summary>
        /// Automated mapping rule
        /// </summary>
        [JsonProperty("AutoMapRules")]
        public AutoMapRule[] AutoMapRules{ get; set; }

        /// <summary>
        /// Whether to refresh existing mapping relationships according to the latest mapping rule
        /// </summary>
        [JsonProperty("RefreshMapping")]
        public bool? RefreshMapping{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "ForceDefaultMapRule", this.ForceDefaultMapRule);
            this.SetParamArrayObj(map, prefix + "Objects.", this.Objects);
            this.SetParamArrayObj(map, prefix + "AutoMapRules.", this.AutoMapRules);
            this.SetParamSimple(map, prefix + "RefreshMapping", this.RefreshMapping);
        }
    }
}

