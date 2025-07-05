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

    public class ParamRecord : AbstractModel
    {
        
        /// <summary>
        /// Instance ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Parameter name
        /// </summary>
        [JsonProperty("ParamName")]
        public string ParamName{ get; set; }

        /// <summary>
        /// Parameter value before modification
        /// </summary>
        [JsonProperty("OldValue")]
        public string OldValue{ get; set; }

        /// <summary>
        /// Parameter value after modification
        /// </summary>
        [JsonProperty("NewValue")]
        public string NewValue{ get; set; }

        /// <summary>
        /// Whether the parameter is modified successfully
        /// </summary>
        [JsonProperty("IsSucess")]
        [System.Obsolete]
        public bool? IsSucess{ get; set; }

        /// <summary>
        /// Modification time
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string ModifyTime{ get; set; }

        /// <summary>
        /// Indicates whether the parameter is modified successfully.
        /// </summary>
        [JsonProperty("IsSuccess")]
        public bool? IsSuccess{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "ParamName", this.ParamName);
            this.SetParamSimple(map, prefix + "OldValue", this.OldValue);
            this.SetParamSimple(map, prefix + "NewValue", this.NewValue);
            this.SetParamSimple(map, prefix + "IsSucess", this.IsSucess);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
            this.SetParamSimple(map, prefix + "IsSuccess", this.IsSuccess);
        }
    }
}

