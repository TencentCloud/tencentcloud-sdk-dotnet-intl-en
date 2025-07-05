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

namespace TencentCloud.Lke.V20231130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ValueInfo : AbstractModel
    {
        
        /// <summary>
        /// Value ID.
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// Name.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Value type, 0: unknown or empty; 1: string; 2: integer; 3: float; 4: boolean; 5: array (string array); 6: object_array (structure array); 7: object (structure).
        /// </summary>
        [JsonProperty("ValueType")]
        public long? ValueType{ get; set; }

        /// <summary>
        /// String.
        /// </summary>
        [JsonProperty("ValueStr")]
        public string ValueStr{ get; set; }

        /// <summary>
        /// Int (return as a string to avoid precision loss).
        /// </summary>
        [JsonProperty("ValueInt")]
        public string ValueInt{ get; set; }

        /// <summary>
        /// Float.
        /// </summary>
        [JsonProperty("ValueFloat")]
        public float? ValueFloat{ get; set; }

        /// <summary>
        /// Bool.
        /// </summary>
        [JsonProperty("ValueBool")]
        public bool? ValueBool{ get; set; }

        /// <summary>
        /// Array.
        /// </summary>
        [JsonProperty("ValueStrArray")]
        public string[] ValueStrArray{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "ValueType", this.ValueType);
            this.SetParamSimple(map, prefix + "ValueStr", this.ValueStr);
            this.SetParamSimple(map, prefix + "ValueInt", this.ValueInt);
            this.SetParamSimple(map, prefix + "ValueFloat", this.ValueFloat);
            this.SetParamSimple(map, prefix + "ValueBool", this.ValueBool);
            this.SetParamArraySimple(map, prefix + "ValueStrArray.", this.ValueStrArray);
        }
    }
}

