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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AccessKeyParamConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>Access Key field type. 1: AccessKeyId, 2: AccessKeySecret, 3: SessionToken</p>
        /// </summary>
        [JsonProperty("FieldType")]
        public long? FieldType{ get; set; }

        /// <summary>
        /// <p>Required or not</p>
        /// </summary>
        [JsonProperty("IsRequired")]
        public bool? IsRequired{ get; set; }

        /// <summary>
        /// <p>header/query field name</p>
        /// </summary>
        [JsonProperty("ParamName")]
        public string ParamName{ get; set; }

        /// <summary>
        /// <p>Default value of the AccessKey, which can be empty.</p>
        /// </summary>
        [JsonProperty("ParamValue")]
        public string ParamValue{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FieldType", this.FieldType);
            this.SetParamSimple(map, prefix + "IsRequired", this.IsRequired);
            this.SetParamSimple(map, prefix + "ParamName", this.ParamName);
            this.SetParamSimple(map, prefix + "ParamValue", this.ParamValue);
        }
    }
}

