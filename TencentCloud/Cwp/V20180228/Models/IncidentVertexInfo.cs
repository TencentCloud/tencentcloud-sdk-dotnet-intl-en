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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class IncidentVertexInfo : AbstractModel
    {
        
        /// <summary>
        /// Event ID
        /// </summary>
        [JsonProperty("IncidentId")]
        public string IncidentId{ get; set; }

        /// <summary>
        /// The name of the table where the event occurred
        /// </summary>
        [JsonProperty("TableName")]
        public string TableName{ get; set; }

        /// <summary>
        /// Node information list, in an array including detailed node information.
        /// </summary>
        [JsonProperty("Vertex")]
        public VertexInfo[] Vertex{ get; set; }

        /// <summary>
        /// Total number of nodes.
        /// </summary>
        [JsonProperty("VertexCount")]
        public long? VertexCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IncidentId", this.IncidentId);
            this.SetParamSimple(map, prefix + "TableName", this.TableName);
            this.SetParamArrayObj(map, prefix + "Vertex.", this.Vertex);
            this.SetParamSimple(map, prefix + "VertexCount", this.VertexCount);
        }
    }
}

