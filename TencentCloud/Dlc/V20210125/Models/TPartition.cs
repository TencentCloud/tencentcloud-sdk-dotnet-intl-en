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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TPartition : AbstractModel
    {
        
        /// <summary>
        /// The field name.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// The field type.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// The field description.
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// The partition type.
        /// </summary>
        [JsonProperty("PartitionType")]
        public string PartitionType{ get; set; }

        /// <summary>
        /// The partition format.
        /// </summary>
        [JsonProperty("PartitionFormat")]
        public string PartitionFormat{ get; set; }

        /// <summary>
        /// The separator count of the partition conversion policy.
        /// </summary>
        [JsonProperty("PartitionDot")]
        public long? PartitionDot{ get; set; }

        /// <summary>
        /// The partition conversion policy.
        /// </summary>
        [JsonProperty("Transform")]
        public string Transform{ get; set; }

        /// <summary>
        /// The policy parameters.
        /// </summary>
        [JsonProperty("TransformArgs")]
        public string[] TransformArgs{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamSimple(map, prefix + "PartitionType", this.PartitionType);
            this.SetParamSimple(map, prefix + "PartitionFormat", this.PartitionFormat);
            this.SetParamSimple(map, prefix + "PartitionDot", this.PartitionDot);
            this.SetParamSimple(map, prefix + "Transform", this.Transform);
            this.SetParamArraySimple(map, prefix + "TransformArgs.", this.TransformArgs);
        }
    }
}

