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

namespace TencentCloud.Bi.V20220105.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class JoinRelation : AbstractModel
    {
        
        /// <summary>
        /// Association relationship id, used by the frontend
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("JoinId")]
        public string JoinId{ get; set; }

        /// <summary>
        /// Original table node id
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SourceTableNodeId")]
        public string SourceTableNodeId{ get; set; }

        /// <summary>
        /// Target table node id
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TargetTableNodeId")]
        public string TargetTableNodeId{ get; set; }

        /// <summary>
        /// Association type of multi-table join
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("JoinType")]
        public string JoinType{ get; set; }

        /// <summary>
        /// Field list for joined tables
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Fields")]
        public JoinRelationField[] Fields{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "JoinId", this.JoinId);
            this.SetParamSimple(map, prefix + "SourceTableNodeId", this.SourceTableNodeId);
            this.SetParamSimple(map, prefix + "TargetTableNodeId", this.TargetTableNodeId);
            this.SetParamSimple(map, prefix + "JoinType", this.JoinType);
            this.SetParamArrayObj(map, prefix + "Fields.", this.Fields);
        }
    }
}

