/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeColumnLineageRequest : AbstractModel
    {
        
        /// <summary>
        /// Enumeration value of query direction.
        /// 
        /// - INPUT
        /// - OUTPUT
        /// - BOTH
        /// </summary>
        [JsonProperty("Direction")]
        public string Direction{ get; set; }

        /// <summary>
        /// Field Information
        /// </summary>
        [JsonProperty("Data")]
        public ColumnLineageInfo Data{ get; set; }

        /// <summary>
        /// Single Query Indegree
        /// </summary>
        [JsonProperty("InputDepth")]
        public long? InputDepth{ get; set; }

        /// <summary>
        /// Single Query Outdegree
        /// </summary>
        [JsonProperty("OutputDepth")]
        public long? OutputDepth{ get; set; }

        /// <summary>
        /// Additional Parameters (Pass Caller Information)
        /// </summary>
        [JsonProperty("ExtParams")]
        public RecordField[] ExtParams{ get; set; }

        /// <summary>
        /// Filter Temporary Tables with the default value true
        /// </summary>
        [JsonProperty("IgnoreTemp")]
        public bool? IgnoreTemp{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Direction", this.Direction);
            this.SetParamObj(map, prefix + "Data.", this.Data);
            this.SetParamSimple(map, prefix + "InputDepth", this.InputDepth);
            this.SetParamSimple(map, prefix + "OutputDepth", this.OutputDepth);
            this.SetParamArrayObj(map, prefix + "ExtParams.", this.ExtParams);
            this.SetParamSimple(map, prefix + "IgnoreTemp", this.IgnoreTemp);
        }
    }
}

