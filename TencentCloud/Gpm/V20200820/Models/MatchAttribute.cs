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

namespace TencentCloud.Gpm.V20200820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MatchAttribute : AbstractModel
    {
        
        /// <summary>
        /// Attribute name. It can contain up to 128 characters, supporting [a-zA-Z0-9-\.]*.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Attribute type. 0: number, 1: string. Default value: 0
        /// </summary>
        [JsonProperty("Type")]
        public ulong? Type{ get; set; }

        /// <summary>
        /// Numeric attribute value. Default value: 0.0
        /// </summary>
        [JsonProperty("NumberValue")]
        public float? NumberValue{ get; set; }

        /// <summary>
        /// String attribute value. Up to 128 characters are allowed. Default value: ""
        /// </summary>
        [JsonProperty("StringValue")]
        public string StringValue{ get; set; }

        /// <summary>
        /// List attribute value
        /// </summary>
        [JsonProperty("ListValue")]
        public string[] ListValue{ get; set; }

        /// <summary>
        /// Map attribute value
        /// </summary>
        [JsonProperty("MapValue")]
        public AttributeMap[] MapValue{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "NumberValue", this.NumberValue);
            this.SetParamSimple(map, prefix + "StringValue", this.StringValue);
            this.SetParamArraySimple(map, prefix + "ListValue.", this.ListValue);
            this.SetParamArrayObj(map, prefix + "MapValue.", this.MapValue);
        }
    }
}

